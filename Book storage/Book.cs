namespace My.Home.Work.Oop;

public class Book
{
    public string Title { get; }
    public string Author { get; }
    public int Year { get; }
    
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Title} — {Author}, {Year}";
    }
}