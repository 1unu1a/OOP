namespace War;

public static class SoldierConfigs
{
    public static readonly Dictionary<SoldierType, SoldierConfig> Configs = new()
    {
        { SoldierType.Regular,     new SoldierConfig(100, 10, 3) },
        { SoldierType.Strong,      new SoldierConfig(100, 10, 3, 2) },
        { SoldierType.MultiTarget, new SoldierConfig(100, 10, 3, 2) },
        { SoldierType.RandomMulti, new SoldierConfig(100, 10, 3, 3) }
    };
}