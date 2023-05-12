string text = "Test test";

// Statik metod kimi çağrılma.
ExtensionClass.ExtensionMethod(text);

// Extension metod kimi çağrılma.
text.ExtensionMethod();

// extension metodlar ancaq statik ola bilər və ancaq statik classın içində yaradılır
static class ExtensionClass
{
    // this - kompilyatora onu göstərir ki, bu metod extension metoddur!
    public static void ExtensionMethod(this string value)
    {
        Console.WriteLine(value);
    }
}