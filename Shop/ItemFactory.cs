namespace Shop.System;

public class ItemFactory
{
    public List<Item> CreateDefaultItems()
    {
        return new List<Item>
        {
            new Item("Меч", 1000),
            new Item("Щит", 500),
            new Item("Зелье", 250),
            new Item("Лошадь", 2500),
            new Item("Доспехи", 2000)
        };
    }
}