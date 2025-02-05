namespace HStaticvsInstanceMembers;
internal class SomeClass
{
    public string Text { get; set; }

    public static int GlobalData { get; set; }

    public SomeClass()
    {
        Console.WriteLine("SomeClass instance ctor called.");
    }

    static SomeClass()
    {
        Console.WriteLine("SomeClass static ctor called.");
        GlobalData = 10;
    }
}
