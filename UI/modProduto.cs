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
    public partial class modProduto : Form
    {
        public modProduto()
        {
            InitializeComponent();
        }

        private void modProduto_Load(object sender, EventArgs e)
        {
            dalCategoria categoria = new dalCategoria();

            //combobox categoria
            cbCategoria.DataSource = categoria.listaCategorias();
            cbCategoria.DisplayMember = "tipo";
            cbCategoria.ValueMember = "idcategorias";
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
                if ((tbCodigo.Text != "") && (tbCodigo.Text != null)) achaProduto(Convert.ToInt32(tbCodigo.Text));
        }

        private void achaProduto(int codigo)
        {
            dalProduto produto = new dalProduto();

            var result = from p in produto.listarProdutos(codigo)
                         select p;

            if (result.Count() > 0)
            {
                foreach (var pro in result)
                {
                    tbNome.Text = pro.nome;
                    tbMarca.Text = pro.marca;
                    cbCategoria.SelectedValue = pro.idcategoria;
                    tbValorCompra.Text = pro.valorcompra.ToString();
                    tbValorVenda.Text = pro.valorvenda.ToString();
                    tbSaldoEstoque.Text = pro.saldoestoque.ToString();
                    tbDescricao.Text = pro.descricao;

                    tbCodigo.Enabled = false;
                    tbNome.Enabled = true;
                    tbMarca.Enabled = true;
                    cbCategoria.Enabled = true;
                    tbValorCompra.Enabled = true;
                    tbValorVenda.Enabled = true;
                    tbSaldoEstoque.Enabled = true;
                    tbDescricao.Enabled = true;
                }
            }
            else MessageBox.Show("Nenhum produto encontrado");
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

        private void btLimpar_Click(object sender, EventArgs e)
        {
            resetCampos();
        }

        private void resetCampos()
        {
            tbCodigo.Text = "";
            tbCodigo.Enabled = true;
            tbNome.Enabled = false;
            tbNome.Text = "";
            tbMarca.Enabled = false;
            tbMarca.Text = "";
            cbCategoria.Enabled = false;
            cbCategoria.SelectedIndex = 0;
            tbValorVenda.Enabled = false;
            tbValorVenda.Text = "";
            tbValorCompra.Enabled = false;
            tbValorCompra.Text = "";
            tbSaldoEstoque.Enabled = false;
            tbSaldoEstoque.Text = "";
            tbDescricao.Enabled = false;
            tbDescricao.Text = "";

            tbCodigo.Select();
        }

        private void atualizaProduto()
        {
            dalProduto produto = new dalProduto();
            if (MessageBox.Show("Tem certeza que deseja atualizar o produto?", "Confirmar atualização", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {                
                produto.atualizaProduto(new Produtos(Convert.ToInt32(tbCodigo.Text), tbNome.Text, Convert.ToInt32(cbCategoria.SelectedValue), tbMarca.Text, tbDescricao.Text, Convert.ToDecimal(tbValorCompra.Text), Convert.ToDecimal(tbValorVenda.Text), Convert.ToDecimal(tbSaldoEstoque.Text)));
                resetCampos();
            }
        }

        private void excluiProduto()
        {
            dalProduto produto = new dalProduto();
            if (MessageBox.Show("Tem certeza que deseja excluir o produto?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                produto.deletaProduto(Convert.ToInt32(tbCodigo.Text));
                resetCampos();
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if ((tbCodigo.Enabled == false) && (valida())) atualizaProduto();
            else MessageBox.Show("ERRO: Selecione um produto para alterar/Preencha todos os campos.", "ERRO");
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Enabled == false) excluiProduto();
            else MessageBox.Show("Selecione um produto para excluir.", "ERRO");
        }

        private void tbValorVenda_Leave(object sender, EventArgs e)
        {
            if (tbValorVenda.Text != "")
                tbValorVenda.Text = Decimal.Parse(tbValorVenda.Text).ToString("N2");
        }
        
        private void tbValorCompra_Leave(object sender, EventArgs e)
        {
            if (tbValorCompra.Text != "")
                tbValorCompra.Text = Decimal.Parse(tbValorCompra.Text).ToString("N2");
        }

        private void btGerenciar_Click(object sender, EventArgs e)
        {
            pesProduto abrir = new pesProduto();
            abrir.Show();
        }

        private void tbSaldoEstoque_Leave(object sender, EventArgs e)
        {
            if (tbSaldoEstoque.Text != "")
                tbSaldoEstoque.Text = Decimal.Parse(tbSaldoEstoque.Text).ToString("N2");
        }
    }
}
