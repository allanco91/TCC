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
    public partial class pesCategoria : Form
    {
        public pesCategoria()
        {
            InitializeComponent();
        }

        private void carregaConsulta()
        {
            dalCategoria cat = new dalCategoria();                        
            
            if (rbCodigo.Checked)
                dgvPesquisa.DataSource = cat.listaCategorias(Convert.ToInt32(tbPalavraChave.Text));
            else if (rbTipo.Checked)
                dgvPesquisa.DataSource = cat.listaCategorias(tbPalavraChave.Text);

            dgvPesquisa.Columns[0].HeaderText = "Código";
            dgvPesquisa.Columns[0].Width = 80;
            dgvPesquisa.Columns[1].HeaderText = "Tipo";
            dgvPesquisa.Columns[1].Width = 200;
            dgvPesquisa.Columns[2].HeaderText = "Descrição";
            dgvPesquisa.Columns[2].Width = 317;
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            carregaConsulta();
        }

        private void tbPalavraChave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                carregaConsulta();
            }
        }

        private void imprimeCategoria()
        {
            dalCategoria prod = new dalCategoria();

            repwCategoria abrir = new repwCategoria();

            if (dgvPesquisa.RowCount > 0)
            {
                abrir.CategoriasBindingSource.DataSource = dgvPesquisa.DataSource;
                abrir.Show();
            }
            else MessageBox.Show("Não há dados para imprimir", "ERRO");
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            imprimeCategoria();
        }
    }
}
