namespace My.Home.Work.Oop;

public class YearFilter : IBookFilter
{
    private readonly int year;
    public YearFilter(int year) => this.year = year;

    public bool Matches(Book book) => book.Year == year;
}