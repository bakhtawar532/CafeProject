using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace FinalProject
{
    class DataAccess
    {
        public int InsertDataIntoItemsCoffee(string number, string name, int price)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbConnectionString"))) 
            {
               int value = connection.Execute("insert into ItemsCoffee values('" + number + "','" + name + "'," + price + ")");
                return value;
            }
        }

        public List<ItemsCoffee> getAllItemsCoffee()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbConnectionString")))
            {
                var value = connection.Query<ItemsCoffee>("select * from ItemsCoffee").ToList();
                return value;
            }
        }
        public int getNextIdFordealCoffee()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbConnectionString")))
            {
                var value = connection.Query<DealCoffee>("select * from  dealCoffee where 'id' = (select distinct 'id' from dealCoffee)").ToList();
                return value.Count;
            }
        }
        public int InsertDataIntodealCoffee(int id, string item_name, int total_price)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbConnectionString")))
            {
                int value = connection.Execute("insert into dealCoffee values(" + id + ",'" + item_name + "'," + total_price + ")");
                return value;
            }
        }

        public List<DealCoffee> getAlldealCoffee()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbConnectionString")))
            {
                var value = connection.Query<DealCoffee>("select * from  dealCoffee").ToList();
                return value;
            }
        }
    }
}
