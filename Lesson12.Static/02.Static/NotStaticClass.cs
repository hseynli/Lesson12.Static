class NotStaticClass
{
    private int id;

    // Konstruktor.
    public NotStaticClass(int id)
    {
        this.id = id;
    }

    public NotStaticClass()
    {

    }

    public static void Method()
    {
        //Console.WriteLine("Instance.Id = {0}", Id);

        Console.WriteLine("Static metodlarda static olmayan üzvlərə müracitə etmək mümkün deyil.");
    }
}