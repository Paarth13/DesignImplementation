using System;
using System.IO;
using System.Text;

namespace DesignPattern
{
    public class FileDataBase : IRepository
    {
        public void WriteData(string name, bool book)
        {
            Logger.Instance.WriteLog("Writing to file ");
            FileStream fs = new FileStream("C:\\Users\\pvashisht\\source\\repos\\DesignPattern\\save.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Name : " + name);
            if (book == true)
                sw.WriteLine("Booking : Done");
            else
                sw.WriteLine("Booking :Not done");
            sw.Flush();
            sw.Close();
            fs.Close();
        }


    }
}
