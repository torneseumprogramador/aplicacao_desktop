namespace WindowsFormsApp1
{
    partial class frmPessoa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbcCadastro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgListaClientes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.tbcCadastro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaClientes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCadastro
            // 
            this.tbcCadastro.Controls.Add(this.tabPage1);
            this.tbcCadastro.Controls.Add(this.tabCadastro);
            this.tbcCadastro.Location = new System.Drawing.Point(14, 59);
            this.tbcCadastro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbcCadastro.Name = "tbcCadastro";
            this.tbcCadastro.SelectedIndex = 0;
            this.tbcCadastro.Size = new System.Drawing.Size(1181, 831);
            this.tbcCadastro.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.txtNomePesquisa);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtgListaClientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1173, 798);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista de clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(543, 19);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 38);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(99, 28);
            this.txtNomePesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(426, 26);
            this.txtNomePesquisa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // dtgListaClientes
            // 
            this.dtgListaClientes.AllowUserToAddRows = false;
            this.dtgListaClientes.AllowUserToDeleteRows = false;
            this.dtgListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaClientes.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgListaClientes.Location = new System.Drawing.Point(7, 64);
            this.dtgListaClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgListaClientes.Name = "dtgListaClientes";
            this.dtgListaClientes.ReadOnly = true;
            this.dtgListaClientes.RowTemplate.Height = 24;
            this.dtgListaClientes.Size = new System.Drawing.Size(1144, 739);
            this.dtgListaClientes.TabIndex = 0;
            this.dtgListaClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListaClientes_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 34);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.chkAtivo);
            this.tabCadastro.Controls.Add(this.txtId);
            this.tabCadastro.Controls.Add(this.label2);
            this.tabCadastro.Controls.Add(this.mskTelefone);
            this.tabCadastro.Controls.Add(this.mskCpf);
            this.tabCadastro.Controls.Add(this.txtEmail);
            this.tabCadastro.Controls.Add(this.lblEmail);
            this.tabCadastro.Controls.Add(this.lblCpf);
            this.tabCadastro.Controls.Add(this.lblTelefone);
            this.tabCadastro.Controls.Add(this.txtNome);
            this.tabCadastro.Controls.Add(this.lblNome);
            this.tabCadastro.Controls.Add(this.btnGravar);
            this.tabCadastro.Location = new System.Drawing.Point(4, 29);
            this.tabCadastro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCadastro.Size = new System.Drawing.Size(1173, 798);
            this.tabCadastro.TabIndex = 1;
            this.tabCadastro.Text = "Cadastro";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(122, 44);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(247, 26);
            this.txtId.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Id";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(122, 189);
            this.mskTelefone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskTelefone.Mask = "(99) 99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(247, 26);
            this.mskTelefone.TabIndex = 11;
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(122, 141);
            this.mskCpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskCpf.Mask = "999.999.999.99";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(247, 26);
            this.mskCpf.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 241);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 26);
            this.txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(46, 248);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(46, 148);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(40, 20);
            this.lblCpf.TabIndex = 14;
            this.lblCpf.Text = "CPF";
            this.lblCpf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(46, 195);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 12;
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(122, 91);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(247, 26);
            this.txtNome.TabIndex = 8;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(46, 98);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(50, 325);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(109, 48);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(1085, 33);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(84, 38);
            this.btnProdutos.TabIndex = 9;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(50, 284);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(70, 24);
            this.chkAtivo.TabIndex = 19;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // frmPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 905);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.tbcCadastro);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPessoa";
            this.Text = "Pessoa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcCadastro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaClientes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCadastro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgListaClientes;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.CheckBox chkAtivo;
    }
}

