namespace Zoo;

public class Zoo : IZoo
{
    private readonly List<IEnclosure> _enclosures;
    private readonly ILogger _logger;

    public Zoo(List<IEnclosure> enclosures, ILogger logger)
    {
        _enclosures = enclosures;
        _logger = logger;
    }

    public void ShowMenu()
    {
        while (true)
        {
            _logger.Log("\nДобро пожаловать в зоопарк! Выберите вольер:");
            
            for (int i = 0; i < _enclosures.Count; i++)
            {
                _logger.Log($"{i + 1}. {_enclosures[i].Name}");
            }
            _logger.Log("0. Выйти");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice == 0)
                {
                    break;
                }
                if (choice > 0 && choice <= _enclosures.Count)
                {
                    ShowEnclosure(_enclosures[choice - 1]);
                }
            }
        }
    }

    private void ShowEnclosure(IEnclosure enclosure)
    {
        _logger.Log($"\nВольер: {enclosure.Name}");
        _logger.Log($"Количество животных: {enclosure.Animals.Count}");
        
        foreach (var animal in enclosure.Animals)
        {
            _logger.Log($"- {animal.Name} ({animal.Gender}) издаёт звук: {animal.Sound}");
        }
    }
}