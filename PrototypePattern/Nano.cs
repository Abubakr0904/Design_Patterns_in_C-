namespace PrototypePattern;

public class Nano : BasicCar
{
    public Nano()
    {
        ModelName = "Nano";
    }

    public override BasicCar Clone()
    {
        return (Nano) this.MemberwiseClone(); // shallow copy
    }
}