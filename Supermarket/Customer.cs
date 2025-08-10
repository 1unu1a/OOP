namespace Supermarket.System;

public class Customer : ICustomer
{
    public string Name { get; }
    public Wallet Wallet { get; }
    public Basket Basket { get; }
    public Bag Bag { get; }

    public Customer(string name, decimal money)
    {
        Name = name;
        Wallet = new Wallet(money);
        Basket = new Basket();
        Bag = new Bag();
    }

    public bool CanAfford() => Wallet.HasEnough(Basket.GetTotalPrice());

    public void RemoveRandomItemFromBasket() => Basket.RemoveRandomItem();

    public decimal GetBasketTotal() => Basket.GetTotalPrice();

    public void Pay(decimal amount) => Wallet.Withdraw(amount);

    public void MoveBasketToBag()
    {
        foreach (var item in Basket.GetItems())
        {
            Bag.AddItem(item);
        }
        Basket.Clear();
    }
}