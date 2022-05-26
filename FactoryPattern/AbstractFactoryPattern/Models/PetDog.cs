namespace AbstractFactoryPattern;

public class PetDog : IDog
{
    public void Speak()
    {
        Console.WriteLine($"Pet Dog Says: Bow-Wow");
    }

    public void Action()
    {
        Console.WriteLine($"Pet Dog Action: Play");
    }
}