namespace War;

public class BattleLogger : IBattleLogger
{
    public void Log(string message) => Console.WriteLine(message);
}