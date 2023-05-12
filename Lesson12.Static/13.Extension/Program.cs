string text = "Hello ";

text.ExtensionMethod("world!");


static class ExtensionClass
{
    // Extension metodun arqument həmişə birinci yerdə olmalıdır
    public static void ExtensionMethod(this string value1, string value2)
    {
        Console.WriteLine(value1 + value2);
    }
}