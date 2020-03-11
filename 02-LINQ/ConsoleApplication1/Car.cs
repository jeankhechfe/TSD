using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSD.Linq.Cars
{
   
    public class Car
    {

        private string _make;
        public string make
        {
            get { return _make; }
            set { ; }
        }

        private int _sales2015;
        public int sales2015
        {
            get { return _sales2015; }
            set { _sales2015 = value; }
        }
        private int _sales2014;
        public int sales2014
        {
            get { return _sales2014; }
            set { _sales2014 = value; }
        }

        public int? NumberOfSeats { get; set; }

        public Car(string _make)
        {
            this._make = _make;

        }

        public static Car Init()
        {
            Car std = new Car("initial car")
            {
                _sales2015 = 30000,
                _sales2014 = 20000,
            };
            return std;
        }
    }

   
}
