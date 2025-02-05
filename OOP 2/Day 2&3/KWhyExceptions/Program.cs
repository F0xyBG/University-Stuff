namespace KWhyExceptions
{
    internal class Program
    {
        static void M1(long n)
        {
            Console.WriteLine("M1 starts.");
            M2(n);
            Console.WriteLine("M1 ends");
        }

        static void M2(long n)
        {
            Console.WriteLine("M2 starts.");
            SomeClass obj = new SomeClass();
            obj.DoSomething(n);
            Console.WriteLine("M2 ends");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                long n = long.Parse(input);
                try
                {
                    M1(n);
                    Console.WriteLine("M1 completed successfully.");
                    break;
                }
                catch (ArgumentNegativeException x)
                {
                    Console.WriteLine("Input value must be zero or positive.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Input is invalid. You may try again.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Catastrophic failure:");
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
