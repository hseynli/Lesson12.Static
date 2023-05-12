class Singleton
{
    private static Singleton instance = null;

    // Konstruktor - "protected" 
    protected Singleton()
    {
    }

    // Fabrik metod.
    public static Singleton Instance()
    {
        // Əgər: obyekt hələ yaranmayıbsa    (1)         
        if (instance == null)
        {
            // Onda: yeni instance yaradırıq  (2)
            instance = new Singleton();
        }
        // Əks halda: cari obyektə olan referance göndəririk  (3)
        return instance;
    }
}