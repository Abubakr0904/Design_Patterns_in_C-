namespace PrototypePattern;

public class Ford : BasicCar
{
    public Ford()
    {
        ModelName = "Ford";
    }

    public override BasicCar Clone()
    {
        return (Ford) this.MemberwiseClone(); // shallow copy
    }
}
