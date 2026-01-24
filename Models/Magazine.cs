using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Models;

namespace LibraryApp.Models
{
    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, string author, int year, int issueNumber)
            : base(title, author, year)
        {
            IssueNumber = issueNumber;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Журнал: {Title} / {Author} ({Year}) — Выпуск №{IssueNumber}");
        }
    }
}


