using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class Emprestimo : Form
    {
        public Emprestimo()
        {
            InitializeComponent();
        }
        string dbcon = @"Data Source=dados.db;Version=3;";

        public void atualizaDataGridempres()
        {
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM usuarios", sqlcon);
            using (SQLiteDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    dtAlunosempres.Rows.Add(new object[] {
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



        public void atualizadatagridlivro()
        {
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM Livro", sqlcon);
            using (SQLiteDataReader read = com.ExecuteReader())
            {
                while (read.Read())
                {
                    dtLivrosempres.Rows.Add(new object[] {
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


        void cadastraremprestimo()
        {
            string id1 = dtAlunosempres.CurrentRow.Cells[0].Value.ToString();
            string id2 = dtLivrosempres.CurrentRow.Cells[0].Value.ToString();

            SQLiteConnection connection = new SQLiteConnection(dbcon);

            string verifica = "SELECT COUNT(*) FROM ALUGEL WHERE ELIVRO = @IDLIVRO AND (D_inicial BETWEEN @D_INICIAL AND @D_FINAL OR D_final BETWEEN @D_INICIAL AND @D_FINAL)";
            SQLiteCommand cmdVerifica = new SQLiteCommand(verifica, connection);
            //between compara intervalo de valores...., retorna true se o valor for verdadeiro.
            //count para analisar as datas, se caso o livro tiver emprestado naquela data especifica, ira retorna, que nao foi possivel.

            cmdVerifica.Parameters.Add(new SQLiteParameter("@IDLIVRO", id2));
            cmdVerifica.Parameters.Add(new SQLiteParameter("@D_INICIAL", dtInicial.Text));
            cmdVerifica.Parameters.Add(new SQLiteParameter("@D_FINAL", dtFInal.Text));

            connection.Open();

            int count = Convert.ToInt32(cmdVerifica.ExecuteScalar());

            if (count > 0)
            {
                lbSS.Visible = true;
                lbSS.ForeColor = Color.Red;
                lbSS.Text = "Livro já está emprestado nesta data";
                lbS.Visible = false;
            }
            else
            {
                string query = "INSERT INTO ALUGEL (EALUNO,ELIVRO, D_inicial, D_final) VALUES (@IDALUNO,@IDLIVRO,@D_inicial,@D_final)";
                SQLiteCommand com = new SQLiteCommand(query, connection);

                com.Parameters.Add(new SQLiteParameter("@IDALUNO", id1));
                com.Parameters.Add(new SQLiteParameter("@IDLIVRO", id2));
                com.Parameters.Add(new SQLiteParameter("@D_INICIAL", dtInicial.Text));
                com.Parameters.Add(new SQLiteParameter("@D_FINAL", dtFInal.Text));

                try
                {
                    com.ExecuteNonQuery();
                    lbSS.Visible = true;
                    lbSS.ForeColor = Color.Green;
                    lbSS.Text = "Alugado com sucesso";
                }
                catch (SqlException)
                {
                    lbSS.Visible = true;
                    lbSS.ForeColor = Color.Red;
                    lbSS.Text = "Erro ao alugar";

                    throw;
                }
            }

            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnempretimo_Click_1(object sender, EventArgs e)
        {
            cadastraremprestimo();
        }
    }
}
