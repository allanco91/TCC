using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SHOP.DAL;

namespace SHOP.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void logar(string login, string senha)
        {
            dalUsuarios user = new dalUsuarios();
            
            if (user.logar(login, senha) == 1)
            {
                Principal abrir = new Principal();
                abrir.Show();
                this.Visible = false;
            }
            else if (user.logar(login, senha) == 2)
            {
                PrincipalAdmin abrir = new PrincipalAdmin();
                abrir.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logar(tbLogin.Text, tbSenha.Text);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) logar(tbLogin.Text, tbSenha.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) tbSenha.Select();
        }
    }
}
