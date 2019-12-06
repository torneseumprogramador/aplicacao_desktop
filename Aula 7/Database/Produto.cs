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

        public void Salvar(string nome, string descricao, decimal preco)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "insert into produtos (nome, descricao, preco) values(@nome, @descricao, @preco)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = nome;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = descricao;

                cmd.Parameters.Add("@preco", SqlDbType.Float);
                cmd.Parameters["@preco"].Value = preco;
               

                conn.Open();
                cmd.ExecuteScalar();
            }
        }
    }
}
