namespace _23_May_2019
{
    public class Book
    {
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }
        public string Count { get; set; }
        public bool HasDisCount { get; set; }
        public float DisCountPercent { get; set; }
        private float myVar;

        public float ActualPrice
        {
            get { return myVar = HasDisCount ? (100 - DisCountPercent) * Price / 100: Price; }
            set { myVar = value; }
        }


        public Book(string isbn)
        {
            ISBN = isbn;
            System.Console.WriteLine("Kitab yaradildi");
        }
    }
}
