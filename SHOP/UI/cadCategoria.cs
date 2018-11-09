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

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarCategoria();
        }

        private void cadastrarCategoria()
        {
            try
            {
                dalCategoria cat = new dalCategoria();
                cat.insereCategoria(new Categorias(tbTipo.Text, tbDescricao.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.ToString());                
            }
        }

        private void atualizarCategoria()
        {
            try
            {
                dalCategoria cat = new dalCategoria();
                cat.atualizaCategoria(new Categorias(2, tbTipo.Text, tbDescricao.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.ToString());
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            atualizarCategoria();
        }

        private void carregaData()
        {
            dalCategoria cat = new dalCategoria();
            dataGridView1.DataSource = cat.listaCategorias();
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Tipo";
            dataGridView1.Columns[2].HeaderText = "Descrição";
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            carregaData();
        }
    }
}
