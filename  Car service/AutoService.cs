namespace Car.Service;

public class AutoService
{
    private const int LADOR_COST = 2000;
    private const int PENALTY = 1500;
    
    private readonly Storage _storage;
    
    public int Balance { get; private set; }

    public AutoService(Storage storage, int startingBalance = 10000)
    {
        _storage = storage;
        Balance = startingBalance;
    }

    public void ProcessCar(Car car)
    {
        Console.WriteLine($"\n{car}");
        Console.WriteLine($"Ремонт стоит: {car.BrokenPart.Price + LADOR_COST}₽");
        
        var item = _storage.GetItem(car.BrokenPart.Name);

        if (item != null && item.Take())
        {
            int total = car.BrokenPart.Price + LADOR_COST;
            Balance += total;
            Console.WriteLine($"Ремонт выполнен. Получено: {total}₽");
        }
        else
        {
            Balance -= PENALTY;
            Console.WriteLine($"Нет детали '{car.BrokenPart.Name}'. Штраф: {PENALTY}₽");
        }

        Console.WriteLine($"Баланс сервиса: {Balance}₽");
    }
}