﻿namespace Homework;

class Program
{

    // // N. Задача 1
    // static void Main(string[] args)
    // {
    //     int N = GetArraySize();
    //     double[] array = new double[N];
    //     InputArrayElements(array);
    //     CalculateSum(array);
    // }

    // static int GetArraySize()
    // {
    //     int N;
    //     do
    //     {
    //         Console.Write("Input whole positive number N (N<20): ");
    //         N = int.Parse(Console.ReadLine());
    //     } while (N <= 0 || N >= 20);
    //     return N;
    // }

    // static void InputArrayElements(double[] array)
    // {
    //     for (int i = 0; i < array.Length; i++)
    //     {
    //         Console.Write($"Input element {i + 1}: ");
    //         array[i] = double.Parse(Console.ReadLine());
    //     }
    // }

    // static void CalculateSum(double[] array)
    // {
    //     int numberOfElements;
    //     do
    //     {
    //         Console.WriteLine($"Input number of elements to sum (max {array.Length}): ");
    //         numberOfElements = int.Parse(Console.ReadLine());
    //     } while (numberOfElements <= 0 || numberOfElements >= (array.Length + 1));

    //     double sum = 0;
    //     for (int i = 0; i < numberOfElements; i++)
    //     {
    //         sum += array[i];
    //     }
    //     Console.WriteLine($"The sum of the first {numberOfElements} elements is: {sum}");

    // }



    // N. Задача 2
    // static void Main(string[] args)
    // {
    //     int n = GetArraySize();
    //     int[] array = new int[n];
    //     InputRandomTwoDigitNumbers(array);
    //     FindMostFrequentNumber(array);
    // }

    // static int GetArraySize()
    // {
    //     int n;
    //     do
    //     {
    //         Console.Write("Input whole positive number n: ");
    //         n = int.Parse(Console.ReadLine());
    //     } while (n <= 0);
    //     return n;
    // }

    // static void InputRandomTwoDigitNumbers(int[] array)
    // {
    //     Random rand = new Random();
    //     for (int i = 0; i < array.Length; i++)
    //     {
    //         array[i] = rand.Next(10, 100); 
    //         Console.WriteLine($"Element {i + 1}: {array[i]}");
    //     }
    // }

    // static void FindMostFrequentNumber(int[] array)
    // {
    //     Dictionary<int, int> frequency = new Dictionary<int, int>();
    //     foreach (int num in array)
    //     {
    //         if (frequency.ContainsKey(num))
    //         {
    //             frequency[num]++;
    //         }
    //         else
    //         {
    //             frequency[num] = 1;
    //         }
    //     }

    //     int mostFrequentNumber = array[0];
    //     int maxCount = 0;
    //     foreach (var pair in frequency)
    //     {
    //         if (pair.Value > maxCount)
    //         {
    //             maxCount = pair.Value;
    //             mostFrequentNumber = pair.Key;
    //         }
    //     }

    //     Console.WriteLine($"The most frequent number is {mostFrequentNumber} and it appears {maxCount} times.");
    // }

    // N. Задача 3
    static void Main(string[] args)
    {
        int size = GetSquareSize();
        int[,] square = new int[size, size];
        InputSquareElements(square);
        bool isMagicSquare = CheckMagicSquare(square);
        Console.WriteLine(isMagicSquare ? "The table is a magic square." : "The table is not a magic square.");
    }

    static int GetSquareSize()
    {
        int size;

        Console.Write("Insert the size of the square table: ");
        size = int.Parse(Console.ReadLine());

        return size;
    }

    static void InputSquareElements(int[,] square)
    {
        int size = square.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                int element;
                do
                {
                    Console.Write($"Enter element [{i + 1}, {j + 1}] (between 1 and 20): ");
                    element = int.Parse(Console.ReadLine());
                } while (element < 1 || element > 20);
                square[i, j] = element;
            }
        }
    }

    static bool CheckMagicSquare(int[,] square)
    {
        int size = square.GetLength(0);
        int magicSum = 0;

        for (int j = 0; j < size; j++)
        {
            magicSum += square[0, j];
        }

        for (int i = 1; i < size; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < size; j++)
            {
                rowSum += square[i, j];
            }
            if (rowSum != magicSum)
            {
                return false;
            }
        }

        for (int j = 0; j < size; j++)
        {
            int colSum = 0;
            for (int i = 0; i < size; i++)
            {
                colSum += square[i, j];
            }
            if (colSum != magicSum)
            {
                return false;
            }
        }

        int mainDiagonalSum = 0;
        for (int i = 0; i < size; i++)
        {
            mainDiagonalSum += square[i, i];
        }
        if (mainDiagonalSum != magicSum)
        {
            return false;
        }

        int secondaryDiagonalSum = 0;
        for (int i = 0; i < size; i++)
        {
            secondaryDiagonalSum += square[i, size - i - 1];
        }
        if (secondaryDiagonalSum != magicSum)
        {
            return false;
        }

        return true;
    }
}
