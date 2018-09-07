using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Logger
    {
        public static Logger _object;

        public static Logger Instance
        {
            get
            {
                if (_object == null)
                    _object = new Logger();

                return _object;
            }
        }

        public Logger()
        {
            _fileStreamer = File.OpenWrite("C:\\LogFile.txt");
            _streamWriter = new StreamWriter(_fileStreamer);
        }

        FileStream _fileStreamer;
        StreamWriter _streamWriter;

        public void WriteLog(string messages)
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine("Message: " + messages);

            _streamWriter.WriteLine(message.ToString());
            _streamWriter.Flush();
        }


    }
}