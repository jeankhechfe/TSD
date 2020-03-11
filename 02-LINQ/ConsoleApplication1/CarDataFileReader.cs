using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TSD.Linq.Cars;

namespace ConsoleApplication1
{
    public class CarDataFileReader
    {
        public static IList<Car> ReadCarsFromCSVFile()
        {
            var cars = new List<Car>();
            TextReader textReader = new StreamReader(@"D:\Univ Poznan\1st semester\Technologies of Software Development\2nd Lecture\Cars_Stat.csv");
            textReader.ReadLine();
            string[] linesFromFile = textReader.ReadToEnd().Split('\n');
            foreach (var line in linesFromFile)
            {
                string[] fields = line.Split(';');
                Car newCar = new Car(fields[0]);
                newCar.sales2014 = int.Parse(fields[1]);
                newCar.sales2015 = int.Parse(fields[2]);
                cars.Add(newCar);
            }

            return cars;
        }

        public IEnumerable<string> top3Sales()
        {
            var cars = ReadCarsFromCSVFile();
            IEnumerable<string> top3 = from car in cars orderby car.sales2014 select car.make;
            return top3.Take(3);
        }

        public IEnumerable<string> increasedBy50PerCent()
        {
            var cars = ReadCarsFromCSVFile();
            IEnumerable<string> increased = from car in cars where car.sales2015 >= car.sales2014 select car.make;
            return increased;
        }

        public int totalSoldCars()
        {
            var cars = ReadCarsFromCSVFile();
            int total = 0;
            foreach (var car in cars)
            {
                total += car.sales2014 + car.sales2015;
            }
            return total;
        }

        public IEnumerable<string> topAndLast10To2015()
        {
            var cars = ReadCarsFromCSVFile();
            IEnumerable<string> ordered = from car in cars orderby car.sales2015 select car.make;
            return ordered.Take(10).Concat(ordered.Skip(Math.Max(0, ordered.Count() - 10)));
        }

        public void saveToXml()
        {
            var cars = ReadCarsFromCSVFile();
            XDocument xmlFile = new XDocument(
                new XComment("cars"),
                new XElement("cars", 
                    cars.Select(car => new XElement("make", car.make,
                                        new XElement("2014 Sales",car.sales2015),
                                        new XElement("2015 Sales", car.sales2015)
                                                    )
                                )
                            )
                );
            xmlFile.Declaration = new XDeclaration("1.0", "utf-8", "true");
            xmlFile.Save(@"D:\Univ Poznan\1st semester\Technologies of Software Development\2nd Lecture\Cars_Stat.xml");
        }

        public void readFromXml()
        {
            XElement xmlFile = XElement.Load(@"D:\Univ Poznan\1st semester\Technologies of Software Development\2nd Lecture\Cars_Stat.xml");
            var allCars = from cars in xmlFile.Elements("cars")
                          from car in cars.Elements("make")
                          select car;
            foreach(XElement car in allCars)
            {
                Console.Write(car.Value + ", 2014 Sales:" + car.Element("2014 Sales") + ", 2014 Sales:" + car.Element("2015 Sales") + "</br>");
            }
        }
    }
}
