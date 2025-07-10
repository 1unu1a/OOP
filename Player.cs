namespace My.Home.Work.Oop;

public class Player //ДЗ: Работа с классами
{
    private string name;
    private int level;
    private int health;

    public Player(string name, int level, int health)
    {
        this.name = name;
        this.level = level;
        this.health = health;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Информация об игроке:");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Уровень: {level}");
        Console.WriteLine($"Здоровье: {health}");
    }
}