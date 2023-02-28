namespace biblioteca
{
    partial class Emprestimo
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
            this.lbS = new System.Windows.Forms.Label();
            this.Btnempretimo = new System.Windows.Forms.Button();
            this.dtLivrosempres = new System.Windows.Forms.DataGridView();
            this.ID_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAlunosempres = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSS = new System.Windows.Forms.Label();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.dtFInal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtLivrosempres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlunosempres)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS.ForeColor = System.Drawing.Color.Green;
            this.lbS.Location = new System.Drawing.Point(-136, 543);
            this.lbS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(42, 16);
            this.lbS.TabIndex = 14;
            this.lbS.Text = "label";
            this.lbS.Visible = false;
            // 
            // Btnempretimo
            // 
            this.Btnempretimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnempretimo.Location = new System.Drawing.Point(179, 555);
            this.Btnempretimo.Margin = new System.Windows.Forms.Padding(4);
            this.Btnempretimo.Name = "Btnempretimo";
            this.Btnempretimo.Size = new System.Drawing.Size(236, 44);
            this.Btnempretimo.TabIndex = 13;
            this.Btnempretimo.Text = "Emprestimo";
            this.Btnempretimo.UseVisualStyleBackColor = true;
            this.Btnempretimo.Click += new System.EventHandler(this.Btnempretimo_Click_1);
            // 
            // dtLivrosempres
            // 
            this.dtLivrosempres.AllowUserToDeleteRows = false;
            this.dtLivrosempres.AllowUserToOrderColumns = true;
            this.dtLivrosempres.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtLivrosempres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLivrosempres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Livro,
            this.Nome_Livro,
            this.Autor,
            this.Editora,
            this.Ano,
            this.Codigo});
            this.dtLivrosempres.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtLivrosempres.Location = new System.Drawing.Point(22, 309);
            this.dtLivrosempres.Margin = new System.Windows.Forms.Padding(4);
            this.dtLivrosempres.Name = "dtLivrosempres";
            this.dtLivrosempres.ReadOnly = true;
            this.dtLivrosempres.Size = new System.Drawing.Size(1088, 219);
            this.dtLivrosempres.TabIndex = 12;
            // 
            // ID_Livro
            // 
            this.ID_Livro.HeaderText = "ID_Livro";
            this.ID_Livro.Name = "ID_Livro";
            this.ID_Livro.ReadOnly = true;
            this.ID_Livro.Width = 150;
            // 
            // Nome_Livro
            // 
            this.Nome_Livro.HeaderText = "Nome_Livro";
            this.Nome_Livro.Name = "Nome_Livro";
            this.Nome_Livro.ReadOnly = true;
            this.Nome_Livro.Width = 230;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 150;
            // 
            // Editora
            // 
            this.Editora.HeaderText = "Editora";
            this.Editora.Name = "Editora";
            this.Editora.ReadOnly = true;
            this.Editora.Width = 190;
            // 
            // Ano
            // 
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            this.Ano.Width = 190;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 150;
            // 
            // dtAlunosempres
            // 
            this.dtAlunosempres.AllowUserToDeleteRows = false;
            this.dtAlunosempres.AllowUserToOrderColumns = true;
            this.dtAlunosempres.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtAlunosempres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAlunosempres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Cpf,
            this.Estado,
            this.Cidade,
            this.Celular,
            this.Matricula,
            this.Semestre,
            this.Usuario,
            this.Senha,
            this.Tipo});
            this.dtAlunosempres.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtAlunosempres.Location = new System.Drawing.Point(22, 51);
            this.dtAlunosempres.Margin = new System.Windows.Forms.Padding(4);
            this.dtAlunosempres.Name = "dtAlunosempres";
            this.dtAlunosempres.ReadOnly = true;
            this.dtAlunosempres.Size = new System.Drawing.Size(1088, 219);
            this.dtAlunosempres.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Cpf
            // 
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            this.Cpf.Width = 150;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 150;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            this.Cidade.Width = 175;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 140;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Width = 130;
            // 
            // Semestre
            // 
            this.Semestre.HeaderText = "Semestre";
            this.Semestre.Name = "Semestre";
            this.Semestre.ReadOnly = true;
            this.Semestre.Visible = false;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Visible = false;
            // 
            // Senha
            // 
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            this.Senha.Visible = false;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-125, -64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome Aluno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Aluno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Livros";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtFInal);
            this.groupBox1.Controls.Add(this.dtInicial);
            this.groupBox1.Controls.Add(this.lbSS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtAlunosempres);
            this.groupBox1.Controls.Add(this.dtLivrosempres);
            this.groupBox1.Controls.Add(this.Btnempretimo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1120, 651);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Faça o emprestimo aqui";
            // 
            // lbSS
            // 
            this.lbSS.AutoSize = true;
            this.lbSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSS.Location = new System.Drawing.Point(25, 632);
            this.lbSS.Name = "lbSS";
            this.lbSS.Size = new System.Drawing.Size(50, 16);
            this.lbSS.TabIndex = 19;
            this.lbSS.Text = "label2";
            this.lbSS.Visible = false;
            // 
            // dtInicial
            // 
            this.dtInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(22, 555);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(101, 24);
            this.dtInicial.TabIndex = 20;
            // 
            // dtFInal
            // 
            this.dtFInal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFInal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFInal.Location = new System.Drawing.Point(22, 605);
            this.dtFInal.Name = "dtFInal";
            this.dtFInal.Size = new System.Drawing.Size(101, 24);
            this.dtFInal.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Data Inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 586);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Data Final";
            // 
            // Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 675);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbS);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Emprestimo";
            this.Text = "Emprestimo";
            ((System.ComponentModel.ISupportInitialize)(this.dtLivrosempres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlunosempres)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.Button Btnempretimo;
        private System.Windows.Forms.DataGridView dtLivrosempres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridView dtAlunosempres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.Label lbSS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFInal;
        private System.Windows.Forms.DateTimePicker dtInicial;
    }
}