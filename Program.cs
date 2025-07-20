using My.Home.Work.Oop.PlayerSystem;
using My.Home.Work.Oop.Positioning;

namespace My.Home.Work.Oop
{
   internal class Program
   {
       static void Main(string[] args)
       {
           // ДЗ: Работа с классами
           Player player = new Player(1, "Коля", 17);
           player.PrintInfo();

           // ДЗ: Работа со свойствами
           PlayerProperties position = new PlayerProperties(1, 10);
           RendererPlayerProperties renderer = new RendererPlayerProperties();
           renderer.DrawPlayerProperties(position);

           // ДЗ: База данных игроков
           PlayerDatabase db = new PlayerDatabase();

           Player p1 = new Player(1, "Вася123", 10);
           Player p2 = new Player(2, "Джеки-Чан", 20);
           Player p3 = new Player(3, "Levi", 99);

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