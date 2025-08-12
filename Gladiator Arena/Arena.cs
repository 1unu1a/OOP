namespace GladiatorArena;

public class Arena
{
    private readonly IFighterFactory _factory;
    private readonly IBattleLogger _logger;
    private readonly List<FighterType> _fighterTypes;

    public Arena(IFighterFactory factory, IBattleLogger logger)
    {
        _factory = factory;
        _logger = logger;
        _fighterTypes = Enum.GetValues(typeof(FighterType)).Cast<FighterType>().ToList();
    }
    
    public void Start()
    {
        while (true)
        {
            PrintMenu();
            var input = Console.ReadLine();
            Console.Clear();
            if (input == "1")
            {
                StartFight();
            }
            else if (input == "0")
            {
                return;
            }
            else
            {
                _logger.Log("Неверный ввод. Попробуйте снова.");
            }
        }
    }

    private void PrintMenu()
    {
        _logger.Log("Добро пожаловать на арену Колизея!");
        _logger.Log("1. Посмотреть бой");
        _logger.Log("0. Выход");
        _logger.Log("Ваш выбор: ");
    }

    private void StartFight()
    {
        var fighter1 = ChooseFighter("Выберите первого бойца:");
        var fighter2 = ChooseFighter("Выберите второго бойца:");
        PrintBattleStart(fighter1, fighter2);
        SimulateFight(fighter1, fighter2);
        PrintBattleResult(GetBattleResult(fighter1, fighter2));
    }

    private Fighter ChooseFighter(string message)
    {
        while (true)
        {
            _logger.Log(message);
            for (int i = 0; i < _fighterTypes.Count; i++)
            {
                _logger.Log($"{i + 1}. {_fighterTypes[i]}");
            }
            var input = Console.ReadLine();
            if (int.TryParse(input, out int index) && index >= 1 && index <= _fighterTypes.Count)
            {
                return _factory.CreateFighter(_fighterTypes[index - 1], _fighterTypes[index - 1].ToString());
            }
            _logger.Log("Некорректный ввод. Повторите попытку.\n");
        }
    }

    private void PrintBattleStart(Fighter f1, Fighter f2)
    {
        Console.Clear();
        _logger.Log($"\n{f1.Name} VS {f2.Name}! Бой начинается.\n");
        Thread.Sleep(1000);
    }

    private void SimulateFight(Fighter f1, Fighter f2)
    {
        while (f1.IsAlive && f2.IsAlive)
        {
            f1.AttackEnemy(f2);
            Thread.Sleep(500);
            if (!f2.IsAlive)
            {
                break;
            }
            f2.AttackEnemy(f1);
            Thread.Sleep(500);
            _logger.Log("");
        }
    }

    private string GetBattleResult(Fighter f1, Fighter f2)
    {
        if (f1.IsAlive && !f2.IsAlive)
        {
            return $"Победил {f1.Name}!";
        }

        if (!f1.IsAlive && f2.IsAlive)
        {
            return $"Победил {f2.Name}!";
        }
        return "Ничья.";
    }

    private void PrintBattleResult(string result)
    {
        _logger.Log("\nБой завершен.");
        _logger.Log(result);
        _logger.Log("\nНажмите Enter для продолжения...");
        Console.ReadLine();
        Console.Clear();
    }
}
