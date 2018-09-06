using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Air:IProduct
    {
        public string name="Boeing";

        public bool book=false;
        public void Book()
        {
            book = true;
            Logger.Instance.WriteLog("In air Booking");
            FileDataBase obj = new FileDataBase();
            obj.WriteData(name, book);
            Console.WriteLine("In air booking");
        }

        public void Save()
        {
            Logger.Instance.WriteLog("In air Saving");
            FileDataBase obj = new FileDataBase();
            obj.WriteData(name, book);
            Console.WriteLine("In air save");
        }
    }
}
