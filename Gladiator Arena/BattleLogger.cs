namespace GladiatorArena;

public class BattleLogger : IBattleLogger
{
    public void Log(string message) => Console.WriteLine(message);
}