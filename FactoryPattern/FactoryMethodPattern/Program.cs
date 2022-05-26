using FactoryMethodPattern;

Console.WriteLine("Factory Pattern\n");
 
 // Creating a Tiger Factory
 IAnimalFactory tigerFactory =new TigerFactory();
 
 // Creating a tiger using the Factory Method
 IAnimal aTiger = tigerFactory.CreateAnimal();
 aTiger.Speak();
 aTiger.Action();
 
 // Creating a DogFactory
 IAnimalFactory dogFactory = new DogFactory();
 
 // Creating a dog using the Factory Method
 IAnimal aDog = dogFactory.CreateAnimal();
 aDog.Speak();
 aDog.Action();
