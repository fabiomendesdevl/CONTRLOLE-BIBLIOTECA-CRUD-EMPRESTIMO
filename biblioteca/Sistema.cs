using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;

namespace biblioteca
{
    public partial class Sistema : Form
    {
        string dbcon = @"Data Source=dados.db;Version=3;";

        public Sistema()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }
        private void Sistema_Load(object sender, EventArgs e)
        {
            dtAlunoGrid();
            dtLivrosGrid();
            dtAluguelGrid();
        }

        private void cadastroAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro C = new Cadastro();
            C.ShowDialog();
        }
        private void dtAlunoGrid()
        {
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM usuarios", sqlcon);
            using (SQLiteDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    dtAlunos.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(read.GetOrdinal("nome")),
                        read.GetValue(read.GetOrdinal("cpf")),
                        read.GetValue(read.GetOrdinal("estado")),
                        read.GetValue(read.GetOrdinal("cidade")),
                        read.GetValue(read.GetOrdinal("celular")),
                        read.GetValue(read.GetOrdinal("matricula")),
                        read.GetValue(read.GetOrdinal("semestre")),
                        read.GetValue(read.GetOrdinal("usuario")),
                        read.GetValue(read.GetOrdinal("senha")),
                        read.GetValue(read.GetOrdinal("tipo")),
                    });
                }
            }
        }
        private void dtLivrosGrid()
        {
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM Livro", sqlcon);
            using (SQLiteDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    dtLivros.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(read.GetOrdinal("nomelivro")),
                        read.GetValue(read.GetOrdinal("nomeautor")),
                        read.GetValue(read.GetOrdinal("editora")),
                        read.GetValue(read.GetOrdinal("DATE")),
                        read.GetValue(read.GetOrdinal("codigolivro")),
                    });
                }
            }
        }
        private void dtAluguelGrid()
        {
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT Alugel.id_alugel, usuarios.nome AS nomepessoa, Livro.nomelivro AS nomelivros, Alugel.D_inicial AS data_inicial, Alugel.D_final AS data_final FROM Alugel JOIN usuarios ON Alugel.ealuno = usuarios.id JOIN Livro ON Alugel.elivro = Livro.id_livro;", sqlcon);

            using (SQLiteDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    dtAluguel.Rows.Add(new object[] {
                    
                    read.GetValue(read.GetOrdinal("id_alugel")),
                    read.GetString(read.GetOrdinal("nomepessoa")),
                    read.GetString(read.GetOrdinal("nomelivros")),
                    read.GetString(read.GetOrdinal("data_inicial")),
                    read.GetString(read.GetOrdinal("data_final")),
                  });
                }
            }
        }
        private void btAtualizar_Click(object sender, EventArgs e)
        {
            this.dtAlunos.Rows.Clear();
            atualizaDataGrid();

            this.dtLivros.Rows.Clear();
            atualizadatagrid2();

            this.dtAluguel.Rows.Clear();
            atualizaDataGrid3();

        }
        private void atualizaDataGrid()
        {
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM usuarios", sqlcon);
            using (SQLiteDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    dtAlunos.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(read.GetOrdinal("nome")),
                        read.GetValue(read.GetOrdinal("cpf")),
                        read.GetValue(read.GetOrdinal("estado")),
                        read.GetValue(read.GetOrdinal("cidade")),
                        read.GetValue(read.GetOrdinal("celular")),
                        read.GetValue(read.GetOrdinal("matricula")),
                        read.GetValue(read.GetOrdinal("semestre")),
                        read.GetValue(read.GetOrdinal("usuario")),
                        read.GetValue(read.GetOrdinal("senha")),
                        read.GetValue(read.GetOrdinal("tipo")),
                    });
                }
            }
        }


        private void cadastroLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Livro CL = new Cadastro_Livro();
            CL.ShowDialog();
        }
        private void atualizadatagrid2()
        {
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM Livro", sqlcon);
            using (SQLiteDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    dtLivros.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(read.GetOrdinal("nomelivro")),
                        read.GetValue(read.GetOrdinal("nomeautor")),
                        read.GetValue(read.GetOrdinal("editora")),
                        read.GetValue(read.GetOrdinal("DATE")),
                        read.GetValue(read.GetOrdinal("codigolivro")),


                    });
                }
            }
        }
        private void atualizaDataGrid3() 
        {
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT Alugel.id_alugel, usuarios.nome AS nomepessoa, Livro.nomelivro AS nomelivros, Alugel.D_inicial AS data_inicial, Alugel.D_final AS data_final FROM Alugel JOIN usuarios ON Alugel.ealuno = usuarios.id JOIN Livro ON Alugel.elivro = Livro.id_livro;", sqlcon);

            using (SQLiteDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    dtAluguel.Rows.Add(new object[] {

                    read.GetValue(read.GetOrdinal("id_alugel")),
                    read.GetString(read.GetOrdinal("nomepessoa")),
                    read.GetString(read.GetOrdinal("nomelivros")),
                    read.GetString(read.GetOrdinal("data_inicial")),
                    read.GetString(read.GetOrdinal("data_final")),
                  });
                }
            }
        }

        private void buscaEditaExlcuiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controle_Biblioteca B = new Controle_Biblioteca();
            B.ShowDialog();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Emprestimo empres = new Emprestimo();
            empres.atualizaDataGridempres();
            empres.atualizadatagridlivro();
            empres.Show();
        }

        private void btdeletef_Click(object sender, EventArgs e)
        {
            if (dtAluguel.SelectedRows.Count > 0)
            {
                SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
                sqlcon.Open();

                try
                {
                    int IDs_Aluguel = Convert.ToInt32(dtAluguel.SelectedRows[0].Cells["IDs_Aluguel"].Value);
                    string sql = "delete from Alugel where id_alugel = @IDs_Aluguel";
                    SQLiteCommand com = new SQLiteCommand(sql, sqlcon);
                    com.Parameters.Add(new SQLiteParameter("IDs_Aluguel", IDs_Aluguel));

                    com.ExecuteNonQuery();

                    dtAluguel.Rows.Remove(dtAluguel.SelectedRows[0]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel deletar... " + ex.Message.ToString());
                }

                finally
                {
                    sqlcon.Close();
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha foi selecionada para deletar...");
            }
        }

    }
}