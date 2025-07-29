namespace My.Home.Work.Oop;

public class Library
{
    private List<Book> books = new List<Book>();
    
    public void AddBook(Book book)
    {
        if (books.Contains(book))
        {
            Console.WriteLine("Такая книга уже есть.");
            return;
        }

        books.Add(book);
        Console.WriteLine("Книга добавлена.");
    }
    
    public bool RemoveBook(Book book)
    {
        if (books.Remove(book))
        {
            Console.WriteLine("Книга удалена.");
            return true;
        }

        Console.WriteLine("Книга не найдена.");
        return false;
    }

    public List<Book> FindBooks(Func<Book, bool> predicate)
    {
        return books.Where(predicate).ToList();
    }

    public List<Book> GetAllBooks()
    {
        return new List<Book>(books);
    }

    public void ShowBooks(List<Book> booksToShow)
    {
        if (booksToShow.Count == 0)
        {
            Console.WriteLine("Книги не найдены.");
            return;
        }

        foreach (var book in booksToShow)
        {
            Console.WriteLine(book.GetInfo());
        }
    }
}