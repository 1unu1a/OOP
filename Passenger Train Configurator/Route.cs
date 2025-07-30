namespace My.Home.Work.Oop;

public class Route
{
    public string From { get; }
    public string To { get; }
    
    public Train? Train { get; private set; }
    
    public int Passengers { get; set; }

    public Route(string from, string to)
    {
        From = from;
        To = to;
    }

    public void AssignTrain(Train train) => Train = train;
    
    public override string ToString() => $"{From} — {To}";
}