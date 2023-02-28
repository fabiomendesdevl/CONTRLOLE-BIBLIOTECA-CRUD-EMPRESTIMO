namespace biblioteca
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAut = new System.Windows.Forms.ComboBox();
            this.lbtexto = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btEntrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbAut);
            this.groupBox1.Controls.Add(this.lbtexto);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btEntrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txSenha);
            this.groupBox1.Controls.Add(this.txUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Admin ou Aluno";
            // 
            // cbAut
            // 
            this.cbAut.FormattingEnabled = true;
            this.cbAut.ItemHeight = 13;
            this.cbAut.Items.AddRange(new object[] {
            "Aluno",
            "Administrador"});
            this.cbAut.Location = new System.Drawing.Point(50, 145);
            this.cbAut.Name = "cbAut";
            this.cbAut.Size = new System.Drawing.Size(180, 21);
            this.cbAut.TabIndex = 7;
            this.cbAut.Text = "Selecione";
            // 
            // lbtexto
            // 
            this.lbtexto.AutoSize = true;
            this.lbtexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtexto.ForeColor = System.Drawing.Color.Red;
            this.lbtexto.Location = new System.Drawing.Point(15, 227);
            this.lbtexto.Name = "lbtexto";
            this.lbtexto.Size = new System.Drawing.Size(40, 16);
            this.lbtexto.TabIndex = 1;
            this.lbtexto.Text = "texto";
            this.lbtexto.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(258, 192);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 32);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btEntrar
            // 
            this.btEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntrar.Location = new System.Drawing.Point(50, 192);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(109, 32);
            this.btEntrar.TabIndex = 6;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome de usuário";
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(50, 96);
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '*';
            this.txSenha.Size = new System.Drawing.Size(283, 20);
            this.txSenha.TabIndex = 1;
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(50, 39);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(283, 20);
            this.txUsuario.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::biblioteca.Properties.Resources.biblioteca_on_line;
            this.pictureBox1.Location = new System.Drawing.Point(157, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.Label lbtexto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

