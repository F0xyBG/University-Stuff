

using System.Security.Cryptography.X509Certificates;


    // int[] ints =[0, 1, 2, 10, 4]; 
    // double average = Average(ints);
    // int closestToAvg = ClosestToAvg(ints, average);

    // int n = 100;
    // PrimeNumbers(n);
    // int[,] matrix = {{1, 2, 3,}, {4, 5, 6,}, {7, 8, 9}};
    // MatrixPrint(matrix);

    // Console.WriteLine($"");
    

    // var inverted = InvertMatrix(matrix);
    // MatrixPrint(inverted);


    // int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8};
    // Console.WriteLine($"Number is at index {FindInArray(array, 12)}");
    
    // int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8};

    // Console.WriteLine($"Element is at index {BinarySearch(array, 3)}");

    // int[] array = { 0, 1, 6, 4, 3, 5, 2, 8, 7};
    // Console.WriteLine($"{array.ToString}");
    // Console.WriteLine($" ");

    // BubbleSort(array);
    // Console.WriteLine($"{array.ToString}");

    // int[] array = { 0, 1, 6, 4, 3, 5, 2, 8, 7};
    // SelectionSort(array);
    // foreach (int i in array) {
    //     Console.WriteLine($"{i}");
    // }
    
    int[] array = { 0, 1, 6, 4, 3, 5, 2, 8, 7};
    InsertionSort(array);
    foreach (int i in array) {
        Console.WriteLine($"{i}");   
    }
    
    static void InsertionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
    }
    // static void BubbleSort(int[] arr)
    // {
    //     for (int i = 0; i < arr.Length-1; i++)
    //     {
    //         if(arr[i] > arr[i+1]) 
    //         {
    //             int temp = arr[i];
    //             arr[i] = arr[i+1];
    //             arr[i+1] = temp;
    //         }
    //     }
    // }

    // static void SelectionSort(int[] array) 
    // {
    //     for (int i = 0; i < array.Length; i++)
    //     {
    //         int previousSmallestEl = 0;
    //         for (int j = 0; j < array.Length; j++)
    //         {
    //             if(array[i] > previousSmallestEl){
    //                 array[i] = array.Min();
    //                 previousSmallestEl = array[i];
    //             }
    //         }
    //     }
    // }


    static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }

                int temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
        }


    static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

    static int BinarySearch(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;


            while (left <= right)
            {
                Console.WriteLine("Binary search iteration");

                int mid = (left + right) / 2;

                if (key == arr[mid])
                {
                    return mid;
                }
                else if (key < arr[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }

    static int FindInArray(int[] array, int element) 
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == element){
                return i;
            } 
        }
        return -1;
    }


    static void TransposeMatrix(int[,] matrix)
        {
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }
        }

    static void MatrixPrint(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int row = 0; row < rows; row++)
        {
            Console.WriteLine($"");
            
            for (int column = 0; column < columns; column++)
            {
                Console.Write(matrix[row, column] + " ");
            }
        }
    }

    static void PrimeNumbers(int n) 
    {
        bool[] numbers = new bool[n];
        for (var i = 0; i < numbers.Length; i++)
        {
            numbers[i] = true;
        }
        
        for (var i = 2; i < numbers.Length; i++)
        {
            for (var j = i+1; j < numbers.Length; j++)
            {
                if(j % i == 0){
                    numbers[j] = false;
                }
            }
        }

        Console.WriteLine($"Prime numbers: {numbers}");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]) { Console.WriteLine($"{i}");}
        }
    }


    double Average(int[] ints)
    {
        double total = 0; 
        for (int i = 0; i < ints.Length; i++)
        {
            total+=ints[i];
        }

        double avg = total / ints.Length;
        Console.WriteLine($"Average is {avg}");

        return avg;
    }
    void ClosestToAvg(int[] ints, double avg)
    {
        
        int indexCurrentMax = 0;
        double closestGuess = Math.Abs(ints[0] - avg);

        for (var i = 1; i < ints.Length; i++)
        {
            if(Math.Abs(ints[i] - avg) <= closestGuess){
                indexCurrentMax = i;
                closestGuess = Math.Abs(ints[i] - avg);
            }
        }

        Console.WriteLine($"The closest element is at index {indexCurrentMax} and has the value {ints[indexCurrentMax]}");

    }