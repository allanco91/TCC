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
    public partial class pesProduto : Form
    {
        public pesProduto()
        {
            InitializeComponent();
        }

        private void carregaConsulta()
        {
            dalProduto pro = new dalProduto();

            if (rbCodigo.Checked)
            {
                if ((tbPalavraChave.Text != "") && (tbPalavraChave.Text != null))
                    dgvPesquisa.DataSource = pro.listarProdutosC(Convert.ToInt32(tbPalavraChave.Text));
            }
            else if (rbNome.Checked)
                dgvPesquisa.DataSource = pro.listarProdutosN(tbPalavraChave.Text);
            else if (rbMarca.Checked)
                dgvPesquisa.DataSource = pro.listarProdutosM(tbPalavraChave.Text);
            else if (rbCategoria.Checked)
                dgvPesquisa.DataSource = pro.listarProdutosCA(Convert.ToInt32(cbCategoria.SelectedValue));
            if (rbEstoque.Checked)
            {
                if ((tbPalavraChave.Text != "") && (tbPalavraChave.Text != null))
                    dgvPesquisa.DataSource = pro.listarProdutosE(Convert.ToInt32(tbPalavraChave.Text));
            }

            if (dgvPesquisa.DataSource != null)
            {
                dgvPesquisa.Columns[0].HeaderText = "Código";
                dgvPesquisa.Columns[0].Width = 80;
                dgvPesquisa.Columns[1].HeaderText = "Nome";
                dgvPesquisa.Columns[1].Width = 233;
                dgvPesquisa.Columns[2].HeaderText = "Marca";
                dgvPesquisa.Columns[2].Width = 130;
                dgvPesquisa.Columns[3].HeaderText = "Categoria";
                dgvPesquisa.Columns[3].Width = 130;
                dgvPesquisa.Columns[4].HeaderText = "Valor de venda";
                dgvPesquisa.Columns[4].Width = 110;
                dgvPesquisa.Columns[5].HeaderText = "Saldo estoque";
                dgvPesquisa.Columns[5].Width = 100;
            }
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            carregaConsulta();
        }

        private void pesProduto_Load(object sender, EventArgs e)
        {
            cbCategoria.Enabled = false;
            
            dalCategoria categoria = new dalCategoria();

            //combobox categoria
            cbCategoria.DataSource = categoria.listaCategorias();
            cbCategoria.DisplayMember = "tipo";
            cbCategoria.ValueMember = "idcategorias";
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            tbPalavraChave.Enabled = true;
            cbCategoria.Enabled = false;
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            tbPalavraChave.Enabled = true;
            cbCategoria.Enabled = false;
        }

        private void rbMarca_CheckedChanged(object sender, EventArgs e)
        {
            tbPalavraChave.Enabled = true;
            cbCategoria.Enabled = false;
        }

        private void rbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            tbPalavraChave.Enabled = false;
            cbCategoria.Enabled = true;
        }

        private void tbPalavraChave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) carregaConsulta();
        }

        private void cbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) carregaConsulta();
        }

        private void imprimeProduto()
        {
            dalProduto prod = new dalProduto();

            repwProduto abrir = new repwProduto();

            if (dgvPesquisa.RowCount > 0)
            {
                abrir.consultaProdutoBindingSource.DataSource = dgvPesquisa.DataSource;
                abrir.Show();
            }
            else MessageBox.Show("Não há dados para imprimir", "ERRO");
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            imprimeProduto();
        }

        private void rbEstoque_CheckedChanged(object sender, EventArgs e)
        {
            tbPalavraChave.Enabled = true;
            cbCategoria.Enabled = false;
        }
    }
}
