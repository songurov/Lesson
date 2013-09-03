using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_7
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class A
    {
        public virtual void M()
        {
            Console.WriteLine("Test-7");
            Console.ReadLine();
        }
    }

    sealed class B:A
    {
        public override void M()
        {
            
        }
    }
}
