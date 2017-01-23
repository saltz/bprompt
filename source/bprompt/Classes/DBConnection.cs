using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace bprompt
{
    class DBConnection
    {
        MySqlConnection conn;
        MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder
        {
            Server = "thedin.nl",
            UserID = "bprompt",
            Password = "Bprompt1029384756",
            Database = "bprompt"
        };

        public DataSet GetData(string query)
        {
            using (conn = new MySqlConnection(sb.ToString()))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
            {
                DataSet outputData = new DataSet();
                adapter.Fill(outputData);
                return outputData;
            }
        }

        public void SetData(string query)
        {
            conn = new MySqlConnection(sb.ToString());
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
