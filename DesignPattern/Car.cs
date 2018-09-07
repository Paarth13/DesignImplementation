using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Car : IProduct
    {
        public string name = "MERCEDES";


        public bool book { get; set; }
        public int fare = 10;

        public string type = "Car";

        public string Type { get { return type; } set { type = value; } }
        public string Name { get { return name; } set { name = value; } }

        public bool IsBooked { get { return book; } set { book = value; } }


        public int Fare { get { return fare; } set { fare = value; } }
    }
}
