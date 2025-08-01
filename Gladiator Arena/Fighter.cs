namespace GladiatorArena;

public abstract class Fighter : IDamageable
{
    public string Name { get; }
    public int Health { get; protected set; }
    public int Attack { get; protected set; }
    public int Defense { get; protected set; }

    public bool IsAlive => Health > 0;

    protected Fighter(string name, int health, int attack, int defense)
    {
        Name = name;
        Health = health;
        Attack = attack;
        Defense = defense;
    }

    public abstract void AttackEnemy(Fighter enemy);

    public virtual void TakeDamage(int damage)
    {
        int actualDamage = Math.Max(0, damage - Defense);
        Health -= actualDamage;
        Console.WriteLine($"{Name} получил {actualDamage} урона (Осталось: {Health} HP)");
    }

    public abstract Fighter Clone();

    public override string ToString() => $"{Name} (HP: {Health}, ATK: {Attack}, DEF: {Defense})";
}