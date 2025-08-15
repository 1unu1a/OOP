namespace Zoo;

public interface IEnclosure
{
    string Name { get; }
    IReadOnlyList<IAnimal> Animals { get; }
}