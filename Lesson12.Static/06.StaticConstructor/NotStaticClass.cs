class NotStaticClass
{
    private static int field;

    public static int Property
    {
        get { return field; }
        set { field = value; }
    }

    // Statik konstruktor. 
    // Statik konstruktorun əsas məqsədi statik dəyişənlərə ilkin dəyəri mənimsətməkdir.
    static NotStaticClass()
    {
        Console.WriteLine("Statik konstruktor");
        field = 1;
    }

    // Statik olmayan konstruktor
    public NotStaticClass()
    {
        Console.WriteLine("Not static constructor!");
    }

    // Statik metodlar overload ola bilərlər.
    public static void Method()
    {
        Console.WriteLine("Statik olmayan klasın statik metodu");
    }

    // Statik metodlar overload ola bilərlər.
    public static void Method(int s)
    {
        Console.WriteLine("Overload olunmuş statik metod " + s);
    }

    // Statik olmayan metod.
    public void NotStaticMethod()
    {
        Console.WriteLine(field);
    }
}