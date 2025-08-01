namespace GladiatorArena;

public class UserUtils
{
    private static Random _random = new Random();

    public static int GenerateRandomNumber(int min, int max) => _random.Next(min, max);
}