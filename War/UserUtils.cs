namespace War;

public class UserUtils : IRandomService
{
    private readonly Random _random = new Random();
    
    public int Next(int minValue, int maxValue) => _random.Next(minValue, maxValue);
}