using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class ProductServices
    {
        public void Book(IRepository dbSelector,IProduct product)
        {
            product.IsBooked = true;
            Console.WriteLine("In {0}",product.Type);
            string strategy = product.Type + "FareStrategy";
            TypeSelector fare = new TypeSelector();
            IStrategyFare strat = fare.FareValue(strategy);
            product.Fare=strat.CalculateFare(product.Fare);
            Console.WriteLine(product.Fare);
            Logger.Instance.WriteLog("In " +product.Type+" Booking ");
            dbSelector.WriteData(product);
        }


        public void Save(IRepository dbSelector, IProduct product)

        {

            string strategy = product.Type + "FareStrategy";
            TypeSelector fare = new TypeSelector();
            IStrategyFare strat = fare.FareValue(strategy);
            product.Fare = strat.CalculateFare(product.Fare);
            Logger.Instance.WriteLog("In " + product.Type + " Saving ");
            dbSelector.WriteData(product);
        }
    }
}
