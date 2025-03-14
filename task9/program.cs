using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW M5", 2020, false);
            Car car2 = new Car("JEEP Grand Cherokee", 2004, true);
            Car car3 = new Car("KIA Forte", 2017, false);
            Car car4 = new Car("TOYOTA Camry", 2014, true);
            Car car5 = new Car("LEXUS RX", 2021, false);

            car1.RentCar();
            car1.RentCar();
            car2.ReturnCar();
            car2.RentCar();
            Console.Read();
        }
    }
}

