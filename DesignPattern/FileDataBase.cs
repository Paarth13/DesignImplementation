using System;
using System.IO;
using System.Text;

namespace DesignPattern
{
    public class FileDataBase : IRepository
    {
        public void WriteData(IProduct product)
        {
            Logger.Instance.WriteLog("Writing to file ");
            FileStream fs = new FileStream("C:\\Save.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Name : " + product.Name);
            if (product.IsBooked == true)
                sw.WriteLine("Booking : Done");
            else
                sw.WriteLine("Booking :Not done");
            sw.WriteLine("Fare : "+product.Fare);
            sw.Flush();
            sw.Close();
            fs.Close();
        }


    }
}
