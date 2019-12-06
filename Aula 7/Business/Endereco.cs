using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Endereco
    {
        public int Id { get; set; } 
        public int PessoaId { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public static List<Endereco> Lista(int pessoaId)
        {
            var enderecos = new List<Endereco>();
            DataTable dados = new Database.Endereco().Lista(pessoaId);

            for (var i = 0; i < dados.Rows.Count; i++)
            {
                enderecos.Add(new Endereco()
                {
                    Id = Convert.ToInt32(dados.Rows[i]["id"]),
                    PessoaId = Convert.ToInt32(dados.Rows[i]["pessoa_id"]),
                    Logradouro = dados.Rows[i]["logradouro"].ToString(),
                    Numero = Convert.ToInt32(dados.Rows[i]["numero"]),
                    Bairro = dados.Rows[i]["bairro"].ToString(),
                    Cidade = dados.Rows[i]["cidade"].ToString(),
                    Estado = dados.Rows[i]["estado"].ToString(),
                });
            }

            return enderecos;
        }
    }
}
