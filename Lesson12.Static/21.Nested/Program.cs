MyClass.Nested instance = new MyClass.Nested();
instance.MethodFromNested();

Console.WriteLine(new string('-', 30));

MyClass.StaticMethod();

public static class MyClass
{
    static MyClass()
    {
        Console.WriteLine("MyClass-ın statik konstruktoru");
    }

    public static void StaticMethod()
    {
        Console.WriteLine("MyClass-ın statik metodu");
    }

    // Statik klaslar öz daxilində adi klaslar saxlaya bilər.
    public class Nested
    {
        public void MethodFromNested()
        {
            Console.WriteLine("Nested klasın metodu.");
        }
    }
}