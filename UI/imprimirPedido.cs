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
    public partial class imprimirPedido : Form
    {
        public imprimirPedido()
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

        private void imprimePedido(int cod)
        {
            dalPedido ped = new dalPedido();
            repwImprimePedido abrir = new repwImprimePedido();
            abrir.imprimePedidoBindingSource.DataSource = ped.sourceRelatorioPedido(cod);
            
            if (abrir.imprimePedidoBindingSource.Count > 0)
            {
                abrir.Show();
            }
            else 
            {
                MessageBox.Show("Pedido inexiste ou campos em branco","ERRO");
            }
        }

        private void tbNumeropedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(e);
            if (e.KeyChar == 13)
            {
                if ((tbNumeropedido.Text != "") && (tbNumeropedido.Text != null)) imprimePedido(Convert.ToInt32(tbNumeropedido.Text));
            }
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            if ((tbNumeropedido.Text != "") && (tbNumeropedido.Text != null)) imprimePedido(Convert.ToInt32(tbNumeropedido.Text));
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbNumeropedido.Text = "";
            tbNumeropedido.Select();
        }
    }
}
