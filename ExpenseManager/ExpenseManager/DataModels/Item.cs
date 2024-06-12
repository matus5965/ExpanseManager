namespace ExpenseManager.DataModels
{
    public class Item
    {
        public int ID { get; set; }
        public string? Text { get; set; }
        private static Item singleton = new Item();

        public static Item GetWithID(int ID)
        {
            singleton.ID = ID;
            return singleton;
        }

        public override bool Equals(object? obj)
        {
            return obj != null && obj.GetType() == typeof(Item) && ((Item)obj).ID == ID;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        public override string ToString()
        {
            return Text ?? "NULL";
        }
    }
}
