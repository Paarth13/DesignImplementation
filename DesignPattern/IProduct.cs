using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public interface IProduct
    {
       string Name { get; set; }
        string Type { get; set; }
        bool IsBooked { get; set; }

        int Fare { get; set; }
    }
}
