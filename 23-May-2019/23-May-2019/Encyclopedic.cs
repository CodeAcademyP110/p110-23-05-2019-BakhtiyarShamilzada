namespace _23_May_2019
{
    public class Encyclopedic : Book
    {
        public Encyclopedic(string isbn) : base(isbn)
        {
            ISBN = isbn;
            System.Console.WriteLine("Encyclopedic yaradildi");
        }
    }
}
