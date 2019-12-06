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
    public class Produto
    {
        private string connString = "";

        public Produto()
        {
           connString = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        }

        public DataTable Lista()
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from Produtos ";
                
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
