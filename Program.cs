using LibraryApp.Models;
using LibraryApp.Services;

var library = new Library();
bool running = true;

while (running)
{
    Console.Clear();
    Console.WriteLine("=== Библиотека ===");
    Console.WriteLine("1. Добавить книгу");
    Console.WriteLine("2. Добавить журнал");
    Console.WriteLine("3. Показать все");
    Console.WriteLine("4. Поиск книг по автору");
    Console.WriteLine("5. Выдать книгу");
    Console.WriteLine("0. Выход");
    Console.Write("Выбор: ");

    switch (Console.ReadLine())
    {
        case "1": AddBook(library); break;
        case "2": AddMagazine(library); break;
        case "3": ShowAll(library); break;
        case "4": SearchByAuthor(library); break;
        case "5": BorrowBook(library); break;
        case "0": running = false; break;
        default:
            Console.WriteLine("Неверный выбор");
            Console.ReadKey();
            break;
    }
}

static void AddBook(Library library)
{
    try
    {
        Console.Write("Название: ");
        string title = Console.ReadLine();

        Console.Write("Автор: ");
        string author = Console.ReadLine();

        Console.Write("Год: ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Страницы: ");
        int pages = int.Parse(Console.ReadLine());

        library.AddItem(new Book(title, author, year, pages));
        Console.WriteLine("Книга добавлена");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
    Console.ReadKey();
}

static void AddMagazine(Library library)
{
    try
    {
        Console.Write("Название: ");
        string title = Console.ReadLine();

        Console.Write("Автор: ");
        string author = Console.ReadLine();

        Console.Write("Год: ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Номер выпуска: ");
        int issue = int.Parse(Console.ReadLine());

        library.AddItem(new Magazine(title, author, year, issue));
        Console.WriteLine("Журнал добавлен");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
    Console.ReadKey();
}

static void ShowAll(Library library)
{
    library.GetAllItems().ForEach(i => i.DisplayInfo());
    Console.ReadKey();
}

static void SearchByAuthor(Library library)
{
    Console.Write("Автор: ");
    string author = Console.ReadLine();

    var books = library.GetBooksByAuthor(author);
    if (!books.Any())
        Console.WriteLine("Книги не найдены");
    else
        books.ForEach(b => b.DisplayInfo());

    Console.ReadKey();
}

static void BorrowBook(Library library)
{
    Console.Write("Название книги: ");
    string title = Console.ReadLine();

    var book = library.FindBookByTitle(title);
    if (book == null)
        Console.WriteLine("Книга не найдена");
    else
        book.Borrow("Пользователь");

    Console.ReadKey();
}
