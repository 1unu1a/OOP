namespace Car.Service;

public class Storage
{
    private List<WarehouseItem> _items = new List<WarehouseItem>();

    public void AddStock(Part part, int quantity)
    {
        WarehouseItem existing = _items.FirstOrDefault(i => i.Part.Name == part.Name);
        if (existing != null)
        {
            existing.Add(quantity);
        }
        else
        {
            _items.Add(new WarehouseItem(part, quantity));           
        }
    }

    public WarehouseItem? GetItem(string partName)
    {
        return _items.FirstOrDefault(p => p.Part.Name == partName);
    }

    public void ShowStock()
    {
        Console.WriteLine("\nСклад:");
        foreach (var item in _items)
        {
            Console.WriteLine($"{item.Part.Name} — {item.Count} шт.");
        }
    }
}