namespace EGenericStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeStack<string> names = new SeStack<string>();
            names.Push("Ivan");
            names.Push("Dragan");
            names.Push("Parvan");

            Console.WriteLine(names.ToString());
            List<double> nums = new List<double>();
        }
    }
}
