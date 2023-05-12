BaseClass.StaticMethod();
DerivedClass.StaticMethod();

abstract class BaseClass
{
    // statik üzv (metod) virtual ola bilməz
    //public static virtual void StaticMethod()
    //{
    //    Console.WriteLine("BaseClass.StaticMethod");
    //}

    public static void StaticMethod()
    {
        Console.WriteLine("BaseClass.StaticMethod");
    }
}

class DerivedClass : BaseClass
{
    //public static override void StaticMethod()
    //{
    //    Console.WriteLine("DerivedClass.StaticMethod");
    //}

    public static new void StaticMethod()
    {
        Console.WriteLine("DerivedClass.StaticMethod");
    }
}