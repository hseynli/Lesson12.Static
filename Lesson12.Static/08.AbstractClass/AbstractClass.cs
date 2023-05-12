abstract class AbstractClass
{
    // Statik fabrik metod.
    public static AbstractClass CreateObject()
    {
        return new ConcreteClass();
    }

    protected AbstractClass()
    {
        Console.WriteLine("Abstract ctor!");
    }

    public abstract void Method();
}