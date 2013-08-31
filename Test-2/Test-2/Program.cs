using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Frist frist = new Frist();
            Second second = new Second();
            MyClass myClass = new MyClass();

            
            Console.WriteLine("Frist = {0}, Second = {1} , MyClass = {2} ,{3} - {4} - {5} -- {6}", 
                                frist.Fs,second.Fs,myClass.Fs,frist.ShowMessage(),second.ShowMessage(),frist.Ff,second.Modific());
            Console.ReadKey();

        }
    }

    class Frist
    {
        public int Fs = 23;
        private string ff;

        public string Ff
        {
            get { return ff; }
            set { ff = value; }
        }

        public string ShowMessage()
        {
            return Ff = "Plombir";
        }
    }

    class Second: Frist
    {
        public int Ss;

        public string Modific()
        {
            return Ff = "Ion";
        }
    }

    class MyClass:Second
    {
        public int Mc;
    }
}
