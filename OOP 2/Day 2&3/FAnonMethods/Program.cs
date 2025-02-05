namespace FAnonMethods
{
    internal class Program
    {
        static int globalBoundary;

        static bool CheckGreaterThan50(int n)
        {
            return n > 50;
        }

        static bool CheckGreaterThanBoundary(int n)
        {
            return n > globalBoundary;
        }

        static void Main(string[] args)
        {
            #region Pre-ambule
            Console.Write("How many numbers to generate: ");
            string input = Console.ReadLine();
            int count = int.Parse (input);

            List<int> numbers = new List<int>();
            for (int i = 0; i < count; i++)
            {
                numbers.Add(Random.Shared.Next(100));
            }
            #endregion

            List<int> greaterThan50;
            #region Old school:
            //greaterThan50 = new List<int>();
            //for (int i = 0; i < count; i++)
            //{
            //    if (numbers[i] > 50)
            //    {
            //        greaterThan50.Add(numbers[i]);
            //    }
            //}
            #endregion

            greaterThan50 = numbers.FindAll(CheckGreaterThan50);

            Console.Write("Enter a boundary: ");
            input = Console.ReadLine();
            int boundary = int.Parse (input);

            globalBoundary = boundary;
            var greaterThanBoundary = 
                numbers.FindAll(CheckGreaterThanBoundary);

            greaterThanBoundary = numbers.FindAll(
                n => n > boundary
                );



            Console.WriteLine($"Bigger than 50: {greaterThan50.Count}");


            Console.ReadLine();
        }
    }
}
