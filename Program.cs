namespace My.Home.Work.Oop
{
    internal class Program //Блок ООП
    {
        static void Main(string[] args)
        {
            //ДЗ: Работа с классами
            Player player = new Player("Коля", 17, 99);
            player.PrintInfo();
            
            //ДЗ: Работа со свойствами
            PlayerProperties playerProperties = new PlayerProperties(1, 10);
            RendererPlayerProperties renderer = new RendererPlayerProperties();
            
            renderer.DrawPlayerProperties(playerProperties);
            
            //ДЗ: База данных игроков
            PlayerDatabase db = new PlayerDatabase();

            PlayerDB p1 = new PlayerDB(1, "Вася123", 10);
            PlayerDB p2 = new PlayerDB(2, "Джеки-Чан", 20);
            PlayerDB p3 = new PlayerDB(3, "Levi", 99);

            db.AddPlayer(p1);
            db.AddPlayer(p2);
            db.AddPlayer(p3);

            db.PrintAllPlayers();

            db.BanPlayer(2);
            db.UnbanPlayer(2);

            db.RemovePlayer(1);

            db.PrintAllPlayers();
        }
    }
}