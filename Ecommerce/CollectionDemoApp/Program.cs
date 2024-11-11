using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemoApp
{
    //content class
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }

    //container class
    public class Library
    {
        private List<Book> books = null;
        private string location;
        public Library(string location)
        {
            books = new List<Book>();
            books.Add(new Book { Id=1,Title="Inside C#", Description="best seller",Author="Steve jobs"});
            books.Add(new Book { Id = 2, Title = "Inside C++", Description = "best seller", Author = "Steve jobs" });
            books.Add(new Book { Id = 3, Title = "Inside Java", Description = "best seller", Author = "Steve jobs" });
            this.location = location;

        }
        public string Location
        {
            get
            {
                return this.location;

            }
            set { this.location = value; }
        }

        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //     List<Book> books = new List<Book>();
            // List<string> list = new List<string>();
            // List<int> List2 = new List<int>();
            //    Library pccoeLib=new Library();
            // Library pictLib = new Library();
            string[] names={ "Sachin", "Rahul", "Saurav", "Ravi"};
            string player = names[0];
            string player2 = names[3];
            //
            Library pccoeLib=new Library("Akurdi");
            Console.WriteLine(pccoeLib.Location);
            Book theBook = pccoeLib[1];
            Console.WriteLine();

            Console.ReadLine();



        }
    }
}
