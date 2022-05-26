using SimpleFactoryPattern;

Console.WriteLine("Simple Factory Pattern");

// Type of animal to create will be determined by the user in the factory.
IAnimal preferredType = null;
ISimpleFactory simpleFactory = new SimpleFactory();
preferredType = simpleFactory.CreateAnimal();

preferredType.Speak();
preferredType.Action();