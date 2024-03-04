using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace injection_modelo
{
    public partial class FormLogin : Form
    {
        private void ValidaAcesso_ok()
        {
            MySqlConnection conn = null;
            try
            {
                string msql = "SERVER=localhost; UID=root; PWD=wvm15759535; DATABASE=db_teste_injection; PORT=3306;";

                conn = new MySqlConnection(msql);
                conn.Open();

                msql = "SELECT id,nome,senha from usuario where nome=@nome and senha=@senha";

                using (MySqlCommand cmd = new MySqlCommand(msql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", textUsuario.Text);
                    cmd.Parameters.AddWithValue("@senha", textSenha.Text);
                    MySqlDataReader mdr = null;
                    try
                    {

                        mdr = cmd.ExecuteReader();

                        if (mdr.Read())
                        {
                            MDIMenu menu = new MDIMenu();
                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha invalida");
                            return;
                        }
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message);
                    }
                    finally
                    {

                        if (!mdr.IsClosed)
                        {
                            mdr.Close();
                        }
                    }

                }



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void ValidaAcesso()
        {
            MySqlConnection conn = null;
            try
            {
                string msql = "SERVER=localhost; UID=root; PWD=wvm15759535; DATABASE=db_teste_injection; PORT=3306;";

                conn = new MySqlConnection(msql);
                conn.Open();

                msql = string.Format("SELECT id,nome,senha from usuario where nome={0} and senha={1}","'" + textUsuario.Text + "'", "'" + textSenha.Text + "'");

                using (MySqlCommand cmd = new MySqlCommand(msql, conn))
                {

                    MySqlDataReader mdr = null;
                    try
                    {

                        mdr = cmd.ExecuteReader();

                        if (mdr.Read())
                        {
                            MDIMenu menu = new MDIMenu();
                            menu.Show();
                            this.Hide();
                        }
                        else{
                            MessageBox.Show("Usuário ou senha invalida");
                            return;
                        }
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message);
                    }
                    finally {
          
                        if (!mdr.IsClosed)
                        {
                            mdr.Close(); 
                        }
                    }

                }

                

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                textSenha.Select();
            }
        }


        private void buttonEntrarErr_Click(object sender, EventArgs e)
        {
            ValidaAcesso();
        }

        private void buttonEntrarOk_Click(object sender, EventArgs e)
        {
            ValidaAcesso_ok();
        }
    }
}
