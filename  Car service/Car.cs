namespace Car.Service;

public class Car
{
    public string Owner { get; }
    public Part BrokenPart { get; }

    public Car(string owner, Part brokenPart)
    {
        Owner = owner;
        BrokenPart = brokenPart;
    }

    public override string ToString() => $"{Owner} поломка: {BrokenPart.Name}";
}