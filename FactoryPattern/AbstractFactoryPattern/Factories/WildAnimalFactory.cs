namespace AbstractFactoryPattern;

public class WildAnimalFactory : IAnimalFactory
{
    public IDog CreateDog()
    {
        return new WildDog();
    }

    public ITiger CreateTiger()
    {
        return new WildTiger();
    }
}