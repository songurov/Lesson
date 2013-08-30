using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Commodity cmd = new Commodity();
            cmd.name = "Jacobs";
            
            cmd.Cost = 12.3f;
            Console.WriteLine("Suma in parte pentru un cofe: "+cmd.Cost);
            Console.WriteLine("Suma cafe '"+cmd.name+"' este: " + cmd.GetCost());
            Console.ReadKey();
        }
    }
    class Commodity
    {
        public string name;
        private float cost;
        public float procente = 34.5f;

        public float Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public float GetCost()
        {
            return (Cost*2)*procente/100;
        }
    }
}
