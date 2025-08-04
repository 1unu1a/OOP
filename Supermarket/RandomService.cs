namespace Supermarket.System;

public class RandomService
{
    private static readonly Random _random = new();
    public static int GenerateRandomNumber(int min, int max) => _random.Next(min, max);
}