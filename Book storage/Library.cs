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
    
    public List<Book> FindBooksByAuthor(string author)
    {
        return books.FindAll(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase));
    }

    public List<Book> FindBooksByTitle(string title)
    {
        return books.FindAll(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }

    public List<Book> FindBooksByYear(int year)
    {
        return books.FindAll(b => b.Year == year);
    }

    public void ShowBooks(List<Book> filteredBooks)
    {
        if (filteredBooks.Count == 0)
        {
            Console.WriteLine("Книги не найдены.");
            return;
        }

        foreach (Book book in filteredBooks)
        {
            Console.WriteLine(book.GetInfo());
        }
    }

    public void ShowAllBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("Библиотека пуста.");
            return;
        }

        foreach (Book book in books)
        {
            Console.WriteLine(book.GetInfo());
        }
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
}