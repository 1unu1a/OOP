namespace GladiatorArena;

public abstract class Fighter : IDamageable
{
    protected readonly IBattleLogger _logger;
    protected readonly FighterConfig _baseConfig;

    public string Name { get; }
    public int Health { get; protected set; }
    public int Attack { get; protected set; }
    public int Defense { get; protected set; }

    public bool IsAlive => Health > 0;

    protected Fighter(string name, FighterConfig config, IBattleLogger logger)
    {
        Name = name;
        _baseConfig = config;
        Health = config.Health;
        Attack = config.Attack;
        Defense = config.Defense;
        _logger = logger;
    }

    public void AttackEnemy(Fighter enemy)
    {
        int damage = CalculateDamage();
        enemy.TakeDamage(damage);
    }
    
    public virtual void TakeDamage(int damage)
    {
        int reduced = CalculateTakeDamage(damage);
        Health -= reduced;
        _logger.Log($"{Name} получил {reduced} урона (осталось {Health} HP)");
    }

    protected abstract int CalculateDamage();
    protected virtual int CalculateTakeDamage(int incomingDamage) => Math.Max(0, incomingDamage - Defense);

    public abstract Fighter Clone();

    public override string ToString() => $"{Name} (HP: {Health}, ATK: {Attack}, DEF: {Defense})";
}