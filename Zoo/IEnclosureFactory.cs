namespace Zoo;

public interface IEnclosureFactory
{
    IEnclosure CreateEnclosure(string name, IEnumerable<IAnimal> animals);
}