namespace SingletonPattern;
public sealed class FullyLazyInstantiationWithStaticConstructor
{
    private FullyLazyInstantiationWithStaticConstructor()
    {
    }

    public static FullyLazyInstantiationWithStaticConstructor Instance
    {
        get => Nested.instance;
    }

    private class Nested
    {
        static Nested()
        {
        }

        internal static readonly FullyLazyInstantiationWithStaticConstructor instance = 
            new FullyLazyInstantiationWithStaticConstructor();
    }
}