MyClass.Nested.StaticMethodFromNested();

public class MyClass
{
    // Adi klaslar daxilində statik olan Nested klaslar saxlaya bilər.
    public static class Nested
    {
        public static void StaticMethodFromNested()
        {
            Console.WriteLine("Nested statik klasının statik metodu.");
        }
    }
}