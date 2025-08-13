namespace War;

public abstract class Soldier
{
    public string Name { get; }
    public int Health { get; protected set; }
    public int Damage { get; }
    public int Armor { get; }
    protected IBattleLogger Logger { get; }
    protected IRandomService RandomService { get; }

    protected Soldier(string name, SoldierConfig config, IBattleLogger logger, IRandomService randomService)
    {
        Name = name;
        Health = config.Health;
        Damage = config.Damage;
        Armor = config.Armor;
        Logger = logger;
        RandomService = randomService;
    }

    public bool IsAlive => Health > 0;

    public abstract void Attack(List<Soldier> enemies);

    public virtual void TakeDamage(int damage)
    {
        int actualDamage = Math.Max(0, damage - Armor);
        Health -= actualDamage;
        Logger.Log($"{Name} получил {actualDamage} урона (HP: {Health})");
    }
}