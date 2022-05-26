namespace AbstractFactoryPattern;

public interface IAnimalFactory
{
    IDog CreateDog();
    ITiger CreateTiger();
}