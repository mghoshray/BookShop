namespace BookShopApp
{
    public class Book
    {
        public string Name { get; set; }
        public Book(string name)
        {
            Name = name;
        }
        public decimal UnitPrice
        {
            get
            {
                return 7;
            }
        }
    }
}
