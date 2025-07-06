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
        Console.WriteLine("Имя: {0}", this.name);
        Console.WriteLine("Уровень: {0}", this.ievel);
        Console.WriteLine("Здоровье: {0}", this.health);
    }
}