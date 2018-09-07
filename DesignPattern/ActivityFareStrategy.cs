using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class ActivityFareStrategy:IStrategyFare
    {
        public int CalculateFare(int fare)
        {
            return fare + 40;
        }
    }
}
