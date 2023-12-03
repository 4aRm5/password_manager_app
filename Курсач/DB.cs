using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Npgsql;

namespace Курсач
{
    internal class DB
    {
        NpgsqlConnection conn = new NpgsqlConnection("Host = localhost; Username = postgres;" +
                "Password = Slayanin2003; Database = passmanager");
        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }
         public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Open();
        }
        public NpgsqlConnection GetConnection() 
        { 
            return conn; 
        }
    }
}
