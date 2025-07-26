namespace Car.Service;

public class Part
{
    public string Name { get; }
    public int Price { get; }

    public Part(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString() => $"{Name} ({Price}₽)";
}