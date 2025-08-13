namespace War;

internal class Program
{
    static void Main(string[] args)
    {
        IBattleLogger logger = new BattleLogger();
        IRandomService randomService = new UserUtils();
        ISoldierFactory factory = new SoldierFactory(logger, randomService);

        var squad1 = new Squad(new List<Soldier>
        {
            factory.CreateSoldier(SoldierType.Regular, "Альфа солдат 1"),
            factory.CreateSoldier(SoldierType.Strong, "Альфа солдат 2"),
            factory.CreateSoldier(SoldierType.MultiTarget, "Альфа солдат 3")
        });

        var squad2 = new Squad(new List<Soldier>
        {
            factory.CreateSoldier(SoldierType.RandomMulti, "Бетта солдат 1"),
            factory.CreateSoldier(SoldierType.Regular, "Бетта солдат 2"),
            factory.CreateSoldier(SoldierType.Strong, "Бетта солдат 3")
        });

        while (squad1.HasAliveSoldiers && squad2.HasAliveSoldiers)
        {
            logger.Log("\nХод отряда 1:");
            squad1.Attack(squad2);
            squad2.RemoveDead();

            if (!squad2.HasAliveSoldiers)
            {
                break;
            }

            logger.Log("\nХод отряда 2:");
            squad2.Attack(squad1);
            squad1.RemoveDead();
        }

        logger.Log(squad1.HasAliveSoldiers ? "\nОтряд 1 победил!" : "\nОтряд 2 победил!");
    }
}