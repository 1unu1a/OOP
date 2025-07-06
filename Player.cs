namespace My.Home.Work.Oop;

public class Player //ДЗ: Работа с классами
{
    private string name;
    private int ievel;
    private int health;

    public Player(string name, int ievel, int health)
    {
        this.name = name;
        this.ievel = ievel;
        this.health = health;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Информация об игроке:");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Уровень: {ievel}");
        Console.WriteLine($"Здоровье: {health}");
    }
}