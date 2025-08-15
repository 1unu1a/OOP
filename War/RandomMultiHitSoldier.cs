namespace War;

public class RandomMultiHitSoldier : Soldier
{
    private readonly int _hits;
    
    public RandomMultiHitSoldier(string name, SoldierConfig config, IBattleLogger logger, IRandomService randomService)
        : base(name, config, logger, randomService)
    {
        _hits = config.ExtraValue;
    }

    public override void Attack(List<Soldier> enemies)
    {
        if (!enemies.Any())
        {
            return;
        }
        
        for (int i = 0; i < _hits; i++)
        {
            var target = enemies[RandomService.Next(0, enemies.Count)];
            Logger.Log($"{Name} случайно атакует {target.Name} на {Damage}");
            target.TakeDamage(Damage);
        }
    }
}