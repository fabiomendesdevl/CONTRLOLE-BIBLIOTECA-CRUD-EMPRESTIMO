namespace biblioteca
{
    partial class Cadastro
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
            this.cbAut = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txUsuarios = new System.Windows.Forms.TextBox();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.lbC = new System.Windows.Forms.Label();
            this.lbE = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txMatricula = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.txCelular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txCidade = new System.Windows.Forms.TextBox();
            this.txCpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAut);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txUsuarios);
            this.groupBox1.Controls.Add(this.txSenha);
            this.groupBox1.Controls.Add(this.lbC);
            this.groupBox1.Controls.Add(this.lbE);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbSemestre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txMatricula);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btCadastrar);
            this.groupBox1.Controls.Add(this.txCelular);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txCidade);
            this.groupBox1.Controls.Add(this.txCpf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txNome);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insira os dados do aluno";
            // 
            // cbAut
            // 
            this.cbAut.FormattingEnabled = true;
            this.cbAut.ItemHeight = 20;
            this.cbAut.Items.AddRange(new object[] {
            "Aluno",
            "Administrador"});
            this.cbAut.Location = new System.Drawing.Point(519, 272);
            this.cbAut.Name = "cbAut";
            this.cbAut.Size = new System.Drawing.Size(180, 28);
            this.cbAut.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(515, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Admin ou Aluno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(271, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Senha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(26, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nome de usuario";
            // 
            // txUsuarios
            // 
            this.txUsuarios.Location = new System.Drawing.Point(30, 272);
            this.txUsuarios.Name = "txUsuarios";
            this.txUsuarios.Size = new System.Drawing.Size(186, 26);
            this.txUsuarios.TabIndex = 20;
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(275, 272);
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '*';
            this.txSenha.Size = new System.Drawing.Size(186, 26);
            this.txSenha.TabIndex = 19;
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC.ForeColor = System.Drawing.Color.Green;
            this.lbC.Location = new System.Drawing.Point(27, 396);
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
            this.lbE.Location = new System.Drawing.Point(27, 396);
            this.lbE.Name = "lbE";
            this.lbE.Size = new System.Drawing.Size(40, 16);
            this.lbE.TabIndex = 17;
            this.lbE.Text = "texte";
            this.lbE.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(271, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Semestre";
            // 
            // cbSemestre
            // 
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Items.AddRange(new object[] {
            "1° Semestre",
            "2° Semestre",
            "3° Semestre",
            "4° Semestre",
            "5° Semestre",
            "6° Semestre",
            "7° Semestre",
            "8° Semestre"});
            this.cbSemestre.Location = new System.Drawing.Point(275, 198);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(111, 28);
            this.cbSemestre.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Numero da matricula";
            // 
            // txMatricula
            // 
            this.txMatricula.Location = new System.Drawing.Point(30, 200);
            this.txMatricula.Name = "txMatricula";
            this.txMatricula.Size = new System.Drawing.Size(186, 26);
            this.txMatricula.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(554, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btCadastrar.Location = new System.Drawing.Point(30, 335);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(133, 30);
            this.btCadastrar.TabIndex = 10;
            this.btCadastrar.Text = "Salvar Cadastro";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // txCelular
            // 
            this.txCelular.Location = new System.Drawing.Point(496, 139);
            this.txCelular.Name = "txCelular";
            this.txCelular.Size = new System.Drawing.Size(186, 26);
            this.txCelular.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(492, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Celular";
            // 
            // txCidade
            // 
            this.txCidade.Location = new System.Drawing.Point(191, 137);
            this.txCidade.Name = "txCidade";
            this.txCidade.Size = new System.Drawing.Size(254, 26);
            this.txCidade.TabIndex = 7;
            // 
            // txCpf
            // 
            this.txCpf.Location = new System.Drawing.Point(496, 68);
            this.txCpf.Name = "txCpf";
            this.txCpf.Size = new System.Drawing.Size(186, 26);
            this.txCpf.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(492, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(187, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome completo";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(30, 68);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(415, 26);
            this.txNome.TabIndex = 1;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceara",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbEstado.Location = new System.Drawing.Point(30, 137);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(133, 28);
            this.cbEstado.TabIndex = 0;
            this.cbEstado.Text = "Minas Gerais";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::biblioteca.Properties.Resources.registrado;
            this.pictureBox1.Location = new System.Drawing.Point(618, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txCelular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txCidade;
        private System.Windows.Forms.TextBox txCpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txMatricula;
        private System.Windows.Forms.Label lbE;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txUsuarios;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbAut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}