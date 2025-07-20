namespace My.Home.Work.Oop;

public class TitleFilter : IBookFilter
{
    private readonly string title;
    public TitleFilter(string title) => this.title = title;

    public bool Matches(Book book) => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase);
}