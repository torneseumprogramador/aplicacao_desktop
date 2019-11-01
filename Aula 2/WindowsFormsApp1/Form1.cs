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
    public partial class frmPessoa : Form
    {
        public frmPessoa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgListaClientes.DataSource = Pessoa.Lista();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoa(){ Nome = txtNome.Text, CPF = mskCpf.Text, Telefone = mskTelefone.Text, Email = txtEmail.Text };
            pessoa.Salvar();

            MessageBox.Show("Cadastro concluido com sucesso, o seu ID é: " + pessoa.Id);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtgListaClientes.DataSource = Pessoa.Lista(txtNomePesquisa.Text);
        }

        private void dtgListaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var pessoa = (Pessoa)dtgListaClientes.Rows[e.RowIndex].DataBoundItem;
            txtNome.Text = pessoa.Nome;
            txtEmail.Text = pessoa.Email;
            mskCpf.Text = pessoa.CPF;
            mskTelefone.Text = pessoa.Telefone;
            tbcCadastro.SelectedTab = tabCadastro;
        }
    }
}