namespace biblioteca
{
    partial class Cadastro_Livro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.txEditora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.lbC = new System.Windows.Forms.Label();
            this.lbE = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.btCadastroLivro = new System.Windows.Forms.Button();
            this.txAutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtData);
            this.groupBox1.Controls.Add(this.txEditora);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txCodigo);
            this.groupBox1.Controls.Add(this.lbC);
            this.groupBox1.Controls.Add(this.lbE);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btSair);
            this.groupBox1.Controls.Add(this.btCadastroLivro);
            this.groupBox1.Controls.Add(this.txAutor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 291);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insira os dados do livro";
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(172, 128);
            this.dtData.Name = "dtData";
            this.dtData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtData.Size = new System.Drawing.Size(104, 26);
            this.dtData.TabIndex = 25;
            this.dtData.Value = new System.DateTime(2023, 1, 27, 0, 0, 0, 0);
            // 
            // txEditora
            // 
            this.txEditora.Location = new System.Drawing.Point(43, 128);
            this.txEditora.Multiline = true;
            this.txEditora.Name = "txEditora";
            this.txEditora.Size = new System.Drawing.Size(101, 26);
            this.txEditora.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(39, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Editora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(168, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ano de lançamento";
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(510, 128);
            this.txCodigo.Multiline = true;
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(155, 26);
            this.txCodigo.TabIndex = 21;
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC.ForeColor = System.Drawing.Color.Green;
            this.lbC.Location = new System.Drawing.Point(27, 253);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(40, 16);
            this.lbC.TabIndex = 18;
            this.lbC.Text = "texte";
            this.lbC.Visible = false;
            // 
            // lbE
            // 
            this.lbE.AutoSize = true;
            this.lbE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbE.Location = new System.Drawing.Point(26, 253);
            this.lbE.Name = "lbE";
            this.lbE.Size = new System.Drawing.Size(40, 16);
            this.lbE.TabIndex = 17;
            this.lbE.Text = "texte";
            this.lbE.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(506, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Codigo do livro";
            // 
            // btSair
            // 
            this.btSair.ForeColor = System.Drawing.Color.Red;
            this.btSair.Location = new System.Drawing.Point(510, 204);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(86, 30);
            this.btSair.TabIndex = 11;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btCadastroLivro
            // 
            this.btCadastroLivro.ForeColor = System.Drawing.Color.Black;
            this.btCadastroLivro.Location = new System.Drawing.Point(30, 204);
            this.btCadastroLivro.Name = "btCadastroLivro";
            this.btCadastroLivro.Size = new System.Drawing.Size(133, 30);
            this.btCadastroLivro.TabIndex = 10;
            this.btCadastroLivro.Text = "Salvar Cadastro";
            this.btCadastroLivro.UseVisualStyleBackColor = true;
            this.btCadastroLivro.Click += new System.EventHandler(this.btCadastroLivro_Click);
            // 
            // txAutor
            // 
            this.txAutor.Location = new System.Drawing.Point(510, 57);
            this.txAutor.Name = "txAutor";
            this.txAutor.Size = new System.Drawing.Size(186, 26);
            this.txAutor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(506, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome do Autor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do livro";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(44, 57);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(415, 26);
            this.txNome.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::biblioteca.Properties.Resources.biblioteca_on_line;
            this.pictureBox1.Location = new System.Drawing.Point(689, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Cadastro_Livro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cadastro_Livro";
            this.Text = "Cadastro_Livro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txEditora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lbE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCadastroLivro;
        private System.Windows.Forms.TextBox txAutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNome;
        protected internal System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}