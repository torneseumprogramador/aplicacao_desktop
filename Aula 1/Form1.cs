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
            btnGravar.Visible = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoa(){ Nome = txtNome.Text, CPF = mskCpf.Text, Telefone = mskTelefone.Text, Email = txtEmail.Text };
            pessoa.Salvar();

            MessageBox.Show("Cadastro concluido com sucesso, o seu ID é: " + pessoa.Id);
        }
    }
}