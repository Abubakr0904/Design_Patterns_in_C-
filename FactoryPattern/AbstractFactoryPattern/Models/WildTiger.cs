namespace AbstractFactoryPattern;

public class WildTiger : ITiger
{
    public void Speak()
    {
        Console.WriteLine($"Wild Tiger Says: Halum");
    }

    public void Action()
    {
        Console.WriteLine($"Wild Tiger Action: Hunt");
    }
}