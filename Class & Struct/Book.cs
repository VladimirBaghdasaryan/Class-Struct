using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class___Struct
{
    internal class Book
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }

        public Book(string author, string name, int pages)
        {
            Author = author;
            Name = name;
            Pages = pages;
        }

        public void Print()
        {
            Console.WriteLine($"Author:{Author} Name:{Name} Pages:{Pages}");
        }
    }
}
