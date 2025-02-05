namespace HStaticvsInstanceMembers
{
    internal class Program
    {
        static Program()
        {
            Console.WriteLine("This should fire first.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("App starting...");

            SomeClass obj1 = new SomeClass();
            SomeClass obj2 = new SomeClass();

            int[] numbers = new int[10000];

            obj1.Text = "ABC";
            obj2.Text = "XYZ";
            Console.WriteLine($"obj1.Text: {obj1.Text}");
            Console.WriteLine($"obj2.Text: {obj2.Text}");

            SomeClass.GlobalData = 20;

            Console.ReadLine();
        }
    }
}
