using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Apresentacao;
using AcessoDados;
using Negocio;
using ObjTransferencia;
using System.IO;

namespace Aplicacao
{
    public partial class frmLogin : Form
    {


        SqlConnection sqlConn = null;
        private string strCoon = @"Data Source=LUCAS-PC\SQLEXPRESS;Initial Catalog=midas;Integrated Security=True";
        private string _Sql = string.Empty;

        public bool Logado = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        public void logar()
        {
            sqlConn = new SqlConnection(strCoon);

            string usu, pwd;

            try
            {
                usu = cpoUsuario.Text;
                pwd = cpoSenha.Text;

                _Sql = "SELECT COUNT(IDUsuario) FROM  tblUsuario WHERE Nome = @Nome AND Senha = @Senha";

                SqlCommand cmd = new SqlCommand(_Sql, sqlConn);

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = usu;
                cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = pwd;

                sqlConn.Open();

                int v = (int)cmd.ExecuteScalar();

                if (v > 0)
                {
                    MessageBox.Show("Logado com Sucesso");
                    Logado = true;

                    this.Hide();

                    frmPrincipal FrmPrincipal = new frmPrincipal();
                    FrmPrincipal.Show();

                    
                }


                else
                {
                    MessageBox.Show("Dados Incorretos, verifique os dados por gentileza.");
                    Logado = false;

                }



            }
            catch (SqlException errro)
            {
                MessageBox.Show(errro + "No Banco");
            }


        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            

        }

        public void logar2()
        {

            SqlConnection cn = new SqlConnection(@"Data Source=LUCAS-PC\SQLEXPRESS;Initial Catalog=midas;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblUsuario WHERE Nome = @Nome AND Senha = @Senha", cn);
            //SELECT COUNT(IDUsuario) FROM  Usuario WHERE Nome = @Nome AND Senha = @Senha

            string senhalogado;


            senhalogado = getMD5Hash(cpoSenha.Text);
            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = cpoUsuario.Text;
            cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = senhalogado;
            cn.Open();
            SqlDataReader le = null;

            le = cmd.ExecuteReader();
            if (le.Read())
            {
                this.Hide();
                // usuariologado = cpoUsuario.Text;
                //senhalogado = cpoSenha.Text;


                frmPrincipal FrmPrincipal = new frmPrincipal();
                FrmPrincipal.Show();
            }
            else
            {

                MessageBox.Show("Usuário ou Senha estão incorretos!");
                cpoSenha.Clear();

                //return;



            }

        }

        public string getMD5Hash(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private void cpoSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                logar2();
            }

        }

        private void btnLogoff_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            logar();
        }

        private void cpoSenha_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)

                this.logar(); 
        }
    }
}

