using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;

namespace biblioteca
{
    public partial class Controle_Biblioteca : Form
    {
        string dbcon = @"Data Source=dados.db;Version=3;";
        public Controle_Biblioteca()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            this.dtLivros.Rows.Clear();
            ///////////////////////////
            this.dtAlunosb.Rows.Clear();
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            try
            {
                if (cbBuscaB.Text == "Alunos")
                {
                    //FORMAS DE BUSCA
                    string sqlbusca = "SELECT * FROM usuarios";
                    sqlbusca += " WHERE nome LIKE @buscar";
                    sqlbusca += " OR cpf LIKE @buscar";
                    sqlbusca += " OR celular LIKE @buscar";
                    sqlbusca += " OR matricula LIKE @buscar";
                    sqlbusca += " OR usuario LIKE @buscar";

                    //PARA BUSCAR
                    string buscar = string.Format("%{0}%", txBuscar.Text);

                    SQLiteCommand com = new SQLiteCommand(sqlbusca, sqlcon);
                    com.Parameters.Add(new SQLiteParameter("@buscar", buscar));

                    using (SQLiteDataReader read = com.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            dtAlunosb.Rows.Add(new object[]
                            {
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
                else if (cbBuscaB.Text == "Livros")
                {
                    string sqlbusca2 = "SELECT * FROM Livro";
                    sqlbusca2 += " WHERE nomelivro LIKE @buscar";
                    sqlbusca2 += " OR nomeautor LIKE @buscar";
                    sqlbusca2 += " OR editora LIKE @buscar";
                    sqlbusca2 += " OR codigolivro LIKE @buscar";

                    string buscarl = string.Format("%{0}%", txBuscar.Text);
                    SQLiteCommand com1 = new SQLiteCommand(sqlbusca2, sqlcon);
                    com1.Parameters.Add(new SQLiteParameter("@buscar", buscarl));

                    using (SQLiteDataReader readl = com1.ExecuteReader())
                    {
                        while (readl.Read())
                        {
                            dtLivros.Rows.Add(new object[]
                            {
                                readl.GetValue(0),
                                readl.GetValue(readl.GetOrdinal("nomelivro")),
                                readl.GetValue(readl.GetOrdinal("nomeautor")),
                                readl.GetValue(readl.GetOrdinal("editora")),
                                readl.GetValue(readl.GetOrdinal("DATE")),
                                readl.GetValue(readl.GetOrdinal("codigolivro")),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de busca: " + ex.Message.ToString(), "Error Message : " + ex.Message.ToString()); ;
            }
            finally
            {
                sqlcon.Close();
            }

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dtAlunosb.SelectedRows.Count > 0)
            {
                SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
                sqlcon.Open();

                try
                {
                    int id = Convert.ToInt32(dtAlunosb.SelectedRows[0].Cells["id"].Value);
                    string sql = "delete from usuarios where id = @id";
                    SQLiteCommand com = new SQLiteCommand(sql, sqlcon);
                    com.Parameters.Add(new SQLiteParameter("id", id));

                    com.ExecuteNonQuery();

                    dtAlunosb.Rows.Remove(dtAlunosb.SelectedRows[0]);
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



        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dtLivros.SelectedRows.Count > 0)
            {
                var id = Convert.ToInt32(dtLivros.Rows[dtLivros.CurrentCell.RowIndex].Cells[0].Value);
                Alterar_Dados a1 = new Alterar_Dados(id);
                a1.Show();
            }
            else
            {
                MessageBox.Show("Selecione uma linha...");
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtLivros.SelectedRows.Count > 0)
            {
                SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
                sqlcon.Open();

                try
                {
                    int id_livro = Convert.ToInt32(dtLivros.SelectedRows[0].Cells["id_livro"].Value);
                    string sql = "delete from Livro where id_livro = @id_livro";
                    SQLiteCommand com = new SQLiteCommand(sql, sqlcon);
                    com.Parameters.Add(new SQLiteParameter("id_livro", id_livro));

                    com.ExecuteNonQuery();

                    dtLivros.Rows.Remove(dtLivros.SelectedRows[0]);
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