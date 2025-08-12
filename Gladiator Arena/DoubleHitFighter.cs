namespace GladiatorArena;

public class DoubleHitFighter : Fighter
{
    private int _hitCount;
    private readonly int _extraHitEvery;

    public DoubleHitFighter(string name, FighterConfig config, IBattleLogger logger)
        : base(name, config, logger)
    {
        _extraHitEvery = config.ExtraValue;
    }

    protected override int CalculateDamage()
    {
        _hitCount++;
        int damage = Attack;
        if (_hitCount % _extraHitEvery == 0)
        {
            _logger.Log($"{Name} наносит дополнительный удар!");
            damage += Attack;
        }
        return damage;
    }

    public override Fighter Clone() => new DoubleHitFighter(Name, _baseConfig, _logger);
}