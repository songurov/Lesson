using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            
            Console.WriteLine("{0}  --  {1}",car.Zapasca.presshe,car.Zapasca.diametru);
            Console.ReadLine();
        
            car.PunkingWheels();
            //car.Zapasca.Punking(2202);
            Console.WriteLine("{0} === {1} === {2}",car.Zapasca.diametru,car.Zapasca.presshe,car.PresureInWheels);
            Console.ReadLine();
        }
    }

    class Zapasca
    {
        public byte diametru;
        public short presshe;

        public Zapasca()
        {
            diametru = 30;
            presshe = 2100;
        }
        public void Punking(short press)
        {
            this.presshe = press;
        }
    }

    class Car
    {
        private Zapasca zapasca = new Zapasca();
        
        private short presureInWheels;

        public void PunkingWheels()
        {
            PresureInWheels = 2000;
            zapasca.Punking(2100);
        }
        public Zapasca Zapasca
        {
            get { return zapasca; }
            set { zapasca = value; }
        }

        public short PresureInWheels
        {
            get { return presureInWheels; }
            set { presureInWheels = value; }
        }
    }
}
