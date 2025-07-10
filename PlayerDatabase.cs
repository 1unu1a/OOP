namespace My.Home.Work.Oop;
public class PlayerDatabase //ДЗ: База данных игроков
{
    private List<PlayerDB> players = new List<PlayerDB>();

    public void AddPlayer(PlayerDB player)
    {
        players.Add(player);
        Console.WriteLine($"Игрок {player.Name} добавлен.");
    }

    public void BanPlayer(int id)
    {
        PlayerDB player = FindPlayerById(id);
        if (player != null)
        {
            player.IsBanned = true;
            Console.WriteLine($"Игрок {player.Name} забанен.");
        }
    }

    public void UnbanPlayer(int id)
    {
        PlayerDB player = FindPlayerById(id);
        if (player != null)
        {
            player.IsBanned = false;
            Console.WriteLine($"Игрок {player.Name} разбанен.");
        }
    }

    public void RemovePlayer(int id)
    {
        PlayerDB player = FindPlayerById(id);
        if (player != null)
        {
            players.Remove(player);
            Console.WriteLine($"Игрок {player.Name} удалён.");
        }
    }

    public void PrintAllPlayers()
    {
        Console.WriteLine("Список игроков:");
        foreach (PlayerDB player in players)
        {
            player.PrintInfo();
        }
    }

    private PlayerDB FindPlayerById(int id)
    {
        foreach (PlayerDB player in players)
        {
            if (player.Id == id)
            {
                return player;
            }
        }
        return null;
    }
}