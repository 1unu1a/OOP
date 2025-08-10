namespace Supermarket.System;

public interface ISupermarketService
{
    void EnqueueCustomer(ICustomer customer);
    void ServeNextCustomer();
    void PrintReport();

}