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
    public partial class relPedidoCompleto : Form
    {
        public relPedidoCompleto()
        {
            InitializeComponent();
        }

        private class status
        {
            public int id { get; set; }
            public string stat { get; set; }

            public status(int id, string stat)
            {
                this.id = id;
                this.stat = stat;
            }
        }
        private List<status> tipoStatus()
        {
            List<status> statusList = new List<status>();
            statusList.Add(new status(0, "Todos"));
            statusList.Add(new status(1, "Em Aberto"));
            statusList.Add(new status(2, "Liberado"));
            statusList.Add(new status(3, "Entregue"));
            statusList.Add(new status(4, "Cancelado"));
            return statusList.ToList();
        }

        private void relPedidoCompleto_Load(object sender, EventArgs e)
        {
            //combobox status
            cbStatus.DataSource = tipoStatus();
            cbStatus.DisplayMember = "stat";
            cbStatus.ValueMember = "id";
        }

        private void imprimePedidoCompleto(DateTime data1, DateTime data2, int status)
        {
            dalPedido ped = new dalPedido();
            repwPedidoCompleto abrir = new repwPedidoCompleto();
            abrir.imprimePedidoBindingSource.DataSource = ped.relatorioPedidoCompleto(data1, data2, status);

            if (abrir.imprimePedidoBindingSource.Count > 0)
            {
                abrir.Show();
            }
            else
            {
                MessageBox.Show("Pedido inexiste ou campos em branco", "ERRO");
            }
        }

        private void imprimePedidoSimples(DateTime data1, DateTime data2, int status)
        {
            dalPedido ped = new dalPedido();
            repwPedidoSimples abrir = new repwPedidoSimples();
            abrir.pesqPedidoBindingSource.DataSource = ped.relatorioPedidoSimples(data1, data2, status);

            if (abrir.pesqPedidoBindingSource.Count > 0)
            {
                abrir.Show();
            }
            else
            {
                MessageBox.Show("Pedido inexiste ou campos em branco", "ERRO");
            }
        }

        private void imprimePedidoSimplesT(DateTime data1, DateTime data2, int status)
        {
            dalPedido ped = new dalPedido();
            repwPedidoPorData abrir = new repwPedidoPorData();
            abrir.pesqPedidoBindingSource.DataSource = ped.relatorioPedidoSimples(data1, data2, status);

            if (abrir.pesqPedidoBindingSource.Count > 0)
            {
                abrir.Show();
            }
            else
            {
                MessageBox.Show("Pedido inexiste ou campos em branco", "ERRO");
            }
        }
        
        private void btImprimir_Click(object sender, EventArgs e)
        {
            imprimePedidoCompleto(dtDataInicial.Value.Date, dtDataFinal.Value.Date, Convert.ToInt32(cbStatus.SelectedValue));
        }

        private void btImprimirSimples_Click(object sender, EventArgs e)
        {
            if (rbNTotaliza.Checked) imprimePedidoSimples(dtDataInicial.Value.Date, dtDataFinal.Value.Date, Convert.ToInt32(cbStatus.SelectedValue));
            else imprimePedidoSimplesT(dtDataInicial.Value.Date, dtDataFinal.Value.Date, Convert.ToInt32(cbStatus.SelectedValue));
        }

        private void rbNTotaliza_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNTotaliza.Checked == false) btImprimirCompleto.Enabled = false;
        }

        private void rbTotalizar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTotalizar.Checked == false) btImprimirCompleto.Enabled = true;
        }
    }
}
