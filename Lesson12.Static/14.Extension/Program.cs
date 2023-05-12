string text = "Hello ";

text.ExtensionMethod();

text.ExtensionMethod("world!");

"Hello ".ExtensionMethod("world!");
2.ExtensionMethod();

// Extension metodlarda optional parametrlər ola bilməz, amma onlar overload ola bilər.
static class ExtensionClass
{
    public static void ExtensionMethod(this string value)
    {
        Console.WriteLine(value);
    }

    public static void ExtensionMethod(this string value1, string value2)
    {
        Console.WriteLine(value1 + value2);
    }

    public static void ExtensionMethod(this int value)
    {
        Console.WriteLine(value);
    }
}