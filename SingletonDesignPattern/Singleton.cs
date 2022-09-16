public class Singleton
{
    private static int _instanceCount;

    public static int Count => _instanceCount;

    private Singleton()
    {
        WriteLine("Initializing db");
        // some logic
    }

    private static Lazy<Singleton> instance = new Lazy<Singleton>(() =>
    {
        _instanceCount++;
        return new Singleton();
    });

    public static Singleton Instance => instance.Value;

}
