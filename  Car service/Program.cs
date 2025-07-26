namespace Car.Service;

internal class Program //ДЗ: Автосервис
{
    static void Main(string[] args)
    {
        Warehouse warehouse = new Warehouse();
        
        foreach (Part part in PartCatalog.AllParts)
        {
            int count = new Random().Next(1, 4);
            warehouse.AddStock(part, count);
        }

        AutoService service = new AutoService(warehouse);
        Random random = new Random();

        while (true)
        {
            warehouse.ShowStock();
            Console.WriteLine($"\nБаланс: {service.Balance}₽");

            Console.WriteLine("\nНажмите Enter для записи нового клиента или '0' для выхода");
            string input = Console.ReadLine();
            if (input == "0")
            {
                break;
            }
            
            string owner = $"Клиент - {random.Next(100, 999)}";
            Car car = new Car(owner, PartCatalog.GetRandomPart());

            service.ProcessCar(car);

            Console.WriteLine("\nНажмите любую клавишу для продолжения");
            Console.ReadKey();
        }
    }
}