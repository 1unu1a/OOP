namespace War;

public class StrongSoldier : Soldier
{
    private readonly int _multiplier;
    
    public StrongSoldier(string name, SoldierConfig config, IBattleLogger logger, IRandomService randomService)
        : base(name, config, logger, randomService)
    {
        _multiplier = config.ExtraValue;
    }

    public override void Attack(List<Soldier> enemies)
    {
        if (!enemies.Any())
        {
            return;
        }
        
        var target = enemies[RandomService.Next(0, enemies.Count)];
        int dmg = Damage * _multiplier;
        Logger.Log($"{Name} сильно атакует {target.Name} на {dmg}");
        target.TakeDamage(dmg);
    }
}