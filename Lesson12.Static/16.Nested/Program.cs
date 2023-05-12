Console.OutputEncoding = System.Text.Encoding.UTF8;
MyClass.Nested instance = new MyClass.Nested();

instance.Method();

class MyClass
{
    public class Nested
    {
        public void Method()
        {
            Console.WriteLine("Nested klasdan olan metod");
        }
    }
}