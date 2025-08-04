namespace Supermarket.System;

public class Supermarket : ISupermarketService
{
    private readonly List<IProduct> _catalog = new();
    private readonly Queue<ICustomer> _queue = new();
    private decimal _earnings;

    public Supermarket(IEnumerable<IProduct> products)
    {
        _catalog.AddRange(products);
    }

    public void AddEarnings(decimal amount) => _earnings += amount;

    public void EnqueueCustomer(ICustomer customer) => _queue.Enqueue(customer);

    public void ServeNextCustomer()
    {
        if (_queue.Any())
        {
            var customer = _queue.Dequeue();
            Console.WriteLine($"Обслуживаем клиента: {customer.Name}");
            customer.AttemptPurchase(this);
        }
        else
        {
            Console.WriteLine("Очередь пуста.");
        }
    }

    public void PrintReport()
    {
        Console.WriteLine($"Итого заработано: {_earnings:C}");
    }
}