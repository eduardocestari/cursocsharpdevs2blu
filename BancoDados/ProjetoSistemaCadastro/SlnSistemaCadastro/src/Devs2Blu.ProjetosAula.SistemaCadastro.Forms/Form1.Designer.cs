namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gpFormCadastro = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpEnderecoCadastro = new System.Windows.Forms.GroupBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCGCCPF = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCGCCPF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rdJuridica = new System.Windows.Forms.RadioButton();
            this.rdFisica = new System.Windows.Forms.RadioButton();
            this.cboConvenio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.gpConteudo = new System.Windows.Forms.GroupBox();
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpFormCadastro.SuspendLayout();
            this.gpEnderecoCadastro.SuspendLayout();
            this.gpTipoPessoa.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpFormCadastro
            // 
            this.gpFormCadastro.Controls.Add(this.btnLimpar);
            this.gpFormCadastro.Controls.Add(this.gpEnderecoCadastro);
            this.gpFormCadastro.Controls.Add(this.txtCGCCPF);
            this.gpFormCadastro.Controls.Add(this.txtNome);
            this.gpFormCadastro.Controls.Add(this.lblCGCCPF);
            this.gpFormCadastro.Controls.Add(this.label2);
            this.gpFormCadastro.Controls.Add(this.gpTipoPessoa);
            this.gpFormCadastro.Controls.Add(this.cboConvenio);
            this.gpFormCadastro.Controls.Add(this.label1);
            this.gpFormCadastro.Location = new System.Drawing.Point(12, 31);
            this.gpFormCadastro.Name = "gpFormCadastro";
            this.gpFormCadastro.Size = new System.Drawing.Size(366, 332);
            this.gpFormCadastro.TabIndex = 4;
            this.gpFormCadastro.TabStop = false;
            this.gpFormCadastro.Text = "Formulário de Cadastro";
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(278, 244);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // gpEnderecoCadastro
            // 
            this.gpEnderecoCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpEnderecoCadastro.Controls.Add(this.mskCEP);
            this.gpEnderecoCadastro.Controls.Add(this.txtBairro);
            this.gpEnderecoCadastro.Controls.Add(this.txtNumero);
            this.gpEnderecoCadastro.Controls.Add(this.txtCidade);
            this.gpEnderecoCadastro.Controls.Add(this.cboUF);
            this.gpEnderecoCadastro.Controls.Add(this.txtRua);
            this.gpEnderecoCadastro.Controls.Add(this.label8);
            this.gpEnderecoCadastro.Controls.Add(this.label7);
            this.gpEnderecoCadastro.Controls.Add(this.label6);
            this.gpEnderecoCadastro.Controls.Add(this.label5);
            this.gpEnderecoCadastro.Controls.Add(this.label4);
            this.gpEnderecoCadastro.Controls.Add(this.label3);
            this.gpEnderecoCadastro.Location = new System.Drawing.Point(11, 113);
            this.gpEnderecoCadastro.Name = "gpEnderecoCadastro";
            this.gpEnderecoCadastro.Size = new System.Drawing.Size(342, 116);
            this.gpEnderecoCadastro.TabIndex = 12;
            this.gpEnderecoCadastro.TabStop = false;
            this.gpEnderecoCadastro.Text = "Endereço/Contato";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(45, 29);
            this.mskCEP.Mask = "00.000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(74, 20);
            this.mskCEP.TabIndex = 17;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(45, 82);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(187, 20);
            this.txtBairro.TabIndex = 16;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(288, 56);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(44, 20);
            this.txtNumero.TabIndex = 15;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(233, 30);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(99, 20);
            this.txtCidade.TabIndex = 13;
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(140, 29);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(41, 21);
            this.cboUF.TabIndex = 14;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(45, 56);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(187, 20);
            this.txtRua.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(117, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "UF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(13, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Rua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(238, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(11, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bairro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(188, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CEP";
            // 
            // txtCGCCPF
            // 
            this.txtCGCCPF.Location = new System.Drawing.Point(63, 45);
            this.txtCGCCPF.Name = "txtCGCCPF";
            this.txtCGCCPF.Size = new System.Drawing.Size(120, 20);
            this.txtCGCCPF.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(63, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(287, 20);
            this.txtNome.TabIndex = 10;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblCGCCPF
            // 
            this.lblCGCCPF.AutoSize = true;
            this.lblCGCCPF.Location = new System.Drawing.Point(27, 48);
            this.lblCGCCPF.Name = "lblCGCCPF";
            this.lblCGCCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCGCCPF.TabIndex = 9;
            this.lblCGCCPF.Text = "CPF";
            this.lblCGCCPF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // gpTipoPessoa
            // 
            this.gpTipoPessoa.Controls.Add(this.rdJuridica);
            this.gpTipoPessoa.Controls.Add(this.rdFisica);
            this.gpTipoPessoa.Location = new System.Drawing.Point(194, 48);
            this.gpTipoPessoa.Name = "gpTipoPessoa";
            this.gpTipoPessoa.Size = new System.Drawing.Size(156, 48);
            this.gpTipoPessoa.TabIndex = 7;
            this.gpTipoPessoa.TabStop = false;
            this.gpTipoPessoa.Text = "Tipo Pessoa";
            // 
            // rdJuridica
            // 
            this.rdJuridica.AutoSize = true;
            this.rdJuridica.Location = new System.Drawing.Point(78, 19);
            this.rdJuridica.Name = "rdJuridica";
            this.rdJuridica.Size = new System.Drawing.Size(63, 17);
            this.rdJuridica.TabIndex = 7;
            this.rdJuridica.Text = "Jurídica";
            this.rdJuridica.UseVisualStyleBackColor = true;
            this.rdJuridica.CheckedChanged += new System.EventHandler(this.rdJuridica_CheckedChanged);
            // 
            // rdFisica
            // 
            this.rdFisica.AutoSize = true;
            this.rdFisica.Checked = true;
            this.rdFisica.Location = new System.Drawing.Point(18, 19);
            this.rdFisica.Name = "rdFisica";
            this.rdFisica.Size = new System.Drawing.Size(54, 17);
            this.rdFisica.TabIndex = 6;
            this.rdFisica.TabStop = true;
            this.rdFisica.Text = "Física";
            this.rdFisica.UseVisualStyleBackColor = true;
            this.rdFisica.CheckedChanged += new System.EventHandler(this.rdFisica_CheckedChanged);
            // 
            // cboConvenio
            // 
            this.cboConvenio.FormattingEnabled = true;
            this.cboConvenio.Location = new System.Drawing.Point(63, 71);
            this.cboConvenio.Name = "cboConvenio";
            this.cboConvenio.Size = new System.Drawing.Size(120, 21);
            this.cboConvenio.TabIndex = 3;
            this.cboConvenio.SelectedIndexChanged += new System.EventHandler(this.cboConvenio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Convênio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Location = new System.Drawing.Point(12, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 83);
            this.panel1.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(10, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 76);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(106, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 76);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.Location = new System.Drawing.Point(674, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(90, 76);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.UseVisualStyleBackColor = false;
            // 
            // gpConteudo
            // 
            this.gpConteudo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gpConteudo.Controls.Add(this.gridPacientes);
            this.gpConteudo.Location = new System.Drawing.Point(400, 31);
            this.gpConteudo.Name = "gpConteudo";
            this.gpConteudo.Size = new System.Drawing.Size(379, 326);
            this.gpConteudo.TabIndex = 8;
            this.gpConteudo.TabStop = false;
            // 
            // gridPacientes
            // 
            this.gridPacientes.AllowUserToAddRows = false;
            this.gridPacientes.AllowUserToOrderColumns = true;
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.Location = new System.Drawing.Point(6, 19);
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.ReadOnly = true;
            this.gridPacientes.Size = new System.Drawing.Size(368, 301);
            this.gridPacientes.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 478);
            this.Controls.Add(this.gpConteudo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpFormCadastro);
            this.Name = "Form1";
            this.Text = "+Devs2Blu - Sistema de Cadastro Hospitalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpFormCadastro.ResumeLayout(false);
            this.gpFormCadastro.PerformLayout();
            this.gpEnderecoCadastro.ResumeLayout(false);
            this.gpEnderecoCadastro.PerformLayout();
            this.gpTipoPessoa.ResumeLayout(false);
            this.gpTipoPessoa.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gpConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpFormCadastro;
        private System.Windows.Forms.ComboBox cboConvenio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpTipoPessoa;
        private System.Windows.Forms.RadioButton rdJuridica;
        private System.Windows.Forms.RadioButton rdFisica;
        private System.Windows.Forms.Label lblCGCCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpEnderecoCadastro;
        private System.Windows.Forms.TextBox txtCGCCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.GroupBox gpConteudo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView gridPacientes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

