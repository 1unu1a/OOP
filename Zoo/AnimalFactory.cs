namespace Zoo;

public class AnimalFactory : IAnimalFactory
{
    public IAnimal CreateAnimal(string name, string gender, string sound)
        => new Animal(name, gender, sound);
}