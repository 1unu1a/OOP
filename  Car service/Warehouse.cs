namespace Car.Service;

public class Warehouse
{
    private List<PartStockItem> _items = new List<PartStockItem>();

    public void AddStock(Part part, int quantity)
    {
        PartStockItem existing = _items.FirstOrDefault(i => i.Part.Name == part.Name);
        if (existing != null)
        {
            existing.Add(quantity);
        }
        else
        {
            _items.Add(new PartStockItem(part, quantity));           
        }
    }

    public bool TryUsePart(Part part)
    {
        PartStockItem item = _items.FirstOrDefault(i => i.Part.Name == part.Name);
        return item != null && item.Take();
    }

    public void ShowStock()
    {
        Console.WriteLine("\nСклад:");
        foreach (var item in _items)
        {
            Console.WriteLine($"{item.Part.Name} — {item.Quantity} шт.");
        }
    }
}