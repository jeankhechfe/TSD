using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;
using TSD.Linq.Cars;

namespace TSD.Linq.Cars
{
    public class CarSalesBook
    {
        private IList<Car> _cars;

        public CarSalesBook()
        {
            _cars = GenerateCars();
        }

        private IList<Car> GenerateCars()
        {
            //task #5
            var cars = new List<Car>()
            {
                new Car("skoda") {  _sales2015 = 45529, _sales2014 = 44243 },
                new Car("Toyota") {  _sales2015 = 36465, _sales2014 = 31484 },
                new Car("BMW") {  _sales2015 = 9549, _sales2014 = 7714 },
            };

            IList<Car> sortedCars = cars.OrderBy(c => c._sales2015).ToList();

            return cars;
        }

        private IList<Car> ReadCarsFromFile()
        {
            return CarDataFileReader.ReadCarsFromCSVFile();
        }
    }
}
