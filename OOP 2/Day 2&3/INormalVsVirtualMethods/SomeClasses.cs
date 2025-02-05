namespace INormalVsVirtualMethods
{
    class BaseClass
    {
        public void M1() { Console.WriteLine("BaseClass.M1"); }
        public virtual void MV() { Console.WriteLine("BaseClass.MV"); }
    }

    class DerivedClass : BaseClass
    {
        public void M1() { Console.WriteLine("DerivedClass.M1"); }
        public void M2() { Console.WriteLine("DerivedClass.M2"); }
        public override void MV() { Console.WriteLine("DerivedClass.MV"); }
    }
}
