using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Administrador
    {
        private string connString = "";

        public Administrador()
        {
           connString = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        }

        public DataTable Login(string login, string senha)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from administradores where login = '" + login + "' and senha = '" + senha + "'";
                
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                using (SqlDataAdapter a = new SqlDataAdapter(cmd))
                {
                    a.Fill(table);
                }
            }
            return table;
        }
    }
}
