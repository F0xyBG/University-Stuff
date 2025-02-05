using System.ComponentModel;
using System.Diagnostics;

namespace CIntroGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            for (int i = 0; i < numbers.Count; i++)
            {
                int n = numbers[i];
            }

            //A bit of benchmarking, and pre-defined capacity.
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<int> data = new List<int>();
            for (int i = 0; i < 100_000_000; i++)
            {
                data.Add(i);
            }
            stopwatch.Stop();
            Console.WriteLine($"Adding 100 mln ints took {stopwatch.ElapsedMilliseconds} ms.");
            
            stopwatch.Restart();
            List<int> preData = new List<int>(100_000_000);
            for (int i = 0; i < 100_000_000; i++)
            {
                preData.Add(i);
            }
            stopwatch.Stop();
            Console.WriteLine($"Adding 100 mln ints, pre-allocated, took {stopwatch.ElapsedMilliseconds} ms.");


            Console.ReadLine();
        }
    }
}
