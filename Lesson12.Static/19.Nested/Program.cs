Console.OutputEncoding = System.Text.Encoding.UTF8;
MyClass.Nested instance = new MyClass.Nested();

instance.MethodFromBase();
instance.MethodFromNested();

public class MyClass // Burada MyClass BaseClass törəmir.
{
    public class Nested : BaseClass
    {
        public void MethodFromNested()
        {
            Console.WriteLine("Nested klasın metodu.");
        }
    }
}