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
            A a = new A();
            B b = new B();
            C c = new C();

            Metoda(b);
            Metoda(c);
            a.Metoda();
            b.Metoda();
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

        public void Metoda()
        {
            Console.WriteLine("Class A");
            Console.ReadLine();
        }
    }

    class B:A
    {
        public new void Metoda()
        {
            Console.WriteLine("Class B");
            Console.ReadLine();
        }
    }

    class C:A
    {
         
    }
}
