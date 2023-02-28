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
    public partial class Alterar_Dados : Form
    {

        int id = 0;
        public Alterar_Dados(int id)
        {
            InitializeComponent();
            this.id = id;

            if (id > 0)
                getaluno(id);
        }
        string dbcon = @"Data Source=dados.db;Version=3;";

        void getaluno(int id)
        {
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);

            SQLiteCommand com = new SQLiteCommand("SELECT * FROM LIVRO WHERE ID_LIVRO=" + id, sqlcon);

            try
            {
                sqlcon.Open();

                using (SQLiteDataReader read = com.ExecuteReader())
                {
                    if (read.HasRows)
                    {
                        if (read.Read())
                        {
                            TxtNomeAlterar.Text = read[1].ToString();
                            TxtAutorAlterar.Text = read[2].ToString();
                            mkt_ano.Text = read[4].ToString();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void salvar()
        {
            var sql = "";

            if (this.id == 0)
            {
                sql = "INSERT INTO LIVRO (NOMELIVRO, NOMEAUTOR, DATE)VALUES(@NOME_LIVRO,@NOMEAUTOR,@ANO)";
            }
            else
            {
                sql = "UPDATE LIVRO SET NOMELIVRO=@NOME_LIVRO, NOMEAUTOR= @NOMEAUTOR , DATE= @ANO WHERE ID_LIVRO=" + this.id;
            }
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();

            using (SQLiteCommand cmd = new SQLiteCommand(sql, sqlcon))
            {

                cmd.Parameters.AddWithValue("@NOME_LIVRO", TxtNomeAlterar.Text);
                cmd.Parameters.AddWithValue("@NOMEAUTOR", TxtAutorAlterar.Text);
                cmd.Parameters.AddWithValue("@ANO", mkt_ano.Text);
                cmd.ExecuteNonQuery();


                lbS.Visible = true;
                lbS.ForeColor = Color.Green;
                lbS.Text = ("Dados alterados com sucesso...");
            }
        }

        private void BtAlterar_Click(object sender, EventArgs e)
        {
            salvar();
            this.Close();
        }
    }
}

