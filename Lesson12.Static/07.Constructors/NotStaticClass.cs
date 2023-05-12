class NotStaticClass
{
    // instance-a aid konstruktor, ancaq klasın instance-ı yaranan zaman işə düşür.
    public NotStaticClass()
    {
        Console.WriteLine("Instance Constructor.");
    }

    // Statik konstruktor ixtiyari halda işə düşür: ya statik üzvə müraciət zamanı, ya da klasın instance-ı yaranan zaman.
    static NotStaticClass()
    {
        Console.WriteLine("Static Constructor.");
    }

    // Statik metod.
    public static void StaticMethod()
    {
        Console.WriteLine("StaticMethod");
    }

    public void NotStaticMethod()
    {
        Console.WriteLine("NotStaticMethod");
    }
}