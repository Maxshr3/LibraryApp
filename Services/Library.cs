using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using LibraryApp.Models;

namespace LibraryApp.Services
{
    public class Library
    {
        private readonly List<LibraryItem> _items = new();

        public void AddItem(LibraryItem item) => _items.Add(item);

        public List<LibraryItem> GetAllItems() => new(_items);

        public List<Book> GetBooksByAuthor(string author)
        {
            return _items
                .OfType<Book>()
                .Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public Book? FindBookByTitle(string title)
        {
            return _items
                .OfType<Book>()
                .FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }
}
