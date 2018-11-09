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
    public partial class formMostra : Form
    {
        public formMostra()
        {
            InitializeComponent();
        }

        private void formMostra_Load(object sender, EventArgs e)
        {
            dalPedido ped = new dalPedido();
            dalItensPedido itens = new dalItensPedido();

            dataGridView1.DataSource = ped.listaPedidos();
            dataGridView2.DataSource = itens.listaItensPedido();
        }
    }
}
