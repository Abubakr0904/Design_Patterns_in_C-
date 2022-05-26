namespace AbstractFactoryPattern;

public class WildDog : IDog
{
    public void Speak()
    {
        Console.WriteLine($"Wild Dog Says: Bow-Wow");
    }
    public void Action()
    {
        Console.WriteLine($"Wild Dog Action: Run");
    }
}