namespace Supermarket.System;

public class Supermarket : ISupermarketService
{
    private readonly List<IProduct> _catalog = new List<IProduct>();
    private readonly Queue<ICustomer> _queue = new Queue<ICustomer>();
    private decimal _earnings;

    public Supermarket(IEnumerable<IProduct> products)
    {
        _catalog.AddRange(products);
    }

    public void EnqueueCustomer(ICustomer customer) => _queue.Enqueue(customer);

    public void ServeNextCustomer()
    {
        if (!_queue.Any())
        {
            Console.WriteLine("Очередь пуста.");
            return;
        }

        var customer = _queue.Dequeue();
        Console.WriteLine($"\nОбслуживаем клиента: {customer.Name}");
        
        while (!customer.CanAfford() && customer.Basket.GetItems().Any())
        {
            customer.RemoveRandomItemFromBasket();
        }

        if (customer.CanAfford())
        {
            var total = customer.GetBasketTotal();
            customer.Pay(total);
            _earnings += total;
            customer.MoveBasketToBag();
            Console.WriteLine($"{customer.Name} успешно оплатил покупки на сумму {total:C}.");
        }
        else
        {
            Console.WriteLine($"{customer.Name} не смог купить ничего.");
        }
    }

    public void PrintReport()
    {
        Console.WriteLine($"\nИтого заработано: {_earnings:C}");
    }
}