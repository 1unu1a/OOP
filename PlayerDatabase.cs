using System;
using System.Collections.Generic;

namespace My.Home.Work.Oop.PlayerSystem
{
    public class PlayerDatabase // ДЗ: База данных игроков
    {
        private Dictionary<int, Player> players = new Dictionary<int, Player>();

        public void AddPlayer(Player player)
        {
            if (players.ContainsKey(player.Id))
            {
                Console.WriteLine($"Игрок с ID {player.Id} уже существует.");
                return;
            }
            players.Add(player.Id, player);
            Console.WriteLine($"Игрок {player.Name} добавлен.");
        }

        public void BanPlayer(int id)
        {
            if (players.TryGetValue(id, out Player player))
            {
                player.IsBanned = true;
                Console.WriteLine($"Игрок {player.Name} забанен.");
            }
        }

        public void UnbanPlayer(int id)
        {
            if (players.TryGetValue(id, out Player player))
            {
                player.IsBanned = false;
                Console.WriteLine($"Игрок {player.Name} разбанен.");
            }
        }

        public void RemovePlayer(int id)
        {
            if (players.TryGetValue(id, out Player player))
            {
                players.Remove(id);
                Console.WriteLine($"Игрок {player.Name} удалён.");
            }
        }

        public void PrintAllPlayers()
        {
            Console.WriteLine("Список игроков:");
            foreach (var pair in players)
            {
                pair.Value.PrintInfo();
            }
        }
    }
}