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
    
    public override bool Equals(object obj)
    {
        if (obj is not Book other)
            return false;
        
        return Title.Equals(other.Title, StringComparison.OrdinalIgnoreCase)
               && Author.Equals(other.Author, StringComparison.OrdinalIgnoreCase)
               && Year == other.Year;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(
            Title.ToLowerInvariant(),
            Author.ToLowerInvariant(),
            Year);
    }

    public string GetInfo() => $"{Title} — {Author} ({Year})";
    
}