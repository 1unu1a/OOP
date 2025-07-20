namespace Shop.System;

public class Seller
{
    private readonly List<Item> _items;

    public Seller(List<Item> items)
    {
        if (items != null)
        {
            _items = items;
        }
        else
        {
            _items = new List<Item>();
        }
    }

    public void ShowItems()
    {
        if (_items.Count == 0)
        {
            Console.WriteLine("У продавца нет товаров.");
            return;
        }

        Console.WriteLine("Товары у продавца:");
        for (int i = 0; i < _items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_items[i].GetInfo()}");
        }
    }

    public bool TrySellItem(int index, out Item item)
    {
        if (index >= 0 && index < _items.Count)
        {
            item = _items[index];
            _items.RemoveAt(index);
            return true;
        }

        item = null;
        return false;
    }
}