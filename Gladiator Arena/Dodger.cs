namespace GladiatorArena;

public class Dodger : Fighter
{
    private readonly double _dodgeChance;
    public Dodger(string name, FighterConfig config, IBattleLogger logger)
        : base(name, config, logger)
    {
        _dodgeChance = config.AbilityChance;
    }

    protected override int CalculateDamage() => Attack;

    protected override int CalculateTakeDamage(int incomingDamage)
    {
        if (UserUtils.GenerateRandomNumber(0, 100) < _dodgeChance * 100)
        {
            _logger.Log($"{Name} уклонился от атаки!");
            return 0;
        }
        return base.CalculateTakeDamage(incomingDamage);
    }

    public override Fighter Clone() => new Dodger(Name, _baseConfig, _logger);
}