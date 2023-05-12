class NotStaticClass
{
    // readonly olan statik konstruktor konstruktorda hər-hansı dəyərə mənimsədilə bilər.
    static readonly long readonlyField = 2;

    // ancaq oxunma üçün yaradılmış statik property
    public static long ReadonlyField
    {
        get { return NotStaticClass.readonlyField; }
    }

    // Statik konstruktor.
    // statik konstruktorun access modifier-ı olmur və  heç bir arqument qəbul etmir.
    // statik konstruktor klas inisializasiya olunan zaman və ya hər-hansı statik üzvə müraciət zamanı avtomatik yaranır
    // statik konstruktoru birbaşa çağırmaq mümkün deyil
    // istifadəçi statik konstruktorun nə zaman çağrıldığını idarə edə bilmir
    static NotStaticClass()
    {
        Console.WriteLine("statik konstruktor");
        readonlyField = 1;
    }
}