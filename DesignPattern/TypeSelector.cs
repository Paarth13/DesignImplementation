using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DesignPattern
{
   public  class TypeSelector
    {
        public IProduct ObjectType(string input)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var product = assembly.GetTypes().FirstOrDefault(t => t.Name == input);
            Logger.Instance.WriteLog("Determing type of the class method");
            return (IProduct)Activator.CreateInstance(product);
        }
    }
}
