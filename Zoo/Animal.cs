namespace Zoo;

public class Animal : IAnimal
{
    public string Name { get; }
    public string Gender { get; }
    public string Sound { get; }

    public Animal(string name, string gender, string sound)
    {
        Name = name;
        Gender = gender;
        Sound = sound;
    }
}