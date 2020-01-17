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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(Administrador.Logar(txtLogin.Text, txtSenha.Text))
            {
                new MDIPai().Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválida");
            }
        }
    }
}
