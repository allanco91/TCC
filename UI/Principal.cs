using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHOP.UI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadCliente abrir = new cadCliente();
            abrir.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadProduto abrir = new cadProduto();
            abrir.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadCategoria abrir = new cadCategoria();
            abrir.Show();
        }

        private void gerarPedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadPedido abrir = new cadPedido();
            abrir.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesCliente abrir = new pesCliente();
            abrir.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesProduto abrir = new pesProduto();
            abrir.Show();
        }

        private void statusDoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesCategoria abrir = new pesCategoria();
            abrir.Show();
        }

        private void imprimirPedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            modPedido abrir = new modPedido();
            abrir.Show();
        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pesPedido abrir = new pesPedido();
            abrir.Show();
        }

        private void andamentoDoPedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gerPedido abrir = new gerPedido();
            abrir.Show();
        }

        private void gerenciarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modCategoria abrir = new modCategoria();
            abrir.Show();
        }

        private void gerenciarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modProduto abrir = new modProduto();
            abrir.Show();
        }

        private void gerenciarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modCliente abrir = new modCliente();
            abrir.Show();
        }

        private void imprimirPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimirPedido abrir = new imprimirPedido();
            abrir.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pesCliente abrir = new pesCliente();
            abrir.lbProcura.Visible = false;
            abrir.lbRelatorio.Visible = true;
            abrir.gbRelatorio.Visible = true;
            abrir.Text = "Relatório de clientes";
            abrir.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pesProduto abrir = new pesProduto();
            abrir.lbProcura.Visible = false;
            abrir.lbRelatorio.Visible = true;
            abrir.gbRelatorio.Visible = true;
            abrir.Text = "Relatório de produtos";
            abrir.Show();
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pesCategoria abrir = new pesCategoria();
            abrir.lbProcura.Visible = false;
            abrir.lbRelatorio.Visible = true;
            abrir.gbRelatorio.Visible = true;
            abrir.Text = "Relatório de categorias";
            abrir.Show();
        }

        private void pedidosSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesPedido abrir = new pesPedido();
            abrir.lbProcura.Visible = false;
            abrir.lbRelatorio.Visible = true;
            abrir.gbRelatorio.Visible = true;
            abrir.Text = "Relatório de pedidos";
            abrir.Show();
        }

        private void pedidosCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relPedidoCompleto abrir = new relPedidoCompleto();
            abrir.Show();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
