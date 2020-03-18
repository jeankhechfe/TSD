using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSD.Linq.Cars;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car initCar = Car.Init();
            CarSalesBook carSalesBook = new CarSalesBook();
            CarDataFileReader cdfr = new CarDataFileReader();
            var cars = cdfr.top3Sales();
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            Console.ReadLine();

        }
    }
}
