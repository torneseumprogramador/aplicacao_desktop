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

        private frmProdutos frmProdutos;
        private Produto produto = new Produto();

        public FrmProduto(frmProdutos _frmProdutos, Produto _produto = null)
        {
            InitializeComponent();
            this.produto = _produto;
            this.frmProdutos = _frmProdutos;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var mensagem = "incluido";
            Produto produto;
            if(this.produto != null)
            {

                mensagem = "alterado";
                produto = this.produto;
            }
            else
            {
                produto = new Produto();
            }

            produto.Nome = txtNome.Text;
            produto.Descricao = txtDescricao.Text;
            produto.Preco =Convert.ToDecimal( txtPreco.Text);
            produto.Salvar();
            MessageBox.Show("Produto " + mensagem + " com sucesso");
            this.frmProdutos.atualizaGrid();
            this.Close();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            txtNome.Text = produto.Nome;
            txtDescricao.Text = produto.Descricao;
            txtPreco.Text = produto.Preco.ToString();
        }
    }
}
