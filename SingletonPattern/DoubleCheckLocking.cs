namespace SingletonPattern;

public sealed class DoubleCheckLocking
{
    private static DoubleCheckLocking instance = null;
    private static readonly object padlock = new Object();

    private DoubleCheckLocking()
    {
    }

    public static DoubleCheckLocking Instance
    {
        // this way is thread-safe, but not the best way
        get
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DoubleCheckLocking();
                    }
                }
            }

            return instance;
        }
    }
}