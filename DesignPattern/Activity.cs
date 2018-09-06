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
        public void Book()
        {
            book = true;
            Logger.Instance.WriteLog("In activity Booking");
            FileDataBase obj = new FileDataBase();
            obj.WriteData(name, book);
            Console.WriteLine("In activity booking");
        }

        public void Save()
        {
            Logger.Instance.WriteLog("In activity save ");
            FileDataBase obj = new FileDataBase();
            obj.WriteData(name, book);
            Console.WriteLine("In activity save");
        }
    }
}
