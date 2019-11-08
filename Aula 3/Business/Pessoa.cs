using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Pessoa
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public void Salvar()
        {
            if (string.IsNullOrEmpty(this.Nome))
            {
                throw new Exception("Nome não pode ser vazio");
            }

            if(this.Id > 0)
            {
                new Database.Pessoa().Atualizar(this.Id, this.Nome, this.CPF, this.Telefone, this.Email);
                return;
            }

            this.Id = new Database.Pessoa().Salvar(this.Nome, this.CPF, this.Telefone, this.Email);
        }

        public static List<Pessoa> Lista()
        {
            return Lista(string.Empty);
        }

        public static List<Pessoa> Lista(string nome)
        {
            var pessoas = new List<Pessoa>();
            DataTable dados = new Database.Pessoa().Lista(nome);

            for (var i = 0; i < dados.Rows.Count; i++)
            {
                pessoas.Add(new Pessoa()
                {
                    Id = Convert.ToInt32(dados.Rows[i]["id"]),
                    Nome = dados.Rows[i]["nome"].ToString(),
                    CPF = dados.Rows[i]["cpf"].ToString(),
                    Telefone = dados.Rows[i]["telefone"].ToString(),
                    Email = dados.Rows[i]["email"].ToString(),
                });
            }

            return pessoas;
        }

        public static void Excluir(int id)
        {
            new Database.Pessoa().Excluir(id);
        }
    }
}
