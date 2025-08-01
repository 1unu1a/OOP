namespace GladiatorArena;

public class Dodger : Fighter
{
    public Dodger(string name) : base(name, 100, 10, 3) { }

    public override void TakeDamage(int damage)
    {
        if (UserUtils.GenerateRandomNumber(0, 100) < 30)
        {
            Console.WriteLine($"{Name} уклонился от атаки!");
            return;
        }
        base.TakeDamage(damage);
    }

    public override void AttackEnemy(Fighter enemy) => enemy.TakeDamage(Attack);

    public override Fighter Clone() => new Dodger(Name);
}