using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private string title; // variable
        private string author;// variable
        private string isbn; // variable

        //Title property to allow access
        //to the title private variable

        public string Title
        {
            get { return title; } // get method
            set { title = value; } // set method
        }
        public string Author
        {
            get { return Author; }
            set { Author = value; }
        }

        public string ISBN
        {
            get { return ISBN; }
            set { ISBN = value; }
        }

        // Constructor to add a new book
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN; 
        }

        // Method to display information about A BOOK
        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();

        }
    }  
}