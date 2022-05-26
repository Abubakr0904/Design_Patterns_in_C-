using PrototypePattern;

Console.WriteLine("Prototype Pattern!");

BasicCar nano = new Nano();
nano.Price = BasicCar.SetPrice();

BasicCar ford = new Ford();
ford.Price = BasicCar.SetPrice();

// these are the clones of the original objects (prototypes)
BasicCar bc1 = nano.Clone();
BasicCar bc2 = ford.Clone();
bc1.Price = BasicCar.SetPrice();
bc2.Price = BasicCar.SetPrice();

Console.WriteLine($"Car is: {bc1.ModelName}, and it's price is ${bc1.Price}");
Console.WriteLine($"Car is: {bc2.ModelName}, and it's price is ${bc2.Price}");