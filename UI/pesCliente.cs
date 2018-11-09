using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SHOP.DAL;

namespace SHOP.UI
{
    public partial class pesCliente : Form
    {
        public pesCliente()
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

        private List<modpesq> tiposPesquisa()
        {
            List<modpesq> tipoList = new List<modpesq>();
            tipoList.Add(new modpesq(1, "Código"));
            tipoList.Add(new modpesq(2, "Nome"));
            tipoList.Add(new modpesq(3, "Endereço, Cidade e Estado"));
            tipoList.Add(new modpesq(4, "Cidade e Estado"));
            tipoList.Add(new modpesq(5, "Estado"));
            tipoList.Add(new modpesq(6, "CEP"));
            tipoList.Add(new modpesq(7, "Telefone"));
            tipoList.Add(new modpesq(8, "Sexo/Tipo"));
            tipoList.Add(new modpesq(9, "E-mail"));
            tipoList.Add(new modpesq(10, "CPF/CNPJ"));
            tipoList.Add(new modpesq(11, "Status"));
            return tipoList.ToList();
        }

        private void pesCliente_Load(object sender, EventArgs e)
        {            
            dalSexo sexo = new dalSexo();
            dalEstado estado = new dalEstado();

            //combobox pesquisarpor
            cbPesq.DataSource = tiposPesquisa();
            cbPesq.DisplayMember = "pesq";
            cbPesq.ValueMember = "id";

            //combobox sexo
            cbSexo.DataSource = sexo.listaSexos();
            cbSexo.DisplayMember = "descricao";
            cbSexo.ValueMember = "idsexos";

            //combobox estado
            cbEstado.DataSource = estado.listaEstados();
            cbEstado.DisplayMember = "Sigla";
            cbEstado.ValueMember = "EstadoId";
        }

        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //combobox cidade
            if (Convert.ToInt32(cbPesq.SelectedValue) != 5)
            {
                int valor = Convert.ToInt16(cbEstado.SelectedValue);
                dalCidade cidade = new dalCidade();

                cbCidade.DataSource = cidade.listaCidades(valor);
                cbCidade.DisplayMember = "Nome";
                cbCidade.ValueMember = "CidadeId";
                cbCidade.Enabled = true;
            }
        }

        private void cbPesq_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(cbPesq.SelectedValue);
            
            if ((i == 1) || (i == 2) || (i == 6) || (i == 7) || (i == 9) || (i == 10))
            {
                tbPalavraChave.Enabled = true;
                cbCidade.Enabled = false;
                cbEstado.Enabled = false;
                cbSexo.Enabled = false;
            }
            else if (i == 3)
            {
                tbPalavraChave.Enabled = true;
                cbCidade.Enabled = true;
                cbEstado.Enabled = true;
                cbSexo.Enabled = false;
            }
            else if (i == 4)
            {
                tbPalavraChave.Enabled = false;
                cbCidade.Enabled = true;
                cbEstado.Enabled = true;
                cbSexo.Enabled = false;
            }
            else if (i == 5)
            {
                tbPalavraChave.Enabled = false;
                cbCidade.Enabled = false;
                cbEstado.Enabled = true;
                cbSexo.Enabled = false;
            }
            else if (i == 8)
            {
                tbPalavraChave.Enabled = false;
                cbCidade.Enabled = false;
                cbEstado.Enabled = false;
                cbSexo.Enabled = true;
            }
            else if (i == 11)
            {
                tbPalavraChave.Enabled = false;
                cbCidade.Enabled = false;
                cbEstado.Enabled = false;
                cbSexo.Enabled = false;
            }
        }

        private void carregaConsulta()
        {
            dalCliente cli = new dalCliente();
            int i = Convert.ToInt32(cbPesq.SelectedValue);

            if (i == 1)
            {
                if ((tbPalavraChave.Text != "") && (tbPalavraChave.Text != null) && (verifNumero(tbPalavraChave.Text)))
                    dgvPesquisa.DataSource = cli.pesqClienteCODIGO(Convert.ToInt32(tbPalavraChave.Text), rbAtivo.Checked);
            }
            else if (i == 2)
                dgvPesquisa.DataSource = cli.pesqClienteNOME(tbPalavraChave.Text, rbAtivo.Checked);
            else if (i == 3)
                dgvPesquisa.DataSource = cli.pesqClienteENDCIDUF(tbPalavraChave.Text, Convert.ToInt32(cbCidade.SelectedValue), Convert.ToInt32(cbEstado.SelectedValue), rbAtivo.Checked);
            else if (i == 4)
                dgvPesquisa.DataSource = cli.pesqClienteCIDUF(Convert.ToInt32(cbCidade.SelectedValue), Convert.ToInt32(cbEstado.SelectedValue), rbAtivo.Checked);
            else if (i == 5)
                dgvPesquisa.DataSource = cli.pesqClienteUF(Convert.ToInt32(cbEstado.SelectedValue), rbAtivo.Checked);
            else if (i == 6)
                dgvPesquisa.DataSource = cli.pesqClienteCEP(tbPalavraChave.Text, rbAtivo.Checked);
            else if (i == 7)
                dgvPesquisa.DataSource = cli.pesqClienteTELEFONE(tbPalavraChave.Text, rbAtivo.Checked);
            else if (i == 8)
                dgvPesquisa.DataSource = cli.pesqClienteSEXOTIPO(Convert.ToChar(cbSexo.SelectedValue), rbAtivo.Checked);
            else if (i == 9)
                dgvPesquisa.DataSource = cli.pesqClienteEMAIL(tbPalavraChave.Text, rbAtivo.Checked);
            else if (i == 10)
                dgvPesquisa.DataSource = cli.pesqClienteCPFCNPJ(tbPalavraChave.Text, rbAtivo.Checked);
            else if (i == 11)
                dgvPesquisa.DataSource = cli.pesqClienteSTATUS(rbAtivo.Checked);

            if (dgvPesquisa.DataSource != null)
            {
                dgvPesquisa.Columns[0].HeaderText = "Código";
                dgvPesquisa.Columns[0].Width = 70;
                dgvPesquisa.Columns[1].HeaderText = "Nome";
                dgvPesquisa.Columns[2].HeaderText = "Endereço";
                dgvPesquisa.Columns[3].HeaderText = "Bairro";
                dgvPesquisa.Columns[3].Width = 70;
                dgvPesquisa.Columns[4].HeaderText = "Número";
                dgvPesquisa.Columns[4].Width = 70;
                dgvPesquisa.Columns[5].HeaderText = "CEP";
                dgvPesquisa.Columns[5].Width = 70;
                dgvPesquisa.Columns[6].HeaderText = "UF";
                dgvPesquisa.Columns[6].Width = 30;
                dgvPesquisa.Columns[7].HeaderText = "Cidade";
                dgvPesquisa.Columns[8].HeaderText = "Telefone";
                dgvPesquisa.Columns[9].HeaderText = "Sexo/Tipo";
                dgvPesquisa.Columns[9].Width = 70;
                dgvPesquisa.Columns[10].HeaderText = "E-mail";
                dgvPesquisa.Columns[10].Width = 130;
                dgvPesquisa.Columns[11].HeaderText = "CPF/CNPJ";
                dgvPesquisa.Columns[12].HeaderText = "Status";
                dgvPesquisa.Columns[12].Width = 50;
            }
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            carregaConsulta();
        }

        private void tbPalavraChave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) carregaConsulta();
        }

        private bool verifNumero(string num)
        {
            Regex rx = new Regex(@"^\d+$");
            return rx.IsMatch(num);
        }

        private void imprimePedido()
        {
            dalCliente cli = new dalCliente();
            
            if (rbSimples.Checked)
            {
                repwClienteSimples abrir = new repwClienteSimples();

                if (dgvPesquisa.RowCount > 0)
                {
                    abrir.relatorioClienteBindingSource.DataSource = dgvPesquisa.DataSource;
                    abrir.Show();
                }
                else MessageBox.Show("Não há dados para imprimir", "ERRO");
            }
            else if (rbCompleto.Checked)
            {
                repwClienteCompleto abrir = new repwClienteCompleto();

                if (dgvPesquisa.RowCount > 0)
                {
                    abrir.mostraClienteBindingSource.DataSource = dgvPesquisa.DataSource;
                    abrir.Show();
                }
                else MessageBox.Show("Não há dados para imprimir", "ERRO");
            }
        }
        
        private void btImprimir_Click(object sender, EventArgs e)
        {
            imprimePedido();
        }
    }
}