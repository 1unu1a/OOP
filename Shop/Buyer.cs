namespace Shop.System;

public class Buyer
{
    private readonly List<Item> _inventory = new List<Item>();

    public void TakeItem(Item item)
    {
        if (item != null)
        {
            _inventory.Add(item);
        }
    }

    public void ShowInventory()
    {
        if (_inventory.Count == 0)
        {
            Console.WriteLine("У вас нет вещей.");
            return;
        }

        Console.WriteLine("Ваши вещи:");
        foreach (Item item in _inventory)
        {
            Console.WriteLine(item.GetInfo());
        }
    }
}