//Qaydalar:
// 1. Statik klasın instance-nı yaratmaq mümkün deyil
// 2. Statik klas həmişə Object klasından törəyir (digər heç bir klasdan törəyə bilməz)
// 3. Statik klas heç bir interfeysi realizasiya edə bilməz
// 4. Statik klas daxilində ancaq statik üzvlər saxlaya bilər
// 5. Statik klas özündə instance konstruktoru saxlaya bilməz
// 6. Heç bir digər klas statik klasdan törəyə bilməz

static class StaticClass //: object  // Ancaq Object klasından törəyə bilər (birbaşa yazılmaya da bilər)
{
    // instance konstruktoru - yolverilməzdir.
    // public StaticClass()
    // {
    //    Console.WriteLine("Constructor.");
    // }

    // Statik konstruktor.
    static StaticClass()
    {
        Console.WriteLine("Static Constructor");
    }

    // Statik metod.
    public static void StaticMethod()
    {
        Console.WriteLine("StaticMethod");
    }

    // Statik olmayan metod - yolverilməzdir.
    // public void NotStaticMethod()
    // {
    //    Console.WriteLine("NotStaticMethod");
    // }
}