using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Car : IProduct
    {
        public string name = "Ferrari";


        public bool book;
        public void Book()
        {
            book = true;
            FileDataBase obj = new FileDataBase();
            obj.WriteData(name, book);
            Logger.Instance.WriteLog("In Car Booking");
            Console.WriteLine("In car booking");
        }

        public void Save()
        {
            Console.WriteLine("In car save");
            FileDataBase obj = new FileDataBase();
            Logger.Instance.WriteLog("In Car Saving");
            obj.WriteData(name, book);
        }
    }
}
