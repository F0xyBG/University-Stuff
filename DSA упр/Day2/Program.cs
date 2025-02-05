// int OGnumber = int.Parse(Console.ReadLine());
// Console.WriteLine($"Result: {Factorial(OGnumber)}");
// Console.WriteLine($"Result: {Fibbonaci(OGnumber)}");
    int[] arr = { 12, 11, 13, 5, 6, 7 };
    QuickSort(arr, 0, arr.Length - 1);

    foreach (var item in arr)
    {
        Console.WriteLine(item);
    }    

// Sorting functions

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