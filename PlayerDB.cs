namespace My.Home.Work.Oop;

public class PlayerDB //ДЗ: База данных игроков
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }
    public bool IsBanned { get; set; }

    public PlayerDB(int id, string name, int level)
    {
        this.Id = id;
        this.Name = name;
        this.Level = level;
        IsBanned = false;
    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"ID: {Id}, Ник: {Name}, Уровень: {Level}, Бан: {(IsBanned ? "Да" : "Нет")}");
    }
}