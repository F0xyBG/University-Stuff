using System.Collections;

namespace AWhyGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int[] moreNumbers = new int[15];
            for (int i = 0; i < numbers.Length; i++)
            {
                moreNumbers[i] = numbers[i];
            }
            //

            ArrayList arrListNumbers = new ArrayList();
            arrListNumbers.Add(10);
            arrListNumbers.Add(15);
            arrListNumbers.Add(20);
            
            int sum = 0;
            for (int i = 0;i < arrListNumbers.Count;i++)
            {
                sum = sum + (int)arrListNumbers[i];
            }

            Console.WriteLine($"The sum of arrListNumbers is: {sum}");
            Console.ReadLine();
        }
    }
}
