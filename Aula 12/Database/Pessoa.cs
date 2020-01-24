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
    public class Pessoa
    {
        private string connString = "";
        private int administrador_id = 0;

        public Pessoa()
        {
           connString = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        }

        public Pessoa(int _administradorId)
        {
            connString = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            administrador_id = _administradorId;
        }

        public int Salvar(string nome, string cpf, string telefone, string email, bool ativo)
        {
            int id = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "InserirPessoa";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = nome;

                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters["@cpf"].Value = cpf;

                cmd.Parameters.Add("@telefone", SqlDbType.VarChar);
                cmd.Parameters["@telefone"].Value = telefone;

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = email;

                cmd.Parameters.Add("@ativo", SqlDbType.TinyInt);
                cmd.Parameters["@ativo"].Value = ativo;

                conn.Open();
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return id;
        }

        public void Atualizar(int id, string nome, string cpf, string telefone, string email, bool ativo)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "update pessoas set nome=@nome, cpf=@cpf, telefone=@telefone, email=@email, ativo=@ativo where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = nome;

                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters["@cpf"].Value = cpf;

                cmd.Parameters.Add("@telefone", SqlDbType.VarChar);
                cmd.Parameters["@telefone"].Value = telefone;

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = email;

                cmd.Parameters.Add("@ativo", SqlDbType.TinyInt);
                cmd.Parameters["@ativo"].Value = ativo;
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "insert into logs(conteudo)values('" + this.logAlteracao( id, nome, cpf, telefone, email, ativo) + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private string logAlteracao(int id, string nome, string cpf, string telefone, string email, bool ativo)
        {
            var conteudo = "";
            conteudo += "Alteração do modelo de pessoa, Adminitrador responsável " + this.administrador_id + " ";
            conteudo += " id: " + id + " ";
            conteudo += " nome: " + nome + " ";
            conteudo += " CPF: " + cpf + " ";
            return conteudo;
        }

        public void Excluir(int id)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "delete from pessoas where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable Lista(string nome)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from pessoas";
                if (!string.IsNullOrEmpty(nome))
                {
                    sql += " where nome like '%" + nome + "%'";
                }

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
