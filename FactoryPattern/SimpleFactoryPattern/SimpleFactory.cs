namespace SimpleFactoryPattern;

public class SimpleFactory : ISimpleFactory
{
    public IAnimal CreateAnimal()
    {
        int animalType;
        if (int.TryParse(Console.ReadLine(), out animalType))
        {
            switch (animalType)
            {
                case 1:
                    return new Tiger();
                case 2:
                    return new Dog();
                default:
                    return null;
            }
        }
        else
        {
            return null;
        }
    }
}