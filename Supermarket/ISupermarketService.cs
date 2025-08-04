namespace Supermarket.System;

public interface ISupermarketService
{
    void AddEarnings(decimal amount);
    void ServeNextCustomer();
    void EnqueueCustomer(ICustomer customer);
}