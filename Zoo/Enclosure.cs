namespace Zoo;

public class Enclosure : IEnclosure
{
    public string Name { get; }
    public IReadOnlyList<IAnimal> Animals { get; }

    public Enclosure(string name, IEnumerable<IAnimal> animals)
    {
        Name = name;
        Animals = animals.ToList();
    }
}