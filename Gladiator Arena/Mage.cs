namespace GladiatorArena;

public class Mage : Fighter
{
    private int _mana;
    private readonly int _fireballDamage;

    public Mage(string name, FighterConfig config, IBattleLogger logger)
        : base(name, config, logger)
    {
        _mana = config.ExtraValue;
        _fireballDamage = Attack + 10;
    }

    protected override int CalculateDamage()
    {
        if (_mana > 0)
        {
            _logger.Log($"{Name} применяет Огненный шар на {_fireballDamage} урона!");
            _mana--;
            return _fireballDamage;
        }
        return Attack;
    }

    public override Fighter Clone() => new Mage(Name, _baseConfig, _logger);
}