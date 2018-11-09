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
    public partial class pesUsuario : Form
    {
        public pesUsuario()
        {
            InitializeComponent();
        }
        
        public static void AllowNumber(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Letras
                char.IsSymbol(e.KeyChar) || //Símbolos
                char.IsWhiteSpace(e.KeyChar) || //Espaço
                char.IsPunctuation(e.KeyChar)) //Pontuação
                e.Handled = true; //Não permitir            
        }

        private void tbPalavraChave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbCodigo.Checked) AllowNumber(e);
            if (e.KeyChar == 13) carregaConsulta();
        }

        private void carregaConsulta()
        {
            dalUsuarios user = new dalUsuarios();

            if (rbCodigo.Checked)
            {
                if ((tbPalavraChave.Text != "") && (tbPalavraChave.Text != null))
                    dgvPesquisa.DataSource = user.listaUsuario(Convert.ToInt32(tbPalavraChave.Text));
            }
            else if (rbLogin.Checked)
                dgvPesquisa.DataSource = user.listaUsuario(tbPalavraChave.Text);

            dgvPesquisa.Columns[0].HeaderText = "Código";
            dgvPesquisa.Columns[0].Width = 80;
            dgvPesquisa.Columns[1].HeaderText = "Login";
            dgvPesquisa.Columns[1].Width = 400;
            dgvPesquisa.Columns[2].HeaderText = "Tipo";
            dgvPesquisa.Columns[2].Width = 117;
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            carregaConsulta();
        }
    }
}
