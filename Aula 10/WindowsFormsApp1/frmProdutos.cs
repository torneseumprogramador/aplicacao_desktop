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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPessoa.frmProds = null;
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        public void atualizaGrid()
        {
            dgvProdutos.DataSource = Produto.Lista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProduto frm = new FrmProduto(this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }

            var produto = (Produto)dgvProdutos.Rows[dgvProdutos.SelectedRows[0].Index].DataBoundItem;
            FrmProduto frm = new FrmProduto(this, produto);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }

            var produto = (Produto)dgvProdutos.Rows[dgvProdutos.SelectedRows[0].Index].DataBoundItem;

            var confirmResult = MessageBox.Show("Confirma ?", "Exclusão", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                produto.Apagar();
                atualizaGrid();
            }
        }
    }
}
