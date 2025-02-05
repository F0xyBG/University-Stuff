namespace EInheritanceConstructors
{
    class A
    {
        public A()
        {
            Console.WriteLine("A is initialized.");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("B is initialized.");
        }
    }

    class C : A
    {
        public C()
        {
            Console.WriteLine("C is initialized.");
        }
    }

    //class D : B, C { } //C# doesn't allow for multiple inheritance.
}
