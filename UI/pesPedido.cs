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
    public partial class pesPedido : Form
    {
        public pesPedido()
        {
            InitializeComponent();
        }

        private class modpesq
        {
            public int id { get; set; }
            public string pesq { get; set; }

            public modpesq(int id, string pesq)
            {
                this.id = id;
                this.pesq = pesq;
            }
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

        private List<modpesq> tiposPesquisa()
        {
            List<modpesq> tipoList = new List<modpesq>();
            tipoList.Add(new modpesq(1, "Código"));
            tipoList.Add(new modpesq(2, "Código cliente"));
            tipoList.Add(new modpesq(3, "Nome cliente"));
            tipoList.Add(new modpesq(4, "Data registro"));
            tipoList.Add(new modpesq(5, "Data liberação"));
            tipoList.Add(new modpesq(6, "Data entrega"));
            tipoList.Add(new modpesq(7, "Data pagamento"));
            tipoList.Add(new modpesq(8, "Pagamento"));
            tipoList.Add(new modpesq(9, "Status"));
            return tipoList.ToList();
        }

        private List<status> tipoStatus()
        {
            int i = Convert.ToInt32(cbPesq.SelectedValue);
            List<status> statusList = new List<status>();

            if ((i == 5) || (i == 7))
            {
                statusList.Add(new status(0, "Todos"));
                statusList.Add(new status(2, "Liberado"));
                statusList.Add(new status(3, "Entregue"));
                statusList.Add(new status(4, "Cancelado"));
                return statusList.ToList();
            }
            else if (i == 6)
            {
                statusList.Add(new status(0, "Todos"));
                statusList.Add(new status(3, "Entregue"));
                statusList.Add(new status(4, "Cancelado"));
                return statusList.ToList();
            }
            else
            {
                statusList.Add(new status(0, "Todos"));
                statusList.Add(new status(1, "Em Aberto"));
                statusList.Add(new status(2, "Liberado"));
                statusList.Add(new status(3, "Entregue"));
                statusList.Add(new status(4, "Cancelado"));
                return statusList.ToList();
            }
        }

        private void pesPedido_Load(object sender, EventArgs e)
        {
            //combobox pesquisarpor
            cbPesq.DataSource = tiposPesquisa();
            cbPesq.DisplayMember = "pesq";
            cbPesq.ValueMember = "id";

            //combobox status
            cbStatus.DataSource = tipoStatus();
            cbStatus.DisplayMember = "stat";
            cbStatus.ValueMember = "id";
        }

        private void cbPesq_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(cbPesq.SelectedValue);

            if ((i == 1) || (i == 2) || (i == 3))
            {
                tbPalavraChave.Enabled = true;
                dtData.Enabled = false;
                rbPagTodos.Enabled = false;
                rbPagAberto.Enabled = false;
                rbPagEfetuado.Enabled = false;
                cbStatus.Enabled = true;
                cbStatus.DataSource = tipoStatus();
            }
            else if ((i == 4) || (i == 5) || (i == 6) || (i == 7))
            {
                tbPalavraChave.Enabled = false;
                dtData.Enabled = true;
                rbPagTodos.Enabled = false;
                rbPagAberto.Enabled = false;
                rbPagEfetuado.Enabled = false;
                cbStatus.Enabled = true;
                cbStatus.DataSource = tipoStatus();
            }
            else if (i == 8)
            {
                tbPalavraChave.Enabled = false;
                dtData.Enabled = false;
                rbPagTodos.Enabled = true;
                rbPagAberto.Enabled = true;
                rbPagEfetuado.Enabled = true;
                cbStatus.Enabled = false;
            }
            else
            {
                tbPalavraChave.Enabled = false;
                dtData.Enabled = false;
                rbPagTodos.Enabled = false;
                rbPagAberto.Enabled = false;
                rbPagEfetuado.Enabled = false;
                cbStatus.Enabled = true;
                cbStatus.DataSource = tipoStatus();
            }
        }

        private void carregaConsulta()
        {
            dalPedido ped = new dalPedido();
            int i = Convert.ToInt32(cbPesq.SelectedValue);

            if (i == 1)
            {
                if ((tbPalavraChave.Text != "") && (tbPalavraChave.Text != null))
                    dgvPesquisa.DataSource = ped.pesqPedidoCODIGO(Convert.ToInt32(tbPalavraChave.Text), Convert.ToInt32(cbStatus.SelectedValue));
            }
            else if (i == 2)
            {
                if ((tbPalavraChave.Text != "") && (tbPalavraChave.Text != null))
                    dgvPesquisa.DataSource = ped.pesqPedidoCODCLIENTE(Convert.ToInt32(tbPalavraChave.Text), Convert.ToInt32(cbStatus.SelectedValue));
            }
            else if (i == 3) dgvPesquisa.DataSource = ped.pesqPedidoCLIENTE(tbPalavraChave.Text, Convert.ToInt32(cbStatus.SelectedValue));
            else if (i == 4) dgvPesquisa.DataSource = ped.pesqPedidoDATA(dtData.Value.Date, Convert.ToInt32(cbStatus.SelectedValue));
            else if (i == 5) dgvPesquisa.DataSource = ped.pesqPedidoDATALIB(dtData.Value.Date, Convert.ToInt32(cbStatus.SelectedValue));
            else if (i == 6) dgvPesquisa.DataSource = ped.pesqPedidoDATAENTR(dtData.Value.Date, Convert.ToInt32(cbStatus.SelectedValue));
            else if (i == 7) dgvPesquisa.DataSource = ped.pesqPedidoDATAPAG(dtData.Value.Date, Convert.ToInt32(cbStatus.SelectedValue));
            else if (i == 8)
            {
                if (rbPagTodos.Checked) dgvPesquisa.DataSource = ped.pesqPedidoPAGAMENTO(0);
                else if (rbPagAberto.Checked) dgvPesquisa.DataSource = ped.pesqPedidoPAGAMENTO(1);
                else if (rbPagEfetuado.Checked) dgvPesquisa.DataSource = ped.pesqPedidoPAGAMENTO(3);
            }
            else if (i == 9) dgvPesquisa.DataSource = ped.pesqPedidoSTATUS(Convert.ToInt32(cbStatus.SelectedValue));

            if (dgvPesquisa.DataSource != null)
            {
                dgvPesquisa.Columns[0].HeaderText = "Código";
                dgvPesquisa.Columns[0].Width = 70;
                dgvPesquisa.Columns[1].HeaderText = "Data registro";
                dgvPesquisa.Columns[2].HeaderText = "Nome cliente";
                dgvPesquisa.Columns[2].Width = 275;
                dgvPesquisa.Columns[3].HeaderText = "Valor";
                dgvPesquisa.Columns[3].Width = 150;
                dgvPesquisa.Columns[4].HeaderText = "Pagamento";
                dgvPesquisa.Columns[4].Width = 95;
                dgvPesquisa.Columns[5].HeaderText = "Status";
                dgvPesquisa.Columns[5].Width = 90;
            }
        }

        public static void AllowNumber(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Letras
                char.IsSymbol(e.KeyChar) || //Símbolos
                char.IsWhiteSpace(e.KeyChar) || //Espaço
                char.IsPunctuation(e.KeyChar)) //Pontuação
                e.Handled = true; //Não permitir            
        }

        private void tbPalavraChave_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i = Convert.ToInt32(cbPesq.SelectedValue);
            if ((i == 1) || (i == 2)) AllowNumber(e);

            if (e.KeyChar == 13) carregaConsulta();
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            carregaConsulta();
        }

        private void imprimePedido()
        {
            dalPedido ped = new dalPedido();

            repwPedidoSimples abrir = new repwPedidoSimples();

            if (dgvPesquisa.RowCount > 0)
            {
                abrir.pesqPedidoBindingSource.DataSource = dgvPesquisa.DataSource;
                abrir.Show();
            }
            else MessageBox.Show("Não há dados para imprimir", "ERRO");
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            imprimePedido();
        }
    }
}
