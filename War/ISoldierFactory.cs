namespace War;

public interface ISoldierFactory
{
    Soldier CreateSoldier(SoldierType type, string name);
}