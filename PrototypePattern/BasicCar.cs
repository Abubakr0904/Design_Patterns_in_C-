namespace PrototypePattern;

public abstract class BasicCar
{
    public string ModelName { get; set; }
    public int Price { get; set; }
    public static int SetPrice()
    {
        return new Random().Next(10000, 20000);
    }
    public abstract BasicCar Clone();
}