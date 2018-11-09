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
    public partial class modUsuario : Form
    {
        public modUsuario()
        {
            InitializeComponent();
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            pesUsuario abrir = new pesUsuario();
            abrir.Show();
        }

        private void ativaCampos()
        {
            tbCodigo.Enabled = false;
            tbLogin.Enabled = true;
            tbSenha.Enabled = true;
            rbAdmin.Enabled = true;
            rbOperador.Enabled = true;

            btAlterar.Enabled = true;
            btExcluir.Enabled = true;
        }

        private void resetCampos()
        {
            tbCodigo.Text = "";
            tbLogin.Text = "";
            tbSenha.Text = "";

            tbCodigo.Enabled = true;
            tbLogin.Enabled = false;
            tbSenha.Enabled = false;
            rbAdmin.Enabled = false;
            rbOperador.Enabled = false;

            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
            tbCodigo.Select();
        }

        private void achaUser(int cod)
        {
            try
            {
                dalUsuarios user = new dalUsuarios();
                usuario usuario = user.achaUsuarioID(cod);

                tbLogin.Text = usuario.login;
                tbSenha.Text = usuario.senha;
                if (usuario.admin) rbAdmin.Checked = true;
                else rbOperador.Checked = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void atualizaUser(int cod, string login, string senha, bool admin)
        {
            try
            {
                dalUsuarios user = new dalUsuarios();
                user.atualizaUsuario(new Usuarios(cod, login, senha, admin));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void excluiUser(int cod)
        {
            try
            {
                dalUsuarios user = new dalUsuarios();
                user.deletaUsuario(cod);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public static void AllowNumber(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Letras
                char.IsSymbol(e.KeyChar) || //Símbolos
                char.IsWhiteSpace(e.KeyChar) || //Espaço
                char.IsPunctuation(e.KeyChar)) //Pontuação
                e.Handled = true; //Não permitir            
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(e);
            if (e.KeyChar == 13)
            {
                achaUser(Convert.ToInt32(tbCodigo.Text));
                ativaCampos();
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja alterar o usuário?", "Confirmar alteração", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                atualizaUser(Convert.ToInt32(tbCodigo.Text), tbLogin.Text, tbSenha.Text, rbAdmin.Checked);
                resetCampos();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o usuário?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                excluiUser(Convert.ToInt32(tbCodigo.Text));
                resetCampos();
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            resetCampos();
        }
    }
}
