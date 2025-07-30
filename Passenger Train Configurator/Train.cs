namespace My.Home.Work.Oop;

public class Train
{
    private List<Wagon> wagons = new List<Wagon>();
    
    public int TotalCapacity => wagons.Sum(wagon => wagon.Capacity);

    public void AddWagon(Wagon wagon)
    {
        wagons.Add(wagon);
    }

    public void ShowTrain()
    {
        Console.WriteLine("Состав поезда:");
        foreach (var wagon in wagons)
        {
            Console.WriteLine($"{wagon.Type} — {wagon.Capacity} мест");
        }
        Console.WriteLine($"Всего мест: {TotalCapacity}");
    }
}