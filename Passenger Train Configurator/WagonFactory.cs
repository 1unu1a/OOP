namespace My.Home.Work.Oop;

public class WagonFactory
{
    public Wagon CreateWagon(int remainingPassengers)
    {
        return remainingPassengers >= 54 ? new PlatzkartWagon() : new CoupeWagon();
    }
}