using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWhyExceptions
{
    class ArgumentNegativeException : ArgumentOutOfRangeException
    {
        public ArgumentNegativeException(string message) : base(message) 
        {
            
        }
    }

    class SomeClass
    {
        public void DoSomething(long n)
        {
            if (n < 0) throw new ArgumentNegativeException("n must not be negative");
            if (n % 2 == 1) throw new ArgumentOutOfRangeException("n must be even");
            var d = new double[n];
        }
    }
}
