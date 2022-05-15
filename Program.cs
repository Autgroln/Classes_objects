using System;

namespace Classes_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Luv si", "Kaloyan Bazenikov", 123);
                /*
                  book1.title = "Luv si";
                  book1.author = "Kaloyan Bazenikov";
                  book1.pages = 124;
                */



            Console.WriteLine(book1.author);
        }
    }
}
