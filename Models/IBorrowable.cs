using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public interface IBorrowable
    {
        bool IsAvailable { get; set; }
        void Borrow(string borrowerName);
        void Return();
    }
}


