namespace My.Home.Work.Oop;

public abstract class Wagon
{
    public int Capacity { get; }

    public abstract WagonType Type { get; }
    
    protected Wagon(int capacity)
    {
        Capacity = capacity;
    }
}