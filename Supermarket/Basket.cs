namespace Supermarket.System;

public class Basket : IItemContainer
{
    private readonly List<IProduct> _items = new List<IProduct>();
    public IEnumerable<IProduct> GetItems() => _items;

    public void AddItem(IProduct product) => _items.Add(product);

    public void RemoveItem(IProduct product) => _items.Remove(product);

    public decimal GetTotalPrice() => _items.Sum(p => p.Price);

    public void Clear() => _items.Clear();

    public void RemoveRandomItem()
    {
        if (!_items.Any())
        {
            return;
        }
        var index = RandomService.GenerateRandomNumber(0, _items.Count);
        var removed = _items[index];
        _items.RemoveAt(index);
        Console.WriteLine($"Удалён {removed.Name} из корзины.");
    }
}