namespace INormalVsVirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj1 = new BaseClass();
            DerivedClass obj2 = new DerivedClass();
            BaseClass obj3 = new DerivedClass();

            Console.WriteLine("Normal methods.");
            obj1.M1();
            obj2.M1();
            obj2.M2();
            obj3.M1();
            Console.WriteLine();

            Console.WriteLine("Virtual methods");
            obj1.MV();
            obj2.MV();
            obj3.MV();

            Console.WriteLine();
            Console.WriteLine("Virtual methods illustrated");
            BaseClassV objBase = new BaseClassV();
            BaseClassV objBase2 = new DerivedClassV();
            objBase.Invoke("MV");
            objBase2.Invoke("MV");


            Console.ReadLine();
        }
    }
}
