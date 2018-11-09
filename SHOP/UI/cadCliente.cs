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
    public partial class cadCliente : Form
    {
        public cadCliente()
        {
            InitializeComponent();
        }

        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //combobox cidade
            int valor = Convert.ToInt16(cbEstado.SelectedValue);
            dalCidade cidade = new dalCidade();

            cbCidade.DataSource = cidade.listaCidades(valor);
            cbCidade.DisplayMember = "Nome";
            cbCidade.ValueMember = "CidadeId";
        }

        private void cadCliente_Load(object sender, EventArgs e)
        {
            dalSexo sexo = new dalSexo();
            dalEstado estado = new dalEstado();

            //combobox sexo
            cbSexo.DataSource = sexo.listaSexos();
            cbSexo.DisplayMember = "descricao";
            cbSexo.ValueMember = "idsexos";

            //combobox estado
            cbEstado.DataSource = estado.listaEstados();
            cbEstado.DisplayMember = "Sigla";
            cbEstado.ValueMember = "EstadoId";
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            dalCliente cliente = new dalCliente();            
            cliente.insereCliente(new Clientes(tbNome.Text, tbEndereco.Text, tbBairro.Text, tbNumero.Text, tbCep.Text, Convert.ToInt32(cbEstado.SelectedValue), Convert.ToInt32(cbCidade.SelectedValue), tbTelefone.Text, Convert.ToChar(cbSexo.SelectedValue), tbEmail.Text, tbCpfcnpj.Text, rbAtivo.Checked));
        }
    }
}
