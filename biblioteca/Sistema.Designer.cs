namespace biblioteca
{
    partial class Sistema
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cadastroAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaEditaExlcuiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbAluno = new System.Windows.Forms.TabControl();
            this.tabAluno = new System.Windows.Forms.TabPage();
            this.dtAlunos = new System.Windows.Forms.DataGridView();
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
            this.tabLivros = new System.Windows.Forms.TabPage();
            this.dtLivros = new System.Windows.Forms.DataGridView();
            this.ID_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEmprestimos = new System.Windows.Forms.TabPage();
            this.dtAluguel = new System.Windows.Forms.DataGridView();
            this.IDs_Aluguel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDs_Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Livros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btdeletef = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            this.tbAluno.SuspendLayout();
            this.tabAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlunos)).BeginInit();
            this.tabLivros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLivros)).BeginInit();
            this.tabEmprestimos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAluguel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroAlunoToolStripMenuItem,
            this.cadastroLivroToolStripMenuItem,
            this.agendamentoToolStripMenuItem,
            this.buscaEditaExlcuiToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1079, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cadastroAlunoToolStripMenuItem
            // 
            this.cadastroAlunoToolStripMenuItem.Name = "cadastroAlunoToolStripMenuItem";
            this.cadastroAlunoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.cadastroAlunoToolStripMenuItem.Text = "Cadastro Aluno";
            this.cadastroAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastroAlunoToolStripMenuItem_Click);
            // 
            // cadastroLivroToolStripMenuItem
            // 
            this.cadastroLivroToolStripMenuItem.Name = "cadastroLivroToolStripMenuItem";
            this.cadastroLivroToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.cadastroLivroToolStripMenuItem.Text = "Cadastro Livro";
            this.cadastroLivroToolStripMenuItem.Click += new System.EventHandler(this.cadastroLivroToolStripMenuItem_Click);
            // 
            // agendamentoToolStripMenuItem
            // 
            this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.agendamentoToolStripMenuItem.Text = "Emprestimo";
            this.agendamentoToolStripMenuItem.Click += new System.EventHandler(this.agendamentoToolStripMenuItem_Click);
            // 
            // buscaEditaExlcuiToolStripMenuItem
            // 
            this.buscaEditaExlcuiToolStripMenuItem.Name = "buscaEditaExlcuiToolStripMenuItem";
            this.buscaEditaExlcuiToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.buscaEditaExlcuiToolStripMenuItem.Text = "Busca -  Edita - Exlcui";
            this.buscaEditaExlcuiToolStripMenuItem.Click += new System.EventHandler(this.buscaEditaExlcuiToolStripMenuItem_Click);
            // 
            // tbAluno
            // 
            this.tbAluno.Controls.Add(this.tabAluno);
            this.tbAluno.Controls.Add(this.tabLivros);
            this.tbAluno.Controls.Add(this.tabEmprestimos);
            this.tbAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAluno.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbAluno.Location = new System.Drawing.Point(12, 102);
            this.tbAluno.Name = "tbAluno";
            this.tbAluno.RightToLeftLayout = true;
            this.tbAluno.SelectedIndex = 0;
            this.tbAluno.Size = new System.Drawing.Size(1055, 291);
            this.tbAluno.TabIndex = 2;
            this.tbAluno.Tag = "";
            // 
            // tabAluno
            // 
            this.tabAluno.Controls.Add(this.dtAlunos);
            this.tabAluno.Location = new System.Drawing.Point(4, 29);
            this.tabAluno.Name = "tabAluno";
            this.tabAluno.Padding = new System.Windows.Forms.Padding(3);
            this.tabAluno.Size = new System.Drawing.Size(1047, 258);
            this.tabAluno.TabIndex = 1;
            this.tabAluno.Text = "Alunos";
            this.tabAluno.UseVisualStyleBackColor = true;
            // 
            // dtAlunos
            // 
            this.dtAlunos.AllowUserToDeleteRows = false;
            this.dtAlunos.AllowUserToOrderColumns = true;
            this.dtAlunos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dtAlunos.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtAlunos.Location = new System.Drawing.Point(-1, 0);
            this.dtAlunos.Name = "dtAlunos";
            this.dtAlunos.ReadOnly = true;
            this.dtAlunos.Size = new System.Drawing.Size(1048, 258);
            this.dtAlunos.TabIndex = 0;
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
            // tabLivros
            // 
            this.tabLivros.Controls.Add(this.dtLivros);
            this.tabLivros.Location = new System.Drawing.Point(4, 29);
            this.tabLivros.Name = "tabLivros";
            this.tabLivros.Size = new System.Drawing.Size(1047, 258);
            this.tabLivros.TabIndex = 2;
            this.tabLivros.Text = "Livros";
            this.tabLivros.UseVisualStyleBackColor = true;
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
            this.dtLivros.Location = new System.Drawing.Point(-1, 0);
            this.dtLivros.Name = "dtLivros";
            this.dtLivros.ReadOnly = true;
            this.dtLivros.Size = new System.Drawing.Size(1052, 258);
            this.dtLivros.TabIndex = 1;
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
            this.Nome_Livro.Width = 190;
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
            // tabEmprestimos
            // 
            this.tabEmprestimos.Controls.Add(this.dtAluguel);
            this.tabEmprestimos.Location = new System.Drawing.Point(4, 29);
            this.tabEmprestimos.Name = "tabEmprestimos";
            this.tabEmprestimos.Size = new System.Drawing.Size(1047, 258);
            this.tabEmprestimos.TabIndex = 3;
            this.tabEmprestimos.Text = "Emprestimos";
            this.tabEmprestimos.UseVisualStyleBackColor = true;
            // 
            // dtAluguel
            // 
            this.dtAluguel.AllowUserToDeleteRows = false;
            this.dtAluguel.AllowUserToOrderColumns = true;
            this.dtAluguel.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtAluguel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAluguel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDs_Aluguel,
            this.IDs_Aluno,
            this.Nome_Livros,
            this.Data_Inicial,
            this.Data_Final});
            this.dtAluguel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtAluguel.Location = new System.Drawing.Point(-3, 0);
            this.dtAluguel.Name = "dtAluguel";
            this.dtAluguel.ReadOnly = true;
            this.dtAluguel.Size = new System.Drawing.Size(1052, 258);
            this.dtAluguel.TabIndex = 2;
            // 
            // IDs_Aluguel
            // 
            this.IDs_Aluguel.HeaderText = "IDs_Aluguel";
            this.IDs_Aluguel.Name = "IDs_Aluguel";
            this.IDs_Aluguel.ReadOnly = true;
            this.IDs_Aluguel.Width = 200;
            // 
            // IDs_Aluno
            // 
            this.IDs_Aluno.HeaderText = "Nome_Alunos";
            this.IDs_Aluno.Name = "IDs_Aluno";
            this.IDs_Aluno.ReadOnly = true;
            this.IDs_Aluno.Width = 200;
            // 
            // Nome_Livros
            // 
            this.Nome_Livros.HeaderText = "Nome_Livros";
            this.Nome_Livros.Name = "Nome_Livros";
            this.Nome_Livros.ReadOnly = true;
            this.Nome_Livros.Width = 210;
            // 
            // Data_Inicial
            // 
            this.Data_Inicial.HeaderText = "Data_Inicial";
            this.Data_Inicial.Name = "Data_Inicial";
            this.Data_Inicial.ReadOnly = true;
            this.Data_Inicial.Width = 200;
            // 
            // Data_Final
            // 
            this.Data_Final.HeaderText = "Data_Final";
            this.Data_Final.Name = "Data_Final";
            this.Data_Final.ReadOnly = true;
            this.Data_Final.Width = 200;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.ForeColor = System.Drawing.Color.Green;
            this.btAtualizar.Location = new System.Drawing.Point(12, 399);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(98, 39);
            this.btAtualizar.TabIndex = 3;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.Red;
            this.btSair.Location = new System.Drawing.Point(969, 399);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(98, 39);
            this.btSair.TabIndex = 4;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btdeletef
            // 
            this.btdeletef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeletef.ForeColor = System.Drawing.Color.Fuchsia;
            this.btdeletef.Location = new System.Drawing.Point(422, 399);
            this.btdeletef.Name = "btdeletef";
            this.btdeletef.Size = new System.Drawing.Size(141, 39);
            this.btdeletef.TabIndex = 5;
            this.btdeletef.Text = "DEVOLVER LIVRO";
            this.btdeletef.UseVisualStyleBackColor = true;
            this.btdeletef.Click += new System.EventHandler(this.btdeletef_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::biblioteca.Properties.Resources.biblioteca_on_line;
            this.pictureBox1.Location = new System.Drawing.Point(924, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btdeletef);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.tbAluno);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Sistema";
            this.Text = "Sistema";
            this.Load += new System.EventHandler(this.Sistema_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tbAluno.ResumeLayout(false);
            this.tabAluno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtAlunos)).EndInit();
            this.tabLivros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtLivros)).EndInit();
            this.tabEmprestimos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtAluguel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cadastroAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
        private System.Windows.Forms.TabControl tbAluno;
        private System.Windows.Forms.TabPage tabAluno;
        private System.Windows.Forms.TabPage tabLivros;
        private System.Windows.Forms.TabPage tabEmprestimos;
        private System.Windows.Forms.DataGridView dtAlunos;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btSair;
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
        private System.Windows.Forms.DataGridView dtLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.ToolStripMenuItem buscaEditaExlcuiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtAluguel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDs_Aluguel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDs_Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Livros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Final;
        private System.Windows.Forms.Button btdeletef;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}