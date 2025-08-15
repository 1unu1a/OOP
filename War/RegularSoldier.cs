namespace War;

public class RegularSoldier : Soldier
{
    public RegularSoldier(string name, SoldierConfig config, IBattleLogger logger, IRandomService randomService)
        : base(name, config, logger, randomService) { }

    public override void Attack(List<Soldier> enemies)
    {
        if (!enemies.Any())
        {
            return;
        }
        
        var target = enemies[RandomService.Next(0, enemies.Count)];
        Logger.Log($"{Name} атакует {target.Name} на {Damage}");
        target.TakeDamage(Damage);
    }
}