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
    public partial class conCliente : Form
    {
        public conCliente()
        {
            InitializeComponent();
        }

        private void teste()
        {
            dalCliente clientes = new dalCliente();
            var lala = from cli in clientes.listarClientesID(1)
                       select cli;

            tbCodigo.Text = lala.ElementAt(0).idclientes.ToString();
            tbNome.Text = lala.ElementAt(0).nome;
            tbEndereco.Text = lala.ElementAt(0).endereco;
            tbNumero.Text = lala.ElementAt(0).numero;
            tbBairro.Text = lala.ElementAt(0).bairro;
            tbCep.Text = lala.ElementAt(0).cep;
            cbEstado.SelectedValue = lala.ElementAt(0).uf;
            cbCidade.SelectedValue = lala.ElementAt(0).cidade;
            tbCpfcnpj.Text = lala.ElementAt(0).cpf_cnpj;
            cbSexo.SelectedValue = lala.ElementAt(0).sexo;
            if (lala.ElementAt(0).status) rbAtivo.Checked = true;
            else rbInativo.Checked = true;
            tbEmail.Text = lala.ElementAt(0).email;
            tbTelefone.Text = lala.ElementAt(0).telefone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dalCliente clientes = new dalCliente();
            dataGridView1.DataSource = clientes.listarClientes();

            dalSexo sexo = new dalSexo();
            dalEstado estado = new dalEstado();
            dalCidade cidade = new dalCidade();

            //combobox sexo
            cbSexo.DataSource = sexo.listaSexos();
            cbSexo.DisplayMember = "descricao";
            cbSexo.ValueMember = "idsexos";

            //combobox estado
            cbEstado.DataSource = estado.listaEstados();
            cbEstado.DisplayMember = "Sigla";
            cbEstado.ValueMember = "EstadoId";

            //combobx cidade
            cbCidade.DataSource = cidade.listaCidades();
            cbCidade.DisplayMember = "Nome";
            cbCidade.ValueMember = "CidadeId";

        }
    }
}
