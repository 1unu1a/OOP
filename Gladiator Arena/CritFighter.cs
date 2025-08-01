namespace GladiatorArena;

public class CritFighter : Fighter
{
    public CritFighter(string name) : base(name, 100, 14, 4) { }

    public override void AttackEnemy(Fighter enemy)
    {
        if (UserUtils.GenerateRandomNumber(0, 100) < 25)
        {
            Console.WriteLine($"{Name} наносит критический удар!");
            enemy.TakeDamage(Attack * 2);
        }
        else
        {
            enemy.TakeDamage(Attack);
        }
    }

    public override Fighter Clone() => new CritFighter(Name);
}