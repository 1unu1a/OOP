namespace GladiatorArena;

public class Mage : Fighter
{
    private int _mana = 3;
    
    public Mage(string name) : base(name, 90, 12, 4) { }

    public override void AttackEnemy(Fighter enemy)
    {
        if (_mana > 0)
        {
            int fireballDamage = Attack + 10;
            Console.WriteLine($"{Name} применяет Огненный шар на {fireballDamage} урона!");
            enemy.TakeDamage(fireballDamage);
            _mana--;
        }
        else
        {
            enemy.TakeDamage(Attack);
        }
    }

    public override Fighter Clone() => new Mage(Name);
}