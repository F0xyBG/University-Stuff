namespace CRefInOutParams
{
    internal class Program
    {
        static void M1(int x)
        {
            x = x * 2;
            Console.WriteLine($"M1: x = {x}");
        }

        static void MRef(ref int x)
        {
            x = x * 2;
            Console.WriteLine($"MRef: x = {x}");
        }

        static void MOut(out int x)
        {
            x = 100; //OUT params must be initialized.
            x = x * 2;
            Console.WriteLine($"MOut: x = {x}");
        }
        static void MIn(in int x)
        {
            //x = x * 2;  IN params are read-only!
            Console.WriteLine($"MInt: x = {x}");
        }

        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Standard call:");
            x = 10;
            Console.WriteLine($"Main: x = {x}");
            M1(x);
            Console.WriteLine($"Main: x = {x}");
            Console.WriteLine();

            Console.WriteLine("Reference call:");
            x = 10;
            Console.WriteLine($"Main: x = {x}");
            MRef(ref x);
            Console.WriteLine($"Main: x = {x}");
            Console.WriteLine();

            Console.WriteLine("Out parameter:");
            x = 10;
            Console.WriteLine($"Main: x = {x}");
            MOut(out x);
            Console.WriteLine($"Main: x = {x}");
            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
