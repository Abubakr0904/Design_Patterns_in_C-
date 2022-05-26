namespace SingletonPattern;

// this is one of the best way if only there is only one static field
public sealed class ThreadSafeWithStaticConstructor
{
    private static readonly ThreadSafeWithStaticConstructor instance = 
        new ThreadSafeWithStaticConstructor();

    private ThreadSafeWithStaticConstructor()
    {
    }

    static ThreadSafeWithStaticConstructor()
    {
    }

    public static ThreadSafeWithStaticConstructor Instance
    {
        get => instance;
    }
}