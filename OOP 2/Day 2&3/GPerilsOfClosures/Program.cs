using System.Threading.Channels;

namespace GPerilsOfClosures
{
    internal class Program
    {
        delegate void MyDelegate();

        static void DoSmth() { Console.WriteLine("Hi"); }

        static void Main(string[] args)
        {
            List<MyDelegate> myDelegates = new List<MyDelegate>();
            for (int i = 0; i < 10; i++)
            {
                int k = i;
                myDelegates.Add(() => { Console.WriteLine(k); });
            }

            foreach (var d in myDelegates) d();

            Console.ReadLine();
        }
    }
}
