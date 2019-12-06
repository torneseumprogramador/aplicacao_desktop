using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Decimal Preco { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataInclusao { get; set; }

        public static List<Produto> Lista()
        {
            var produtos = new List<Produto>();
            DataTable dados = new Database.Produto().Lista();

            for (var i = 0; i < dados.Rows.Count; i++)
            {
                produtos.Add(new Produto()
                {
                    Id = Convert.ToInt32(dados.Rows[i]["id"]),
                    Nome = dados.Rows[i]["nome"].ToString(),
                    Descricao = dados.Rows[i]["descricao"].ToString(),
                    Preco = Convert.ToDecimal(dados.Rows[i]["preco"]),
                    DataAlteracao = Convert.ToDateTime(dados.Rows[i]["data_alteracao"]),
                    DataInclusao = Convert.ToDateTime(dados.Rows[i]["data_inclusao"]),
                });
            }

            return produtos;
        }

       
    }
}
