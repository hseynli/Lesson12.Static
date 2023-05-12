MyClass.Nested instance = new MyClass.Nested();

instance.Method(1);

class MyClass
{
    private static int field = 0;

    public class Nested
    {
        public void Method(int a)
        {
            // statik üzvə müraciət edə bilərik
            field = a;

            Console.WriteLine(field);
        }
    }
}