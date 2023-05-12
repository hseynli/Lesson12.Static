class NotStaticClass
{
    // static field.
    static int field;

    // static property.
    public static int Property
    {
        get { return field; }
        set { field = value; }
    }
}