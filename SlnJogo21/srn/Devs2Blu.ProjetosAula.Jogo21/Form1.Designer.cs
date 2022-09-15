namespace Devs2Blu.ProjetosAula.Jogo21
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbPlayer1 = new System.Windows.Forms.GroupBox();
            this.txtResultP1 = new System.Windows.Forms.TextBox();
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.gbPlayer2 = new System.Windows.Forms.GroupBox();
            this.txtResultP2 = new System.Windows.Forms.TextBox();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.gbPlayer1.SuspendLayout();
            this.gbPlayer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ProjetoAula + Devs2Blu";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbPlayer1
            // 
            this.gbPlayer1.BackColor = System.Drawing.Color.White;
            this.gbPlayer1.Controls.Add(this.txtResultP1);
            this.gbPlayer1.Controls.Add(this.btnPlayer1);
            this.gbPlayer1.Controls.Add(this.txtPlayer1);
            this.gbPlayer1.ForeColor = System.Drawing.Color.Black;
            this.gbPlayer1.Location = new System.Drawing.Point(12, 374);
            this.gbPlayer1.Name = "gbPlayer1";
            this.gbPlayer1.Size = new System.Drawing.Size(231, 226);
            this.gbPlayer1.TabIndex = 1;
            this.gbPlayer1.TabStop = false;
            this.gbPlayer1.Text = "Player 1";
            // 
            // txtResultP1
            // 
            this.txtResultP1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtResultP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultP1.Location = new System.Drawing.Point(6, 19);
            this.txtResultP1.Multiline = true;
            this.txtResultP1.Name = "txtResultP1";
            this.txtResultP1.ReadOnly = true;
            this.txtResultP1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultP1.Size = new System.Drawing.Size(206, 114);
            this.txtResultP1.TabIndex = 2;
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.BackColor = System.Drawing.Color.Green;
            this.btnPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer1.ForeColor = System.Drawing.Color.Azure;
            this.btnPlayer1.Location = new System.Drawing.Point(147, 192);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(75, 28);
            this.btnPlayer1.TabIndex = 3;
            this.btnPlayer1.Text = "OK";
            this.btnPlayer1.UseVisualStyleBackColor = false;
            this.btnPlayer1.Click += new System.EventHandler(this.btnPlayer1_Click);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1.Location = new System.Drawing.Point(6, 192);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(135, 29);
            this.txtPlayer1.TabIndex = 2;
            this.txtPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbPlayer2
            // 
            this.gbPlayer2.BackColor = System.Drawing.Color.White;
            this.gbPlayer2.Controls.Add(this.txtResultP2);
            this.gbPlayer2.Controls.Add(this.btnPlayer2);
            this.gbPlayer2.Controls.Add(this.txtPlayer2);
            this.gbPlayer2.ForeColor = System.Drawing.Color.Black;
            this.gbPlayer2.Location = new System.Drawing.Point(428, 374);
            this.gbPlayer2.Name = "gbPlayer2";
            this.gbPlayer2.Size = new System.Drawing.Size(228, 226);
            this.gbPlayer2.TabIndex = 2;
            this.gbPlayer2.TabStop = false;
            this.gbPlayer2.Text = "Player 2 (PC)";
            // 
            // txtResultP2
            // 
            this.txtResultP2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtResultP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultP2.Location = new System.Drawing.Point(6, 19);
            this.txtResultP2.Multiline = true;
            this.txtResultP2.Name = "txtResultP2";
            this.txtResultP2.ReadOnly = true;
            this.txtResultP2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultP2.Size = new System.Drawing.Size(206, 114);
            this.txtResultP2.TabIndex = 4;
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.BackColor = System.Drawing.Color.Green;
            this.btnPlayer2.Enabled = false;
            this.btnPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer2.ForeColor = System.Drawing.Color.Azure;
            this.btnPlayer2.Location = new System.Drawing.Point(145, 192);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(75, 28);
            this.btnPlayer2.TabIndex = 4;
            this.btnPlayer2.Text = "OK";
            this.btnPlayer2.UseVisualStyleBackColor = false;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPlayer2.Enabled = false;
            this.txtPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2.Location = new System.Drawing.Point(6, 192);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(133, 29);
            this.txtPlayer2.TabIndex = 1;
            this.txtPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.txtConsole);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(18, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 226);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jogo 21 - Tabuleiro";
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.Location = new System.Drawing.Point(20, 33);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(588, 169);
            this.txtConsole.TabIndex = 1;
            this.txtConsole.Text = "Bem vindo ao Jogo 21.";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(275, 383);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(109, 42);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoJogo.Location = new System.Drawing.Point(275, 431);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(109, 42);
            this.btnNovoJogo.TabIndex = 5;
            this.btnNovoJogo.Text = "Novo Jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = true;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(668, 605);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPlayer2);
            this.Controls.Add(this.gbPlayer1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPlayer1.ResumeLayout(false);
            this.gbPlayer1.PerformLayout();
            this.gbPlayer2.ResumeLayout(false);
            this.gbPlayer2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbPlayer1;
        private System.Windows.Forms.GroupBox gbPlayer2;
        private System.Windows.Forms.Button btnPlayer1;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.Button btnPlayer2;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.TextBox txtResultP1;
        private System.Windows.Forms.TextBox txtResultP2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnNovoJogo;
    }
}

