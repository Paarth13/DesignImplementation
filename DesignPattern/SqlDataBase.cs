using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DesignPattern
{
    class SqlDataBase:IRepository
    {
        public void WriteData(IProduct product)
        {
            SqlConnection connectionObject = new SqlConnection();
            try
            {
                Logger.Instance.WriteLog("In sql database ");
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";
                builder.UserID = "sa";
                builder.Password = "test123!@#";
                builder.InitialCatalog = "ProductsDatabase";
                using (connectionObject = new SqlConnection(builder.ConnectionString))
                {
                    connectionObject.Open();
                    String command = "insert into " + product.Type + "(Name,Booked,Fare) values('" + product.Name + "','" + product.IsBooked + "','" + product.Fare + "')";
                    SqlCommand cmd = new SqlCommand(command, connectionObject);
                    cmd.ExecuteNonQuery();
                    connectionObject.Close();
                }
            }
            catch (Exception e)
            {
                Logger.Instance.WriteLog("Entry to Catch Block ");
                
                Console.WriteLine(e.Message);
                Logger.Instance.WriteLog("Exiting Catch Block");
            }
        }
    }
}
