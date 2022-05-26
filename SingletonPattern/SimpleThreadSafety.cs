namespace Singleton_Pattern;

public sealed class SimpleThreadSafety
{
    private static SimpleThreadSafety instance = null;
    private static readonly object padlock = new Object();

    private SimpleThreadSafety()
    {
    }

    public static SimpleThreadSafety Instance
    {
        get
        {
            // this way is thread-safe, but lock every time addressing to this property
            // might be cpu expensive
            lock(padlock)
            {
                if (instance == null)
                {
                    instance = new SimpleThreadSafety();
                }

                return instance;
            }
        }
    }
}