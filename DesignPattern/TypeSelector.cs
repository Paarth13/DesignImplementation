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

        public IRepository DatabaseType(string input)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var product = assembly.GetTypes().FirstOrDefault(t => t.Name == input);
            Logger.Instance.WriteLog("Determing type of the database class method");
            return (IRepository)Activator.CreateInstance(product);
        }

        public IStrategyFare FareValue(string input)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var product = assembly.GetTypes().FirstOrDefault(t => t.Name == input);
            Logger.Instance.WriteLog("Determining Fare");
            return (IStrategyFare)Activator.CreateInstance(product);
        }
    }
}
