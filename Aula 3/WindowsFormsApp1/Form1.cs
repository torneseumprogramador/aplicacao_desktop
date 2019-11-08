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

            if (string.IsNullOrEmpty(txtId.Text)) txtId.Text = "0";
            var pessoa = new Pessoa() { Id = Convert.ToInt32(txtId.Text), Nome = txtNome.Text, CPF = mskCpf.Text, Telefone = mskTelefone.Text, Email = txtEmail.Text };
            pessoa.Salvar();

            if (txtId.Text == "0")
                MessageBox.Show("Cadastro concluido com sucesso, o seu ID é: " + pessoa.Id);
            else
                MessageBox.Show("Dado atualizado");

            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            mskCpf.Text = string.Empty;
            mskTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;

            dtgListaClientes.DataSource = Pessoa.Lista();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtgListaClientes.DataSource = Pessoa.Lista(txtNomePesquisa.Text);
        }

        private void dtgListaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var pessoa = (Pessoa)dtgListaClientes.Rows[e.RowIndex].DataBoundItem;
            txtId.Text = pessoa.Id.ToString();
            txtNome.Text = pessoa.Nome;
            txtEmail.Text = pessoa.Email;
            mskCpf.Text = pessoa.CPF;
            mskTelefone.Text = pessoa.Telefone;
            tbcCadastro.SelectedTab = tabCadastro;
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pessoa = (Pessoa)dtgListaClientes.Rows[dtgListaClientes.SelectedCells[0].RowIndex].DataBoundItem;

            var confirmResult = MessageBox.Show("Confirma ?", "Exclusão", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Pessoa.Excluir(pessoa.Id);
                dtgListaClientes.DataSource = Pessoa.Lista(txtNomePesquisa.Text);
            }
        }
    }
}