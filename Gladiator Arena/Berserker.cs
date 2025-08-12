namespace GladiatorArena;

public class Berserker : Fighter
{
    private readonly int _maxRage;
    private readonly int _healAmount;
    private int _rage;

    public Berserker(string name, FighterConfig config, IBattleLogger logger) 
        : base(name, config, logger)
    {
        _maxRage = config.ExtraValue;
        _healAmount = 20;
    }

    protected override int CalculateDamage()
    {
        _rage++;
        TryRage();
        return Attack;
    }

    private void TryRage()
    {
        if (_rage >= _maxRage)
        {
            Health += _healAmount;
            _logger.Log($"{Name} в ярости! Лечится на {_healAmount} HP.");
            _rage = 0;
        }
    }

    public override Fighter Clone() => new Berserker(Name, _baseConfig, _logger);
}