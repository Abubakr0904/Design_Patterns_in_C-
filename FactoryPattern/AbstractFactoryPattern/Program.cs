using AbstractFactoryPattern;

Console.WriteLine("***Abstract Factory Pattern\n");

//Making a wild dog through WildAnimalFactory
IAnimalFactory wildAnimalFactory = new WildAnimalFactory();
IDog wildDog = wildAnimalFactory.CreateDog();
wildDog.Speak();
wildDog.Action();

//Making a wild tiger through WildAnimalFactory
ITiger wildTiger = wildAnimalFactory.CreateTiger();
wildTiger.Speak();
wildTiger.Action();
Console.WriteLine("******************");

//Making a pet dog through PetAnimalFactory
IAnimalFactory petAnimalFactory = new PetAnimalFactory();
IDog petDog = petAnimalFactory.CreateDog();
petDog.Speak();
petDog.Action();

//Making a pet tiger through PetAnimalFactory
ITiger petTiger = petAnimalFactory.CreateTiger();
petTiger.Speak();
petTiger.Action();
Console.ReadLine();