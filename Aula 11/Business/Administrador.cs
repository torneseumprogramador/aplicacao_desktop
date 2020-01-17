using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Administrador
    {
        public static Administrador AdmLogado = null;

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        
        public static bool Logar(string login, string senha)
        {
            var dados = new Database.Administrador().Login(login, senha);
            
            for (var i = 0; i < dados.Rows.Count; i++)
            {
                AdmLogado = new Administrador();
                AdmLogado.Id = Convert.ToInt32(dados.Rows[i]["id"]);
                AdmLogado.Nome = dados.Rows[i]["nome"].ToString();
                AdmLogado.Login = dados.Rows[i]["login"].ToString();
            }

            return AdmLogado != null;
        }

        public static void Excluir(int id)
        {
            new Database.Pessoa().Excluir(id);
        }
    }
}
