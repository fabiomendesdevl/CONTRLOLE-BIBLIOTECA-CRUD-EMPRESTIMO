using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace biblioteca
{
    public partial class Cadastro_Livro : Form
    {
        string dbcon = @"Data Source=dados.db;Version=3;";
        public Cadastro_Livro()
        {
            InitializeComponent();
        }

        private void btCadastroLivro_Click(object sender, EventArgs e)
        {

            {
                SQLiteConnection sqlcon = new SQLiteConnection(dbcon);

                string query = "INSERT INTO Livro ( nomelivro, nomeautor, editora, DATE, codigolivro ) VALUES ( @nomelivro, @nomeautor, @editora, @DATE, @codigolivro );";

                SQLiteCommand com = new SQLiteCommand(query, sqlcon);
                com.Parameters.Add(new SQLiteParameter("@nomelivro", txNome.Text));
                com.Parameters.Add(new SQLiteParameter("@nomeautor", txAutor.Text));
                com.Parameters.Add(new SQLiteParameter("@editora", txEditora.Text));
                com.Parameters.Add(new SQLiteParameter("@DATE", dtData.Text));
                com.Parameters.Add(new SQLiteParameter("@codigolivro", txCodigo.Text));

                try
                {
                    sqlcon.Open();
                    com.ExecuteNonQuery();

                    lbC.Visible = true;
                    lbC.ForeColor = Color.Green;
                    lbC.Text = "Cadastrado com Sucesso...";
                    //limpar...
                    txNome.Clear();
                    txAutor.Clear();
                    txEditora.Clear();
                    txCodigo.Clear();
                }
                catch (Exception)
                {
                    if (txNome.Text == "" || txAutor.Text == "" || txEditora.Text == "" || dtData.Text == "" || txCodigo.Text == "")
                    {
                        lbC.Visible = true;
                        lbC.ForeColor = Color.Red;
                        lbC.Text = "Erro ao cadastrar... Preencha os dados corretamente";
                        txNome.Clear();
                        txAutor.Clear();
                        txEditora.Clear();
                        txCodigo.Clear();
                    }
                }
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
