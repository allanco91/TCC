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
    public partial class cadProduto : Form
    {
        public cadProduto()
        {
            InitializeComponent();
        }

        private void tbValor_Leave(object sender, EventArgs e)
        {
            if (tbValorVenda.Text != "")
                tbValorVenda.Text = Decimal.Parse(tbValorVenda.Text).ToString("N2");         
        }

        private void cadProduto_Load(object sender, EventArgs e)
        {
            dalCategoria categoria = new dalCategoria();

            //combobox categoria
            cbCategoria.DataSource = categoria.listaCategorias();
            cbCategoria.DisplayMember = "tipo";
            cbCategoria.ValueMember = "idcategorias";
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (valida()) cadastrarProduto();
            else MessageBox.Show("ERRO: Não foi possível cadastrar o produto, preencha todos os campos.", "ERRO");
        }

        private void cadastrarProduto()
        {
            try
            {
                dalProduto produto = new dalProduto();
                produto.insereProduto(new Produtos(tbNome.Text, Convert.ToInt32(cbCategoria.SelectedValue), tbMarca.Text, tbDescricao.Text, Convert.ToDecimal(tbValorCompra.Text), Convert.ToDecimal(tbValorVenda.Text), Convert.ToDecimal(tbSaldoEstoque.Text)));
                MessageBox.Show("Produto cadastrado com sucesso.","Cadastro de produtos");
                resetCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
        }

        public static void AllowNumber(object sender, KeyPressEventArgs e, char cSymbol)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != cSymbol)
            {
                e.Handled = true;
            }

            if (e.KeyChar == cSymbol && (sender as TextBox).Text.IndexOf(cSymbol) > -1)
            {
                e.Handled = true;
            }
        }

        private void valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(sender, e, ',');
        }

        private void resetCampos()
        {
            tbNome.Text = "";
            tbMarca.Text = "";
            cbCategoria.SelectedIndex = 0;
            tbValorCompra.Text = "";
            tbValorVenda.Text = "";
            tbSaldoEstoque.Text = "";
            tbDescricao.Text = "";

            tbNome.Select();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            resetCampos();
        }

        private bool valida()
        {
            if ((tbNome.Text != "") && (tbNome.Text != null) &&
                (tbMarca.Text != "") && (tbMarca.Text != null) &&
                (tbValorCompra.Text != "") && (tbValorCompra.Text != null) &&
                (tbValorVenda.Text != "") && (tbValorVenda.Text != null) &&
                (tbSaldoEstoque.Text != "") && (tbSaldoEstoque.Text != null) &&
                (tbDescricao.Text != "") && (tbDescricao.Text != null)) return true;
            else return false;
        }

        private void btGerenciar_Click(object sender, EventArgs e)
        {
            modProduto abrir = new modProduto();
            abrir.Show();
        }

        private void tbValorCompra_Leave(object sender, EventArgs e)
        {
            if (tbValorCompra.Text != "")
                tbValorCompra.Text = Decimal.Parse(tbValorCompra.Text).ToString("N2");
        }

        private void tbSaldoEstoque_Leave(object sender, EventArgs e)
        {
            if (tbSaldoEstoque.Text != "")
                tbSaldoEstoque.Text = Decimal.Parse(tbSaldoEstoque.Text).ToString("N2");
        }
    }
}
