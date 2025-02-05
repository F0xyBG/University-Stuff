namespace BValueVsRefTypes
{
    internal class Program
    {
        static void M1(int x)
        {
            x = x * 2;
            Console.WriteLine($"M1: x = {x}");
        }
        static void M2(int[] a)
        {
            a[0] = a[0] * 2;
            Console.WriteLine($"M2: a[0] = {a[0]}");
        }
        static void Main(string[] args)
        {
            #region Value
            int x;
            x = 10;
            int y;
            y = x;
            Console.WriteLine($"Main: x = {x}");
            M1(x);
            Console.WriteLine($"Main: x = {x}");
            Console.WriteLine();
            #endregion

            int[] a = [10, 20, 30];
            int[] b = a;
            Console.WriteLine($"Main: a[0] = {a[0]}");
            M2(a);
            Console.WriteLine($"Main: a[0] = {a[0]}");

            Console.ReadLine();
        }
    }
}
