namespace Supermarket.System;

public class Bag : IItemContainer
{
    private readonly List<IProduct> _items = new List<IProduct>();
    
    public IEnumerable<IProduct> GetItems() => _items;
    
    public void AddItem(IProduct product) => _items.Add(product);

    public void RemoveItem(IProduct product) => _items.Remove(product);

    public decimal GetTotalPrice() => _items.Sum(p => p.Price);
    
    public void Clear() => _items.Clear();
}