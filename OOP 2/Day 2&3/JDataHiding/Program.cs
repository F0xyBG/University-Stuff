namespace JDataHiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonOldSchool p1 = new PersonOldSchool();
            p1.set_Name("Ivan");
            Console.WriteLine(p1.get_Name());

            PersonEnhanced p2 = new();
            p2.Name = "Ivan";  //Will invoke the "set" method
            Console.WriteLine(p2.Name); //Will invoke the "get" method

            Line l1 = new Line();
            l1.A.X = 10; l1.A.Y = 20;
            l1.B.X = 100; l1.B.Y = 120;
            Console.WriteLine(l1.Length);
            //l1.Length = 1000;  //Doesn't compile; Lenght is read-only.

            l1.A.Move(10);
        }
    }
}
