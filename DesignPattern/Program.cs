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
            ProductServices pServices = new ProductServices();
            Console.WriteLine("Type any of the following to select \nCar\nAir\nHotel\nActivity\n ");
            string input=Console.ReadLine();
            Logger.Instance.WriteLog("Reading Input ");
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            input = textInfo.ToTitleCase(input);
            TypeSelector type = new TypeSelector();
            IProduct product = type.ObjectType(input);

            
            TypeSelector dbsSelector = new TypeSelector();
            Console.WriteLine("Type any of the following to select \nSql\nFile ");
            input = Console.ReadLine();
            input = textInfo.ToTitleCase(input);
            input += "DataBase";
            Logger.Instance.WriteLog("Selected a Database ");
            IRepository selector = dbsSelector.DatabaseType(input);
            Console.WriteLine("Press 1 To book \nPress 2 to Save");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    pServices.Book(selector, product);
                    break;
                case "2":
                    pServices.Save(selector, product);
                    break;
                default:
                    Console.WriteLine("Invalid Value");
                    break;

            }
            
            
            Console.ReadKey();
        }
    }
}
