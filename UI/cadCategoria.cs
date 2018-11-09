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
    public partial class cadCategoria : Form
    {
        public cadCategoria()
        {
            InitializeComponent();
        }

        #region CRUD/SHOW/COMANDOS
        private void cadastrarCategoria()
        {
            try
            {
                dalCategoria cat = new dalCategoria();
                cat.insereCategoria(new Categorias(tbTipo.Text, tbDescricao.Text));
                MessageBox.Show("Categoria cadastrada com sucesso.");
                resetCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.ToString());
            }
        }

        private void resetCampos()
        {
            tbTipo.Text = "";
            tbDescricao.Text = "";
            tbTipo.Select();
        }
        #endregion

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (valida()) cadastrarCategoria();
            else MessageBox.Show("ERRO: Não foi possível cadastrar, preencha todos os campos", "ERRO");
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            resetCampos();
        }

        private void btGerenciar_Click(object sender, EventArgs e)
        {
            modCategoria abrir = new modCategoria();
            abrir.Show();
        }

        private bool valida()
        {
            if ((tbTipo.Text != "") && (tbTipo.Text != null) && (tbDescricao.Text != "") && (tbDescricao.Text != null)) return true;
            else return false;
        }
    }
}
