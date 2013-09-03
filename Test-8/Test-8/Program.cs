using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


class Program
{
     static void Main(string[] args)
     {
         Car car = new Car();
         car.AmountOfWheels = 4;
         car.Distantion(10);
         Console.WriteLine("Masina cu {1} rotii a mers {0} km",car.X,car.AmountOfWheels);
         Console.ReadLine();
         
         car.Stop();

         if (car.Run)
         {
             Console.WriteLine("Masina sa oprit !!!");
             Console.ReadLine();
         }
         else
         {
             Console.WriteLine("Ia inca merge!!!");
             Console.ReadLine();
         }
     }
}

class Car: Masina,ICar,IStop
{
    public int X { get; set; }
    public bool Run { get; set; }

    public void Distantion(int lenght)
    {
        X += lenght;
    }

    public bool Stop()
    {
       return Run = true;
    }
}
class Masina
{
    private int amountOfWheels;

    public int AmountOfWheels
    {
        get { return amountOfWheels; }
        set { amountOfWheels = value; }
    }
}

interface ICar
{
    int X
    {
        get;
        set;
    }

    bool Run
    {
        get;
        set;
    }

    void Distantion(int lenght);
}

interface IStop
{
    bool Stop();
}
