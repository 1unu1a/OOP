namespace GladiatorArena;

public interface IFighterFactory
{
    Fighter CreateFighter(FighterType type, string name);
}