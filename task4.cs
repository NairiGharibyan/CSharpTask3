using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{

    public class Book {
         string Author { get; set; }
        public string Title { get; set; }
        bool isAvailable {  get; set; }

        public Book(string author, string title)
        {
            Author = author;
            Title = title;
            isAvailable = true;
        }

        public void BorrowBook() {
            isAvailable = false;
        }
        public void ReturnBook() {
            isAvailable = true;
        }

        public void display() {
            Console.WriteLine($"Author: {Author}, title: {Title}, available: {isAvailable}");
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Den Braun", "Code");
            Book book2 = new Book("Den Braun", "Inferno");
            Book book3 = new Book("Den Braun", "Angels and Devils");

            book1.BorrowBook();
            book2.BorrowBook();
            book1.ReturnBook();
            book1.display();
            book2.display();
            book3.display();

            Console.ReadLine();
        }
    }
}
