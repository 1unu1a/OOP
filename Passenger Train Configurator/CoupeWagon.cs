namespace My.Home.Work.Oop;

public class CoupeWagon : Wagon
{
    public CoupeWagon() : base(36) { }

    public override WagonType Type => WagonType.Coupe;
}