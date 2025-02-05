using System.IO;

namespace LFinally
{
    internal class Program
    {
        static void M1()
        {
            //var stream = File.Open(@"d:\temp\somefile.txt", FileMode.OpenOrCreate);
            //try
            //{
            //    var writer = new StreamWriter(stream);
            //    writer.WriteLine("The quick brown fox jumped over...");
            //}
            //finally
            //{
            //    stream.Close();
            //}

            //Alernative syntax:
            //using (var stream = File.Open(@"d:\temp\somefile.txt", FileMode.OpenOrCreate))
            //{
            //    var writer = new StreamWriter(stream);
            //    writer.WriteLine("The quick brown fox jumped over...");
            //}

            //Another alternative;
            FileStream s2;
            using (s2 = File.Open(@"d:\temp\somefile.txt", FileMode.OpenOrCreate)) ;
            var writer2 = new StreamWriter(s2);
            writer2.WriteLine("The quick brown fox jumped over...");
        }

        static void Main(string[] args)
        {
            M1();
            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
