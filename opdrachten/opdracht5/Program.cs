using System;

namespace opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Author author1 = new Author("Jeroen Vervaeck", "jeroverv@outlook.com", 'M');
            Book book1 = new Book("Dolfijnenknd", author1, 10.99, 5);
            book1.print();
        }
    }
}
