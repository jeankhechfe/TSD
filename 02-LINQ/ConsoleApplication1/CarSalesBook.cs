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
            var cars = new List<Car>()
            {
                new Car("skoda") {  sales2015 = 45529, sales2014 = 44243 },
                new Car("Toyota") {  sales2015 = 36465, sales2014 = 31484 },
                new Car("BMW") {  sales2015 = 9549, sales2014 = 7714 },
            };

            IList<Car> sortedCars = cars.OrderBy(c => c.sales2015).ToList();

            return cars;
        }

        private IList<Car> ReadCarsFromFile()
        {
            return CarDataFileReader.ReadCarsFromCSVFile();
        }
    }
}
