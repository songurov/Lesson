using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Test_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Patrat patrat = new Patrat(200,100,"Patrat");
            patrat.Formula();
            Console.ReadLine();

            Triunghi triunghi = new Triunghi(150,20,"Triunghi");
            triunghi.Formula();
            Console.ReadLine();

            Cerc cerc = new Cerc(15,"Cerc");
            cerc.Formula();
            Console.ReadLine();
        }
    }

    class Figura
    {
        public int latime;
        public int lungime;
        public string nume;

        public Figura(int latime, int lungime, string nume)
        {
            this.latime = latime;
            this.lungime = lungime;
            this.nume = nume;
        }

        public virtual void Formula()
        {
            Console.WriteLine("Suma laturilor acestui {0} este {1}",nume,latime*lungime);
        }
    }

    class Patrat:Figura
    {
        public Patrat(int latime, int lungime , string nume):base(latime,lungime,nume){}
    }

    class Triunghi:Figura
    {
        public Triunghi(int latime, int lungime , string nume):base(latime,lungime,nume){}
        
        public override void Formula()
        {
            Console.WriteLine("Suma laturilor acestui {0} este {1}",nume,latime*lungime/2);
        }
    }

    class Cerc:Figura
    {
         private float pi = 3.141596f;
         public Cerc(int raza, string nume):this(raza,0,nume){}
         private Cerc(int lat, int lung, string nume):base(lat,lung,nume){}

        public override void Formula()
        {
            Console.WriteLine("Raza {1} este {0}",pi*latime*latime,nume);
        }
    }
}
