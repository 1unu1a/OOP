namespace Supermarket.System;

public class Customer : ICustomer
{
    private List<IProduct> _cart = new();
    private List<IProduct> _bag = new();
    
    public string Name { get; }
    public decimal Money { get; private set; }

    public Customer(string name, decimal money)
    {
        Name = name;
        Money = money;
    }

    public void AddToCart(IProduct product) => _cart.Add(product);

    public void AttemptPurchase(ISupermarketService supermarket)
    {
        while (TotalCartPrice() > Money && _cart.Any())
        {
            var removed = _cart[RandomService.GenerateRandomNumber(0, _cart.Count)];
            _cart.Remove(removed);
            Console.WriteLine($"{Name} удалил {removed.Name} из корзины из-за нехватки денег.");
        }

        decimal total = TotalCartPrice();

        if (total <= Money)
        {
            Money -= total;
            _bag.AddRange(_cart);
            supermarket.AddEarnings(total);
            Console.WriteLine($"{Name} успешно оплатил покупки на сумму {total:C}.");
            _cart.Clear();
        }
        else
        {
            Console.WriteLine($"{Name} не может оплатить товары. Корзина пуста.");
        }
    }

    private decimal TotalCartPrice() => _cart.Sum(p => p.Price);
}