namespace GladiatorArena;

public class Arena
{
    private List<Fighter> _fighters = new List<Fighter>()
    {
        new CritFighter("Гладиатор"),
        new DoubleHitFighter("Рыцарь"),
        new Berserker("Берсерк"),
        new Mage("Маг"),
        new Dodger("Аватар")
    };
    
    public void Start()
    {
        while (true)
        {
            PrintMenu();
            string input = Console.ReadLine();
            Console.Clear();
            switch (input)
            {
                case "1":
                    StartFight();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                    break;
            }
        }
    }

    private void PrintMenu()
    {
        Console.WriteLine("Добро пожаловать на арену Колизея!");
        Console.WriteLine("1. Посмотреть бой");
        Console.WriteLine("0. Выход");
        Console.Write("Ваш выбор: ");
    }

    private void StartFight()
    {
        Fighter fighter1 = ChooseFighter("Выберите первого бойца:");
        Fighter fighter2 = ChooseFighter("Выберите второго бойца:");

        Console.Clear();
        Console.WriteLine($"\n{fighter1.Name} VS {fighter2.Name}! Бой начинается!\n");
        Thread.Sleep(1000);

        while (fighter1.IsAlive && fighter2.IsAlive)
        {
            fighter1.AttackEnemy(fighter2);
            Thread.Sleep(500);

            if (!fighter2.IsAlive)
            {
                break;
            }

            fighter2.AttackEnemy(fighter1);
            Thread.Sleep(500);

            Console.WriteLine();
        }

        Console.WriteLine("\nБой завершен!");
        if (fighter1.IsAlive && !fighter2.IsAlive)
        {
            Console.WriteLine($"Победил {fighter1.Name}!");
        }
        else if (!fighter1.IsAlive && fighter2.IsAlive)
        {
            Console.WriteLine($"Победил {fighter2.Name}!");
        }
        else
        {
            Console.WriteLine("Ничья!");
        }

        Console.WriteLine("\nНажмите Enter для продолжения...");
        Console.ReadLine();
        Console.Clear();
    }

    private Fighter ChooseFighter(string message)
    {
        while (true)
        {
            Console.WriteLine(message);
            for (int i = 0; i < _fighters.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_fighters[i]}");
            }

            Console.Write("Введите номер бойца: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int index) && index >= 1 && index <= _fighters.Count)
            {
                return _fighters[index - 1].Clone();
            }
            Console.WriteLine("Некорректный ввод. Повторите попытку.\n");
        }
    }
}
