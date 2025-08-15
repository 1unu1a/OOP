namespace War;

public class MultiTargetSoldier : Soldier
{
    private readonly int _targetsCount;
    
    public MultiTargetSoldier(string name, SoldierConfig config, IBattleLogger logger, IRandomService randomService)
        : base(name, config, logger, randomService)
    {
        _targetsCount = config.ExtraValue;
    }

    public override void Attack(List<Soldier> enemies)
    {
        if (!enemies.Any())
        {
            return;
        }
        var availableTargets = enemies.OrderBy(_ => RandomService.Next(0, 100)).Take(_targetsCount).ToList();
        
        foreach (var target in availableTargets)
        {
            Logger.Log($"{Name} атакует {target.Name} на {Damage}");
            target.TakeDamage(Damage);
        }
    }
}