using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class CarFareStrategy:IStrategyFare
    {
        public int CalculateFare(int fare)
        {
            return fare+10;
        }
    }
}
