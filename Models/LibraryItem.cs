using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public abstract class LibraryItem
    {
        public string Title { get; protected set; }
        public string Author { get; protected set; }
        public int Year { get; protected set; }

        protected LibraryItem(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public abstract void DisplayInfo();
    }
}

