namespace Supermarket.System;

public interface ICustomer
{
    string Name { get; }
    decimal Money { get; }
    void AddToCart(IProduct product);
    void AttemptPurchase(ISupermarketService supermarket);
}