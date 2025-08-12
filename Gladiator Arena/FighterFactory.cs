namespace GladiatorArena;

public class FighterFactory : IFighterFactory
{
    private readonly IBattleLogger _logger;

    private readonly Dictionary<FighterType, FighterConfig> _configs = new()
    {
        { FighterType.Berserker,       
            new FighterConfig(100, 15, 5, 0, 3) },
        { FighterType.CritFighter,     
            new FighterConfig(100, 14, 4, 0.25, 0) },
        { FighterType.Dodger,          
            new FighterConfig(100, 10, 3, 0.30, 0) },
        { FighterType.DoubleHitFighter,
            new FighterConfig(100, 13, 5, 0, 3) },
        { FighterType.Mage,            
            new FighterConfig(90, 12, 4, 0, 3) }
    };

    public FighterFactory(IBattleLogger logger) => _logger = logger;

    public Fighter CreateFighter(FighterType type, string name)
    {
        var config = _configs[type];
        return type switch
        {
            FighterType.Berserker => new Berserker(name, config, _logger),
            FighterType.CritFighter => new CritFighter(name, config, _logger),
            FighterType.Dodger => new Dodger(name, config, _logger),
            FighterType.DoubleHitFighter => new DoubleHitFighter(name, config, _logger),
            FighterType.Mage => new Mage(name, config, _logger),
            _ => throw new ArgumentException("Неизвестный тип бойца")
        };
    }
}