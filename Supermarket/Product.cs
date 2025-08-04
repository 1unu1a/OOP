namespace Supermarket.System;

public class Product : IProduct
{
    public string Name { get; }
    public decimal Price { get; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString() => $"{Name} - {Price:C}";
}