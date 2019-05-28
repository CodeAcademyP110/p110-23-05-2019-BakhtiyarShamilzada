namespace _23_May_2019
{
    public class Magazine : Book
    {
        public Magazine(string isbn) : base(isbn)
        {
            ISBN = isbn;
            System.Console.WriteLine("Magazine yaradildi");
        }
    }
   
}
