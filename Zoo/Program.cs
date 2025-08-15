namespace Zoo;

internal class Program 
{
    static void Main(string[] args)
    {
        ILogger logger = new Logger();
        IAnimalFactory animalFactory = new AnimalFactory();
        IEnclosureFactory enclosureFactory = new EnclosureFactory();

        var enclosures = new List<IEnclosure>
        {
            enclosureFactory.CreateEnclosure("Львиный вольер", new[]
            {
                animalFactory.CreateAnimal("Лев Симба", "Самец", "Арр"),
                animalFactory.CreateAnimal("Львица Вика", "Самка", "Арр")
            }),
            enclosureFactory.CreateEnclosure("Вольер с попугаями", new[]
            {
                animalFactory.CreateAnimal("Попугай Кеша", "Самец", "Арр, моя клетка рядом со львами"),
                animalFactory.CreateAnimal("Попугай Лена", "Самка", "Чирик-чирик")
            }),
            enclosureFactory.CreateEnclosure("Вольер со слонами", new[]
            {
                animalFactory.CreateAnimal("Слон Миша", "Самец", "Туу"),
                animalFactory.CreateAnimal("Слон Зоя", "Самка", "Туу")
            }),
            enclosureFactory.CreateEnclosure("Вольер с обезьянами", new[]
            {
                animalFactory.CreateAnimal("Мартышка Карина", "Самка", "У у у"),
                animalFactory.CreateAnimal("Шимпанзе Максим", "Самец", "А а а")
            })
        };

        IZoo zoo = new Zoo(enclosures, logger);
        zoo.ShowMenu();
    }
}