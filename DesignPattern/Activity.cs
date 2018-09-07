using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Activity:IProduct
    {
        public string name="SkyDive";
       
        public bool book = false;

        public int fare = 40;
        public string type = "Activity";

        public string Type { get { return type; } set { type = value; } }

        public string Name { get { return name; } set { name = value; } }

        public bool IsBooked { get { return book; } set { book = value; } }


        public int Fare { get { return fare; } set { fare = value; } }


       
    }
}
