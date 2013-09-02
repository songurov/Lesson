using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_6
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            C c = new C();

            Metoda(b);
            Metoda(c);
        }

        static void Metoda(A input)
        {
            Console.WriteLine("A fost initializat {0}",input.ToString());
            Console.ReadLine();
        }
    }

    class A
    {
        public int x;
    }

    class B:A
    {
         
    }

    class C:A
    {
         
    }
}
