namespace My.Home.Work.Oop;

public class Train
{
    private List<Wagon> wagons = new List<Wagon>();

    public void AddWagon(Wagon wagon)
    {
        wagons.Add(wagon);
    }

    public int TotalCapacity => wagons.Sum(wagon => wagon.Capacity);

    public void ShowTrain()
    {
        Console.WriteLine("Состав поезда:");
        foreach (Wagon wagon in wagons)
        {
            Console.WriteLine($"{wagon.GetWagonType()} — {wagon.Capacity} мест");
        }
        Console.WriteLine($"Всего мест: {TotalCapacity}");
    }
}