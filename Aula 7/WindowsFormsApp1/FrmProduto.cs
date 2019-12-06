using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Nome = txtNome.Text;
            produto.Descricao = txtDescricao.Text;
            produto.Preco =Convert.ToDecimal( txtPreco.Text);
            produto.Salvar();
            MessageBox.Show("Produto incluido com sucesso");
            this.Close();
        }
    }
}
