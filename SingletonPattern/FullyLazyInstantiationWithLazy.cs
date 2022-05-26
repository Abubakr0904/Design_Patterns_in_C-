namespace SingletonPattern;

public sealed class FullyLazyInstantiation
{
    private static readonly Lazy<FullyLazyInstantiation> instance = 
        new Lazy<FullyLazyInstantiation>(() => new FullyLazyInstantiation());

    private FullyLazyInstantiation()
    {
    }

    public static FullyLazyInstantiation Instance
    {
        get => instance.Value;
    }
}