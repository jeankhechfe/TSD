using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSD.Linq.Cars
{
   
    public class Car
    {
        //task #2
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


        //task #6
        public int? NumberOfSeats { get; set; }


        //task #3
        public Car(string _make)
        {
            this._make = _make;

        }

        public static Car Init()
        {
            //task #4
            Car std = new Car("initial car")
            {
                _sales2015 = 30000,
                _sales2014 = 20000,
            };
            return std;
        }
    }

   
}
