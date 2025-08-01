namespace Car.Service;

public class PartCatalog
{
    public List<Part> AllParts = new List<Part>()
    {
        new Part("Рычаг", 5000),
        new Part("Фильтр", 1000),
        new Part("Ступица", 3000),
        new Part("Колодка", 2000),
        new Part("Тормозной диск", 15000),
        new Part("Подушка двигателя", 25000)
    };
    
    private readonly Random _random = new Random();

    public Part GetRandomPart()
    {
        Random random = new Random();
        return AllParts[_random.Next(AllParts.Count)];
    }
}