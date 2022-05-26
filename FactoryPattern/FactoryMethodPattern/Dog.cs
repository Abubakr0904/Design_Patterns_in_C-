namespace FactoryMethodPattern;

public class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Dog says: Bow-bow!");
    }

    public void Action()
    {
        Console.WriteLine("Dog barks.");
    }
}