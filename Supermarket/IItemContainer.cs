namespace Supermarket.System;

public interface IItemContainer
{
    IEnumerable<IProduct> GetItems();
    void AddItem(IProduct product);
    void RemoveItem(IProduct product);
    decimal GetTotalPrice();
    void Clear();
}