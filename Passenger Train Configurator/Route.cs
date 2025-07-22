namespace My.Home.Work.Oop;

public class Route
{
    public string From { get; }
    public string To { get; }

    public Route(string from, string to)
    {
        From = from;
        To = to;
    }

    public override string ToString() => $"{From} — {To}";
}