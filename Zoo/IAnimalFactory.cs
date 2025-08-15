namespace Zoo;

public interface IAnimalFactory
{
    IAnimal CreateAnimal(string name, string gender, string sound);
}