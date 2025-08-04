namespace Supermarket.System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IProduct> products = new List<IProduct>
            {
                new Product("Хлеб", 30),
                new Product("Молоко", 50),
                new Product("Сыр", 100),
                new Product("Яблоки", 40),
                new Product("Мясо", 100)
            };

            Supermarket supermarket = new (products);

            Customer customer1 = new ("Анна", 150);
            customer1.AddToCart(products[0]);
            customer1.AddToCart(products[1]);
            customer1.AddToCart(products[2]);

            Customer customer2 = new ("Денис", 100);
            customer2.AddToCart(products[2]);
            customer2.AddToCart(products[3]);

            supermarket.EnqueueCustomer(customer1);
            supermarket.EnqueueCustomer(customer2);

            supermarket.ServeNextCustomer();
            supermarket.ServeNextCustomer();
            supermarket.PrintReport();
        }
    }
}