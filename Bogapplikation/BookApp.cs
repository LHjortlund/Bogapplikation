using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogapplikation
{
    //Class for creating book objects with title and author
    public class Book
    {
        //Properties for title and author
        public string Title { get; set; }
        public string Author { get; set; }

        //Constructor for creating book objects

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        //Method for displaying book information
        public void DisplayInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
        }
    }
}
