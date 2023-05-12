Console.OutputEncoding = System.Text.Encoding.UTF8;
MyClass instance1 = new MyClass();
instance1.MethodFromBase();

MyClass.Nested instance2 = new MyClass.Nested();
instance2.MethodFromNested();

public class MyClass : BaseClass
{
    public class Nested // Burada Nested klas BaseClass-dan törəmir.
    {
        public void MethodFromNested()
        {
            Console.WriteLine("Nested klasın metodu.");
        }
    }
}