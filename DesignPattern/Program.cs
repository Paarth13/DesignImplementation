using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Instance.WriteLog("In Main ");
            Console.WriteLine("Type any of the following to select \nCar\nAir\nHotel\nActivity\n ");
            string input=Console.ReadLine();
            Logger.Instance.WriteLog("Reading Input ");
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            input = textInfo.ToTitleCase(input);
            TypeSelector type = new TypeSelector();
            IProduct product = type.ObjectType(input);
            product.Book();
            product.Save();
            Console.ReadKey();
        }
    }
}
