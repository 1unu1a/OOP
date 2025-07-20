namespace My.Home.Work.Oop;

public class AuthorFilter : IBookFilter
{
    private readonly string author;
    public AuthorFilter(string author) => this.author = author;

    public bool Matches(Book book) => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase);
}