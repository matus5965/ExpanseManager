using ExpenseManager.DataModels;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using Dapper;
using ExpenseManager.Utils;

namespace ExpenseManager.SqliteCom
{
    public static class SqliteDataAccess
    {
        public static readonly string DateFormat = "dd.MM.yyyy"; 
        public static UserCredentials? GetUserCredentials(string username)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                User? user = con.Query<User>("select * from User where Username = @Username", new { Username = username }).FirstOrDefault();

                if (user == null)
                {
                    return null;
                }

                return con.Query<UserCredentials>("select * from UserCredentials where ID = @ID", user).FirstOrDefault();
            }
        }

        public static User? GetUserWithUsername(string username)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                return con.Query<User>("select * from User where Username = @Username", new { Username = username }).FirstOrDefault();
            }
        }

        // Despite the fact, that username is unique, we want to identify user by their ID.
        // ID is more comfortable to work with.
        public static User? AddUser(User user, string password)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                using (var scope = con.BeginTransaction())
                {
                    string hash = PasswordUtils.GetSha256Hash(user.Username + password);
                    con.Execute("insert into User (Name, Username, Balance) values (@Name, @Username, @Balance)", user);

                    int userID = con.Query<int>("select ID from User where Username = @Username", user).FirstOrDefault(-1);
                    if (userID == -1)
                    {
                        return null;
                    }

                    con.Execute("insert into UserCredentials (ID, PasswordHash) values (@ID, @PasswordHash)", new { ID = userID, PasswordHash = hash });
                    try
                    {
                        scope.Commit();
                    }
                    catch (Exception)
                    {
                        return null;
                    }

                    user.ID = userID;
                    return user;
                }
            }
        }

        public static int AddTransaction(Transaction expense)
        {
            int newID = -1;
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                using (var scope = con.BeginTransaction())
                {
                    con.Execute("insert into Expense (UserID, Type, Category, Subject, Amount, Date)" +
                                "values (@UserID, @Type, @Category, @Subject, @Amount, @Date)", expense);

                    if (expense.Type == TransactionType.Income)
                    {
                        con.Execute("update User set Balance = Balance + @Amount where ID = @UserID", expense);
                    }
                    else
                    {
                        con.Execute("update User set Balance = Balance - @Amount where ID = @UserID", expense);
                    }

                    newID = con.QuerySingle<int>("select last_insert_rowid() as ID");
                    if (newID <= 0)
                    {
                        return -1;
                    }

                    try
                    {
                        scope.Commit();
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }

            return newID;
        }

        public static List<Transaction> GetTransactions(int userID)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                return con.Query<Transaction>($"select * from Expense where UserID = {userID}").ToList();    
            }
        }

        public static void EditTransactions(Transaction oldTransaction, Transaction newTransaction)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute($"update Expense set Type = @Type, Category = @Category," +
                    $"Subject = @Subject, Amount = @Amount, Date = @Date where ID = @ID", newTransaction);

                string oldSignum = "-";
                if (oldTransaction.Type == TransactionType.Expense)
                {
                    oldSignum = "+";
                }

                string newSignum = "+";
                if (newTransaction.Type == TransactionType.Expense)
                {
                    newSignum = "-";
                }

                con.Execute($"update User set Balance = Balance {oldSignum} {oldTransaction.Amount} {newSignum} {newTransaction.Amount} where ID = {oldTransaction.UserID}");
            }
        }

        public static void DeleteTransactions(Transaction expense)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute($"delete from Expense where ID = {expense.ID}");
                string signum = "-";
                if (expense.Type == TransactionType.Expense)
                {
                    signum = "+";
                }

                con.Execute($"update User set Balance = Balance {signum} {expense.Amount} where ID = {expense.UserID}");
            }
        }

        public static void AddCategory(Category category)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("insert into Category (ID, UserID, Name) values (@ID, @UserID, @Name)", category);
            }
        }

        public static List<Category> GetCategories(int userID)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                return con.Query<Category>($"select * from Category where UserID = {userID}").ToList();
            }
        }

        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
