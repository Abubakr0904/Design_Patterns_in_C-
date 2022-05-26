namespace AbstractFactoryPattern;

public class PetTiger : ITiger
{
    public void Speak()
    {
        Console.WriteLine($"Pet Tiger Says: Halum");
    }
    
    public void Action()
    {
        Console.WriteLine($"Pet Tiger Action: Play");
    }
}