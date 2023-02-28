namespace biblioteca
{
    partial class Controle_Biblioteca
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
            this.txBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtLivros = new System.Windows.Forms.DataGridView();
            this.ID_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.cbBuscaB = new System.Windows.Forms.ComboBox();
            this.dtAlunosb = new System.Windows.Forms.DataGridView();
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
            this.btSair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btEditar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlunosb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txBuscar
            // 
            this.txBuscar.Location = new System.Drawing.Point(15, 65);
            this.txBuscar.Name = "txBuscar";
            this.txBuscar.Size = new System.Drawing.Size(349, 26);
            this.txBuscar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira algum dado para buscar...";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(15, 97);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(83, 32);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dtLivros);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btExcluir);
            this.groupBox1.Controls.Add(this.cbBuscaB);
            this.groupBox1.Controls.Add(this.dtAlunosb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Controls.Add(this.txBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1084, 746);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca, edita e exclui";
            // 
            // dtLivros
            // 
            this.dtLivros.AllowUserToDeleteRows = false;
            this.dtLivros.AllowUserToOrderColumns = true;
            this.dtLivros.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Livro,
            this.Nome_Livro,
            this.Autor,
            this.Editora,
            this.Ano,
            this.Codigo});
            this.dtLivros.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtLivros.Location = new System.Drawing.Point(0, 459);
            this.dtLivros.Name = "dtLivros";
            this.dtLivros.ReadOnly = true;
            this.dtLivros.Size = new System.Drawing.Size(1085, 277);
            this.dtLivros.TabIndex = 10;
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
            this.Nome_Livro.Width = 200;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 175;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecione a linha do Aluno para deletar";
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.Color.Red;
            this.btExcluir.Location = new System.Drawing.Point(15, 419);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(83, 32);
            this.btExcluir.TabIndex = 5;
            this.btExcluir.Text = "Deletar";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // cbBuscaB
            // 
            this.cbBuscaB.FormattingEnabled = true;
            this.cbBuscaB.Items.AddRange(new object[] {
            "Alunos",
            "Livros"});
            this.cbBuscaB.Location = new System.Drawing.Point(409, 65);
            this.cbBuscaB.Name = "cbBuscaB";
            this.cbBuscaB.Size = new System.Drawing.Size(121, 28);
            this.cbBuscaB.TabIndex = 4;
            // 
            // dtAlunosb
            // 
            this.dtAlunosb.AllowUserToDeleteRows = false;
            this.dtAlunosb.AllowUserToOrderColumns = true;
            this.dtAlunosb.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtAlunosb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAlunosb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dtAlunosb.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtAlunosb.Location = new System.Drawing.Point(15, 135);
            this.dtAlunosb.Name = "dtAlunosb";
            this.dtAlunosb.ReadOnly = true;
            this.dtAlunosb.Size = new System.Drawing.Size(1085, 258);
            this.dtAlunosb.TabIndex = 3;
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
            // 
            // Cpf
            // 
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            this.Cpf.Width = 120;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 120;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // Semestre
            // 
            this.Semestre.HeaderText = "Semestre";
            this.Semestre.Name = "Semestre";
            this.Semestre.ReadOnly = true;
            this.Semestre.Width = 108;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Senha
            // 
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Visible = false;
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Transparent;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.Red;
            this.btSair.Location = new System.Drawing.Point(1014, 781);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(83, 32);
            this.btSair.TabIndex = 9;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(474, 761);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selecione a linha alterar os dados.";
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.Color.Black;
            this.btEditar.Location = new System.Drawing.Point(478, 786);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(140, 32);
            this.btEditar.TabIndex = 7;
            this.btEditar.Text = "Alterar Dados";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(27, 781);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Deletar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 761);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Selecione a linha do Livro para deletar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::biblioteca.Properties.Resources.biblioteca_on_line;
            this.pictureBox1.Location = new System.Drawing.Point(942, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Controle_Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 825);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Controle_Biblioteca";
            this.Text = "Controle_Biblioteca";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlunosb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtAlunosb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.ComboBox cbBuscaB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.DataGridView dtLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}