namespace Car.Service;

public class AutoService
{
    private const int LADOR_COST = 2000;
    private const int PENALTY = 1500;
    
    private readonly Warehouse _warehouse;
    public int Balance { get; private set; }

    public AutoService(Warehouse warehouse, int startingBalance = 10000)
    {
        _warehouse = warehouse;
        Balance = startingBalance;
    }

    public void ProcessCar(Car car)
    {
        Console.WriteLine($"\n{car}");
        Console.WriteLine($"Ремонт стоит: {car.BrokenPart.Price + LADOR_COST}₽");

        if (_warehouse.TryUsePart(car.BrokenPart))
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