namespace War;

public class Squad
{
    public List<Soldier> Soldiers { get; }

    public Squad(List<Soldier> soldiers)
    {
        Soldiers = soldiers;
    }

    public bool HasAliveSoldiers => Soldiers.Any(s => s.IsAlive);

    public void Attack(Squad enemySquad)
    {
        foreach (var soldier in Soldiers.Where(s => s.IsAlive))
        {
            soldier.Attack(enemySquad.Soldiers.Where(s => s.IsAlive).ToList());
        }
    }

    public void RemoveDead()
    {
        Soldiers.RemoveAll(s => !s.IsAlive);
    }
}