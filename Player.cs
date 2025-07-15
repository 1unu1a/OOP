namespace My.Home.Work.Oop.PlayerSystem
{
    public class Player // ДЗ: База данных игроков, работа с классами
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public bool IsBanned { get; set; }

        public Player(int id, string name, int level)
        {
            Id = id;
            Name = name;
            Level = level;
            IsBanned = false;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"ID: {Id}, Ник: {Name}, Уровень: {Level}, Бан: {(IsBanned ? "Да" : "Нет")}");
        }
    }
}