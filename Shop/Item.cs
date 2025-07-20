namespace Shop.System;

public class Item
{
    public string Name { get; }
    public decimal Price { get; }

    public Item(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public string GetInfo()
    {
        return $"{Name} - {Price}₽";
    }
}