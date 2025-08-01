namespace GladiatorArena;

public class DoubleHitFighter : Fighter
{
    private int _hitCount;
    
    public DoubleHitFighter(string name) : base(name, 100, 13, 5) { }

    public override void AttackEnemy(Fighter enemy)
    {
        _hitCount++;
        enemy.TakeDamage(Attack);
        if (_hitCount % 3 == 0)
        {
            Console.WriteLine($"{Name} наносит дополнительный удар!");
            enemy.TakeDamage(Attack);
        }
    }

    public override Fighter Clone() => new DoubleHitFighter(Name);
}