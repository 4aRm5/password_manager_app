using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using  Npgsql;

namespace Курсач
{
    internal class DB
    {
        NpgsqlConnection conn;
        public void openConnection(string user, string passwd)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
         public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Open();
        }
        public NpgsqlConnection GetConnection(string user, string passwd) 
        {
            conn = new NpgsqlConnection($"Host = localhost; Username = {user}; Password = {passwd}; Database = passmanager");
            return conn; 
        }
    }
}
