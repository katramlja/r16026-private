using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;

namespace Care
{
    public class SQLServer
    {
        private static SQLServer instance;
        private string connectionString;
        private SqlConnection connection;

        private SQLServer()
        {

            ConnectionString = "Server=31.147.204.119\\PISERVER,1433;Database=16026_DB;UID=16026_User;Password=eY4PSzGY";
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
           
        }
        ~SQLServer()
        {
        //  Connection.Close();
         Connection = null;
        }


        public static SQLServer Instance {
            get {
               if (instance == null)
                 {
                    instance = new SQLServer();
                }
                return instance;
            }
        }
        public string ConnectionString {
            get
            {
                return connectionString;
            }
            private set
            {
                    connectionString = value;
              
            }
        }
        public SqlConnection Connection {
            get
            {
                return connection;
            }
            private set
            {
                if (connection != value)
                {
                    connection = value;
                }
            }
        }
        public DbDataReader DohvatiDataReader(string sqlUpit) {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }
        public object DohvatiVrijednost(string sqlUpit) {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }
        public int IzvrsiUpit(string sqlUpit) {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }
    }
}
