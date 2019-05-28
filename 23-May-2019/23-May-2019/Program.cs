using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_May_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library(2);

            Book book1 = new Book("09-34-576");
            book1.Price = 20F;
            book1.HasDisCount = true;
            book1.DisCountPercent = 10F;
            Console.WriteLine(book1.ActualPrice);
            library.AddBook(book1);

            //Book book2 = new Book("09-34-576");
            //library.AddBook(book2);

            //Magazine magazine1 = new Magazine("09-34-576");
            //library.AddMagazine(magazine1);

            //Magazine magazine2 = new Magazine("09-34-576");
            //library.AddMagazine(magazine2);

            //Encyclopedic encyclopedic1 = new Encyclopedic("09-34-576");
            //library.AddEncyclopedic(encyclopedic1);

            //Encyclopedic encyclopedic2 = new Encyclopedic("09-34-576");
            //library.AddEncyclopedic(encyclopedic2);

        }
    }
}
