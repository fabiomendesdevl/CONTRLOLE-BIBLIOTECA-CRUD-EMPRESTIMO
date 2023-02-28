using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class Cadastro : Form
    {
        string dbcon = @"Data Source=dados.db;Version=3;";
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {

            {
                SQLiteConnection sqlcon = new SQLiteConnection(dbcon);

                string query = "INSERT INTO usuarios ( nome, cpf, estado, cidade, celular, matricula, semestre, usuario, senha, tipo ) VALUES ( @nome, @cpf, @estado, @cidade, @celular, @matricula, @semestre, @usuario, @senha, @tipo );";

                SQLiteCommand com = new SQLiteCommand(query, sqlcon);
                com.Parameters.Add(new SQLiteParameter("@nome", txNome.Text));
                com.Parameters.Add(new SQLiteParameter("@cpf", txCpf.Text));
                com.Parameters.Add(new SQLiteParameter("@estado", cbEstado.Text));
                com.Parameters.Add(new SQLiteParameter("@cidade", txCidade.Text));
                com.Parameters.Add(new SQLiteParameter("@celular", txCelular.Text));
                com.Parameters.Add(new SQLiteParameter("@matricula", txMatricula.Text));
                com.Parameters.Add(new SQLiteParameter("@semestre", cbSemestre.Text));
                com.Parameters.Add(new SQLiteParameter("@usuario", txUsuarios.Text));
                com.Parameters.Add(new SQLiteParameter("@senha", txSenha.Text));
                com.Parameters.Add(new SQLiteParameter("@tipo", cbAut.Text));
                try
                {
                    sqlcon.Open();
                    com.ExecuteNonQuery();

                    lbC.Visible = true;
                    lbC.ForeColor = Color.Green;
                    lbC.Text = "Cadastrado com Sucesso...";
                    //limpar...
                    txNome.Clear();
                    txCpf.Clear();
                    txCidade.Clear();
                    txCelular.Clear();
                    txMatricula.Clear();
                    txUsuarios.Clear();
                    txSenha.Clear();
                }
                catch (Exception)
                {
                    if (txNome.Text == "" || txCelular.Text == "" || 
                        txCidade.Text == "" || txCpf.Text == "" || 
                        txMatricula.Text == "" || txSenha.Text == "" || 
                        txUsuarios.Text == "" || cbAut.Text == "" || cbEstado.Text == "" || 
                        cbSemestre.Text == "")
                    {
                        lbC.Visible = true;
                        lbC.ForeColor = Color.Red;
                        lbC.Text = "Erro ao cadastrar... Preencha os dados corretamente";
                       
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
