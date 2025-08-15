namespace Zoo;

public class EnclosureFactory : IEnclosureFactory
{
    public IEnclosure CreateEnclosure(string name, IEnumerable<IAnimal> animals)
        => new Enclosure(name, animals);
}