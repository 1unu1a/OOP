namespace GladiatorArena;

public class CritFighter : Fighter
{
    private readonly double _critChance;
    public CritFighter(string name, FighterConfig config, IBattleLogger logger)
        : base(name, config, logger)
    {
        _critChance = config.AbilityChance;
    }

    protected override int CalculateDamage()
    {
        if (UserUtils.GenerateRandomNumber(0, 100) < _critChance * 100)
        {
            _logger.Log($"{Name} наносит критический удар!");
            return Attack * 2;
        }
        return Attack;
    }

    public override Fighter Clone() => new CritFighter(Name, _baseConfig, _logger);
}