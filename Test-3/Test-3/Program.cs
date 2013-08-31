using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            SportCar sc = new SportCar("Rosu",2000,"Ford Focus",true,6);

            Console.WriteLine("Culoarea masini este {0} are o greutate de {1} Kg, se numeste {2} are {3} trepte si {4}",sc.color,sc.height,sc.name,sc.transmision,sc.complet_drive);
            Console.ReadLine();
        }
    }

    class Car
    {
        public string color;
        public int height;
        public string name;

        public Car(string color , int height, string name)
        {
            this.color = color;
            this.height = height;
            this.name = name;
        }
    }

    class SportCar : Car
    {
        public bool complet_drive;
        public int transmision;

        public SportCar(string color,int height,string name,bool complet,int transmision):base(color,height,name)
        {
            this.complet_drive = complet;
            this.transmision = transmision;
        }
    }
}
