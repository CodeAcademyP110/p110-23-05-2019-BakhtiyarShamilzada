using System;

namespace _23_May_2019
{
    public class Library
    {
        private readonly Book[] books;
        private readonly Magazine[] magazines;
        private readonly Encyclopedic[] encyclopedias;
        private int BookIndex = 0;
        private int MagazineIndex = 0;
        private int EncyclopedicIndex = 0;
        public Library(int bmeCount)
        {
            books = new Book[bmeCount];
            magazines = new Magazine[bmeCount];
            encyclopedias = new Encyclopedic[bmeCount];
            Console.WriteLine("Library yaradildi");
        }
        public void AddBook(Book book)
        {
            if(BookIndex < books.Length)
            {
                foreach (var item in books)
                {
                    if(item != null)
                    {
                        if (book.ISBN == item.ISBN)
                        {
                            Console.WriteLine("Duplicate ISBN");
                            break;
                        }
                        else
                        {
                            books[BookIndex++] = book;
                            Console.WriteLine("Kitab elave edildi");
                            break;
                        }
                    }
                    
                    else
                    {
                        books[BookIndex++] = book;
                        Console.WriteLine("Kitab elave edildi");
                        break;
                    }
                }
            }
            else
            {
                throw new Exception("There is no place for new Book");
            }
        }
        public void AddMagazine(Magazine magazine)
        {
            if (MagazineIndex < magazines.Length)
            {
                foreach (var item in magazines)
                {
                    if (item != null)
                    {
                        if (magazine.ISBN == item.ISBN)
                        {
                            Console.WriteLine("Duplicate ISBN");
                            break;
                        }
                        else
                        {
                            magazines[MagazineIndex++] = magazine;
                            Console.WriteLine("Magazine elave edildi");
                            break;
                        }
                    }

                    else
                    {
                        magazines[MagazineIndex++] = magazine;
                        Console.WriteLine("Magazine elave edildi");
                        break;
                    }
                }
            }
            else
            {
                throw new Exception("There is no place for new Book");
            }
        }

        public void AddEncyclopedic(Encyclopedic encyclopedic)
        {
            if (EncyclopedicIndex < encyclopedias.Length)
            {
                foreach (var item in encyclopedias)
                {
                    if (item != null)
                    {
                        if (encyclopedic.ISBN == item.ISBN)
                        {
                            Console.WriteLine("Duplicate ISBN");
                            break;
                        }
                        else
                        {
                            encyclopedias[EncyclopedicIndex++] = encyclopedic;
                            Console.WriteLine("Encyclopedic elave edildi");
                            break;
                        }
                    }

                    else
                    {
                        encyclopedias[EncyclopedicIndex++] = encyclopedic;
                        Console.WriteLine("Encyclopedic elave edildi");
                        break;
                    }
                }
            }
            else
            {
                throw new Exception("There is no place for new Book");
            }
        }
    }
}
