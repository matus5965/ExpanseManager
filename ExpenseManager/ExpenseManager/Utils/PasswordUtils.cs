using ExpenseManager.DataModels;
using ExpenseManager.SqliteCom;
using System.Security.Cryptography;
using System.Text;

namespace ExpenseManager.Utils
{
    public static class PasswordUtils
    {
        public static string GetSha256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool VerifyUserPassword(string username, string password)
        {
            UserCredentials? userCredentials = SqliteDataAccess.GetUserCredentials(username);
            return userCredentials != null && userCredentials.PasswordHash.Equals(GetSha256Hash(username + password));
        }
    }
}
