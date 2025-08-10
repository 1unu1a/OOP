namespace Supermarket.System;

public interface ICustomer
{
    string Name { get; }
    Wallet Wallet { get; }
    Basket Basket { get; }
    Bag Bag { get; }

    bool CanAfford();
    
    void RemoveRandomItemFromBasket();
    
    decimal GetBasketTotal();
    
    void Pay(decimal amount);
    
    void MoveBasketToBag();
}