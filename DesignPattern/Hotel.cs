using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DesignPattern
{
    class Hotel : IProduct
    {
        public string name="Hyatt";
        
        public bool book = false;
        public void Book()
        {
            book = true;
            Logger.Instance.WriteLog("In hotel booking ");
            FileDataBase obj = new FileDataBase();
            obj.WriteData(name, book);
            Console.WriteLine("In Hotel booking");
        }

        public void Save()
        {
            Logger.Instance.WriteLog("In Hotel save ");
            FileDataBase obj = new FileDataBase();
            obj.WriteData(name, book);
            Console.WriteLine("In Hotel save");
        }
    }
}
