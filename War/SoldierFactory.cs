namespace War;

public class SoldierFactory : ISoldierFactory
{
    private readonly IBattleLogger _logger;
    private readonly IRandomService _random;

    public SoldierFactory(IBattleLogger logger, IRandomService random)
    {
        _logger = logger;
        _random = random;
    }

    public Soldier CreateSoldier(SoldierType type, string name)
    {
        var config = SoldierConfigs.Configs[type];
        return type switch
        {
            SoldierType.Regular     => new RegularSoldier(name, config, _logger, _random),
            SoldierType.Strong      => new StrongSoldier(name, config, _logger, _random),
            SoldierType.MultiTarget => new MultiTargetSoldier(name, config, _logger, _random),
            SoldierType.RandomMulti => new RandomMultiHitSoldier(name, config, _logger, _random),
            _ => throw new ArgumentException("Неизвестный тип солдата")
        };
    }
}