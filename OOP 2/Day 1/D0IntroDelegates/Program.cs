namespace D0IntroDelegates
{
    internal class Program
    {
        delegate void MyFirstDelegate();

        static void DoSomething()
        {
            Console.WriteLine("Hi there!");
        }

        static void PrintUpper(string s)
        { Console.WriteLine(s.ToUpper()); }

        static void Main(string[] args)
        {
            MyFirstDelegate d1;
            d1 = DoSomething;
            //d1 = PrintUpper; //Doesn't compile: PrintUpper's params don't match these of the delegate.

            //...
            d1();



        }
    }
}
