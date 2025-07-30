namespace My.Home.Work.Oop;

public class PlatzkartWagon : Wagon
{
    public PlatzkartWagon() : base(54) { }

    public override WagonType Type => WagonType.Platzkart;
}