using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodtruckApp.DAL
{
    public class BaseDAL
    {
        public SqlConnection Connection { get; set; }
        public SqlCommand Sql { get; set; }
        public SqlDataReader Reader { get; set; }
        public ConnectionStringSettings Cs { get; set; }
        public BaseDAL(string query)
        {
            Connection = new SqlConnection();
            Sql = Connection.CreateCommand();
            Sql.CommandText = query;
            Cs = ConfigurationManager.ConnectionStrings["CsFoodTruck"];
            Connection.ConnectionString = Cs.ConnectionString;
            Connection.Open();
        }
    }
    
}
