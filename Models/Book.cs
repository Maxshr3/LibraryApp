using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Book : LibraryItem, IBorrowable
    {
        public int Pages { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Book(string title, string author, int year, int pages)
            : base(title, author, year)
        {
            if (pages <= 0)
                throw new ArgumentOutOfRangeException(nameof(pages));

            Pages = pages;
        }

        public override void DisplayInfo()
        {
            string status = IsAvailable ? "доступна" : "выдана";
            Console.WriteLine($"Книга: {Title} / {Author} ({Year}) — {Pages} стр. [{status}]");
        }

        public void Borrow(string borrowerName)
        {
            if (!IsAvailable)
            {
                Console.WriteLine($"Книга '{Title}' уже выдана");
                return;
            }

            IsAvailable = false;
            Console.WriteLine($"Книга '{Title}' выдана пользователю {borrowerName}");
        }

        public void Return()
        {
            IsAvailable = true;
            Console.WriteLine($"Книга '{Title}' возвращена");
        }
    }
}

