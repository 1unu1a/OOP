namespace GladiatorArena;

public class Berserker : Fighter
{
    private const int MAX_RAGE = 3;
    private const int HEAL_AMOUNT = 20;
    
    private int _rage;

    public Berserker(string name) : base(name, 100, 15, 5) { }

    public override void AttackEnemy(Fighter enemy)
    {
        enemy.TakeDamage(Attack);
        _rage++;
        if (_rage >= MAX_RAGE)
        {
            Health += HEAL_AMOUNT;
            Console.WriteLine($"{Name} в ярости! Лечится на {HEAL_AMOUNT} HP.");
            _rage = 0;
        }
    }

    public override Fighter Clone() => new Berserker(Name);
}