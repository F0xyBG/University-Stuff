namespace AIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float f1, f2;
            double d1, d2;

            f1 = 1234567890.0f;
            Console.WriteLine($"f1 = {f1:N}");
            f2 = 1234.56789f;
            Console.WriteLine($"f2 = {f2}");
            Console.WriteLine();

            d1 = 0.15 + 0.15;
            d2 = 0.1 + 0.2;
            Console.WriteLine($"d1 == d2: {d1 == d2}"); //NEVER, EVER do this.
            if (Math.Abs (d1 - d2) < 0.000001)
            {
                Console.WriteLine("d1 equals d2");
            }
            else
            {
                Console.WriteLine("d1 and d2 is not equal.");
            }

            decimal m1, m2;
            m1 = 0.15m + 0.15m;
            m2 = 0.1m + 0.2m;
            Console.WriteLine($"m1 == m2: {m1 == m2}");

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
