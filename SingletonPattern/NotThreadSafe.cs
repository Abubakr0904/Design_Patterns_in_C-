namespace Singleton_Pattern;

public sealed class NotThreadSafe
{
    private static NotThreadSafe instance = null;

    private NotThreadSafe()
    {
    }

    public static NotThreadSafe Instance
    {
        get 
        { 
            // in real life, this would not be a thread-safe implementation
            // as instance can be null concurrently in multiple threads
            if(instance == null)
            {
                instance = new NotThreadSafe();
            }

            return instance;
        }
    }
}