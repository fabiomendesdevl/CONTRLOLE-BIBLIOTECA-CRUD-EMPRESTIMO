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
using System.Data.Common;

namespace biblioteca
{
    public partial class Form1 : Form
    {
        string dbcon = @"Data Source=dados.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btEntrar_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            string query = "SELECT * FROM usuarios WHERE usuario = @usuario AND senha = @senha AND tipo = @tipo";
            //string query = "SELECT(usuario AND senha AND tipo) AS usuariosTIPO FROM usuarios";
            SQLiteCommand com = new SQLiteCommand(query, sqlcon);
            com.Parameters.AddWithValue("@usuario", txUsuario.Text);
            com.Parameters.AddWithValue("@senha", txSenha.Text);
            com.Parameters.AddWithValue("@tipo", cbAut.Text);


            try
            {
                sqlcon.Open();
                SQLiteDataReader dr = com.ExecuteReader();
                int count = 0;

                while (dr.Read())
                {
                    count++;
                }

                if (count >= 1 && cbAut.Text == "Administrador" && cbAut.Text != "Aluno")
                {
                    Sistema m = new Sistema();
                    m.Show();
                    this.Hide();
                }

                else if (count >= 1 && cbAut.Text == "Aluno" && cbAut.Text != "Administrador")
                {
                    Emprestimo empres = new Emprestimo();
                    empres.atualizaDataGridempres();
                    empres.atualizadatagridlivro();
                    empres.Show();
                }
                else if (count < 1)
                {
                    txSenha.Clear();
                    txUsuario.Clear();
                    lbtexto.Visible = true;
                    lbtexto.Text = "Usuario ou senha incorreto...";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao logar: " + ex);
            }
            finally
            {
                if (sqlcon.State != ConnectionState.Closed)
                {
                    sqlcon.Close();
                }
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}