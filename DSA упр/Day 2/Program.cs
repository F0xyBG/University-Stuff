// int OGnumber = int.Parse(Console.ReadLine());
// Console.WriteLine($"Result: {Factorial(OGnumber)}");
// Console.WriteLine($"Result: {Fibbonaci(OGnumber)}");
    // int[] arr = { 12, 11, 13, 5, 6, 7 };
    // QuickSort(arr, 0, arr.Length - 1);

    // foreach (var item in arr)
    // {
    //     Console.WriteLine(item);
    // }    

// Console.WriteLine($"{DecToBinary(14)}");
using Day2;

    OurList list = new OurList();

    list.Add(1);
    list.PrintList();
    list.Add(2);
    list.PrintList();
    list.Add(3);
    list.PrintList();

    Console.WriteLine(list.IndexOf(2));
    Console.WriteLine(list.Contains(3));
    Console.WriteLine(list.IndexOf(4));

// Just exercises

static string Convert10ToBase(int baseNumber, int n)
    {
        string binary = "";

        while (n != 0)
        {
            int rem = n % baseNumber;

            if (rem >= 10)
            {
                binary += (char)('A' + (rem - 10));
            }
            else
            {
                binary += n % baseNumber;
            }

            n = n / baseNumber;
        }

        char[] arr = binary.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

// static string DecToAny(int n, int baseCountingSystem) {
//     string result = ""; 
//     while(n > 0) {
//         int remainder = n % baseCountingSystem;
//         if (baseCountingSystem > 10)
//         {
            
//         }
//         result = n % baseCountingSystem + result;
        
//         n = n / baseCountingSystem;
//     }
//     return result;
// }


static string DecToBinary(int n) {
    string result = "";
    while(n > 0) {
        result = n % 2 + result;
        n = n / 2;
    }
    return result;
}

// Sorting functions
static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);

                Merge(arr, left, middle, right);
            }

        }

        static void Merge(int[] arr, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];


            Array.Copy(arr, left, leftArray, 0, middle - left + 1);
            Array.Copy(arr, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;

            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
            }
        }

static void QuickSort(int[] arr, int start, int end)
        {
            int i;

            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }

        }

        static int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }


// static int[] QuickSort(int[] arr) {

//     if(arr.Length <= 1) {
//         return arr;
//     }

//     int n = arr.Length/2;
//     int[] left = new int[n];
//     int[] right = new int[n];

//     int leftCounter = 0;
//     int rightCounter = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         int currentEl = arr[arr.Length-1];
//         if(currentEl < arr[arr.Length-1]) {
//             left[leftCounter] = currentEl;
//         } else {
//             right[rightCounter] = currentEl;;
//         }
//     }

//     // left = QuickSort(left);
//     // right = QuickSort(right);

//     int[] result = new int[arr.Length];
//     left.CopyTo(result, 0);
//     right.CopyTo(result, left.Length);

//     return result;
// }

// Recursive functions

static int Fibbonaci(int n) {
    if(n==1 || n==2) {
        return 1;
    } else {
        return Fibbonaci(n-1) + Fibbonaci(n-2);
    }
}

static int Factorial(int n)
{
    if (n < 1)
    {
        throw new Exception("n should be greater than 0");
    }
    if (n == 1)
    {
        return 1;
    }

    int result = 0;
    result = n * Factorial(n - 1);
    return result;
}