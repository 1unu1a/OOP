namespace GladiatorArena;

internal class Program 
{
    static void Main(string[] args)
    {
        IBattleLogger logger = new BattleLogger();
        IFighterFactory factory = new FighterFactory(logger);
        Arena arena = new Arena(factory, logger);
        arena.Start();
    }
}
