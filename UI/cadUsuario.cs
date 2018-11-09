using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SHOP.DAL;
using SHOP.Model;

namespace SHOP.UI
{
    public partial class cadUsuario : Form
    {
        public cadUsuario()
        {
            InitializeComponent();
        }

        private bool valida()
        {
            if ((!tbLogin.Text.Equals("")) && (!tbSenha.Text.Equals(""))) return true;
            else return false;
        }

        private void resetCampos()
        {
            tbLogin.Text = "";
            tbSenha.Text = "";
            tbLogin.Select();
        }

        private void cadastrarUsuario(string login, string senha, bool admin)
        {
            try
            {
                dalUsuarios usuario = new dalUsuarios();
                if (valida()) usuario.insereUsuario(new Usuarios(login, senha, admin));
                else MessageBox.Show("Favor preencher todos os campos", "ERRO");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarUsuario(tbLogin.Text, tbSenha.Text, rbAdmin.Checked);
            resetCampos();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            resetCampos();
        }

        private void btGerenciar_Click(object sender, EventArgs e)
        {
            modUsuario abrir = new modUsuario();
            abrir.Show();
        }
    }
}
