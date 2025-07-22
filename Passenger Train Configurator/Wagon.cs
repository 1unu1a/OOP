namespace My.Home.Work.Oop;

public abstract class Wagon
{
    public int Capacity { get; }

    protected Wagon(int capacity)
    {
        Capacity = capacity;
    }

    public abstract string GetWagonType();
}