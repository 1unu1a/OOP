namespace My.Home.Work.Oop;

public class Library
{
    private readonly List<Book> books = new List<Book>();
    public void AddBook(Book book)
    {
        foreach (Book b in books)
        {
            if (b.Title == book.Title && b.Author == book.Author && b.Year == book.Year)
            {
                Console.WriteLine("Такая книга уже есть в библиотеке.");
                return;
            }
        }

        books.Add(book);
        Console.WriteLine($"Добавлена книга: {book}");
    }

    public void ShowAllBooks()
    {
        Console.WriteLine("Все книги в библиотеке:");
        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }

    public void ShowBooksByFilter(IBookFilter filter)
    {
        bool found = false;
        Console.WriteLine("Найденные книги:");
        foreach (Book book in books)
        {
            if (filter.Matches(book))
            {
                Console.WriteLine(book);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Книг по заданному критерию не найдено.");
        }
    }
    public IReadOnlyList<Book> GetAllBooks()
    {
        return books.AsReadOnly();
    }
}