namespace AbstractFactoryPattern;

public class PetAnimalFactory : IAnimalFactory
{
    public IDog CreateDog()
    {
        return new PetDog();
    }

    public ITiger CreateTiger()
    {
        return new PetTiger();
    }
}