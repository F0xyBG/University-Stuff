﻿namespace Homework_2;

class Program
{
    // //N. Задача 1
    // static void Main(string[] args)
    // {
    //     double[] numbersArray = InputNumbers();
    //     bool isMonotone = CheckIsMonotoneIncrease(numbersArray, 0);
    //     Console.WriteLine(isMonotone ? "The array is monotone increasing." : "The array is not monotone increasing.");
    // }

    // static double[] InputNumbers()
    // {
    //     double[] numbers = new double[9];
    //     for (int i = 0; i < 9; i++)
    //     {
    //         Console.WriteLine($"Enter the number at position {i + 1}: ");
    //         numbers[i] = Convert.ToDouble(Console.ReadLine());
    //     }
    //     return numbers;
    // }

    // static bool CheckIsMonotoneIncrease(double[] numbers, int index)
    // {
    //     if (index == numbers.Length - 1)
    //     {
    //         return true;
    //     }

    //     if (numbers[index] > numbers[index + 1])
    //     {
    //         return false;
    //     }

    //     return CheckIsMonotoneIncrease(numbers, index + 1);
    // }


    // //N. Задача 2
    // static void Main(string[] args)
    // {
    //     int n = GetN();
    //     EratostenPrimesModified(n);
    // }

    // static int GetN () 
    // {
    //     Console.WriteLine("Enter a number: ");
    //     int n = int.Parse(Console.ReadLine());
    //     return n;
    // }
    // static void EratostenPrimesModified(int userNumber)
    // {
    //     int n = 100010;
    //     bool[] primes = new bool[n + 1];

    //     for (int i = 0; i < primes.Length; i++)
    //     {
    //         primes[i] = true;
    //     }


    //     for (int i = 2; i < primes.Length; i++)
    //     {
    //         if (primes[i] == true)
    //         {
    //             for (int j = i + i; j < primes.Length; j += i)
    //             {
    //                 primes[j] = false;
    //             }
    //         }

    //     }

    //     for (int i = 2; i < primes.Length; i++)
    //     {
    //         if (primes[i] && i > userNumber)
    //         {
    //             Console.WriteLine($"The next prime number after {userNumber} is: {i}");
    //             break;
    //         }
    //     }

    // }

    static void Main(string[] args)
    {
        while (true)
        {
            int n = GetN();
            Console.WriteLine($"Sum of digits of {n} is: {SumOfDigits(n)}");
        }
        
        
    }

    static int GetN () 
    {
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        return n;
    }

    static int SumOfDigits(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        return n % 10 + SumOfDigits(n / 10);
    }
}
