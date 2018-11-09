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
    public partial class modCliente : Form
    {
        public modCliente()
        {
            InitializeComponent();
        }


        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dalCidade cidade = new dalCidade();
            int valor = Convert.ToInt16(cbEstado.SelectedValue);
            cbCidade.DataSource = cidade.listaCidades(valor);
            cbCidade.Enabled = true;
        }

        private void modCliente_Load(object sender, EventArgs e)
        {
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

            //combobox cidade
            cbCidade.DataSource = cidade.listaCidades();
            cbCidade.DisplayMember = "Nome";
            cbCidade.ValueMember = "CidadeId";
        }

        private void maskCPFCNPJ()
        {
            if ((cbSexo.SelectedValue.ToString().Equals("F")) || (cbSexo.SelectedValue.ToString().Equals("M")))
            {
                tbCpfcnpj.Mask = "000,000,000-00";
            }
            else if (cbSexo.SelectedValue.ToString().Equals("E"))
            {
                tbCpfcnpj.Mask = "00,000,000/0000-00";
            }
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            maskCPFCNPJ();
        }

        public static void AllowNumber(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Letras
                char.IsSymbol(e.KeyChar) || //Símbolos
                char.IsWhiteSpace(e.KeyChar) || //Espaço
                char.IsPunctuation(e.KeyChar)) //Pontuação
                e.Handled = true; //Não permitir            
        }

        public void resetCampos()
        {
            tbCodigo.Text = "";
            tbCodigo.Enabled = true;
            tbNome.Text = "";
            tbNome.Enabled = false;
            tbEndereco.Text = "";
            tbEndereco.Enabled = false;
            tbNumero.Text = "";
            tbNumero.Enabled = false;
            tbBairro.Text = "";
            tbBairro.Enabled = false;
            tbCep.Text = "";
            tbCep.Enabled = false;
            cbEstado.SelectedIndex = 0;
            cbEstado.Enabled = false;
            cbCidade.SelectedIndex = 0;
            cbCidade.Enabled = false;
            tbCpfcnpj.Text = "";
            tbCpfcnpj.Enabled = false;
            cbSexo.SelectedIndex = 0;
            cbSexo.Enabled = false;
            rbAtivo.Checked = true;
            rbInativo.Checked = false;
            tbEmail.Text = "";
            tbEmail.Enabled = false;
            tbTelefone.Text = "";
            tbTelefone.Enabled = false;
            tbCodigo.Select();
        }

        //Função para validar Email
        public static bool validarEmail(string Email)
        {
            bool ValidEmail = false;
            int indexArr = Email.IndexOf("@");
            if (indexArr > 0)
            {
                int indexDot = Email.IndexOf(".", indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < Email.Length)
                    {
                        string indexDot2 = Email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            ValidEmail = true;
                        }
                    }
                }
            }
            return ValidEmail;
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (!validarEmail(tbEmail.Text))
            {
                MessageBox.Show("ERRO: Digite um e-mail válido.", "ERRO");
                tbEmail.Text = "";
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            resetCampos();
        }

        private void tbCpfcnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(e);
        }

        private void tbCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(e);
        }

        private void tbTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(e);
        }

        private bool valida()
        {
            if ((tbNome.Text != "") && (tbNome.Text != null)
                && (tbEndereco.Text != "") && (tbEndereco.Text != null)
                && (tbNumero.Text != "") && (tbNumero.Text != null)
                && (tbBairro.Text != "") && (tbBairro.Text != null)
                && (tbCpfcnpj.Text != "") && (tbCpfcnpj.Text != null)
                && (tbCep.Text != "") && (tbCep.Text != null)
                && (tbEmail.Text != "") && (tbEmail.Text != null)
                && (tbTelefone.Text != "") && (tbTelefone.Text != null))
                return true;
            else return false;
        }

        private void achaCliente(int codigo)
        {
            dalCliente cliente = new dalCliente();

            var result = from c in cliente.achaClienteId(codigo)
                         select c;

            if (result.Count() > 0)
            {
                foreach (var cli in result)
                {                    
                    tbNome.Text = cli.nome;
                    tbEndereco.Text = cli.endereco;
                    tbNumero.Text = cli.numero;
                    tbBairro.Text = cli.bairro;
                    tbCep.Text = cli.cep;
                    cbEstado.SelectedValue = cli.uf;
                    cbCidade.SelectedValue = cli.cidade;
                    tbCpfcnpj.Text = cli.cpf_cnpj;
                    cbSexo.SelectedValue = cli.sexo;
                    if (cli.status) rbAtivo.Checked = true;
                    else rbInativo.Checked = true;
                    tbEmail.Text = cli.email;
                    tbTelefone.Text = cli.telefone;

                    tbCodigo.Enabled = false;
                    tbNome.Enabled = true;
                    tbEndereco.Enabled = true;
                    tbNumero.Enabled = true;
                    tbBairro.Enabled = true;
                    tbCep.Enabled = true;
                    cbEstado.Enabled = true;
                    tbCpfcnpj.Enabled = true;
                    cbSexo.Enabled = true;
                    rbAtivo.Enabled = true;
                    rbInativo.Enabled = true;
                    tbEmail.Enabled = true;
                    tbTelefone.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Nenhum cliente encontrado","ERRO");
            }
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(e);

            if (e.KeyChar == 13)
                if ((tbCodigo.Text != "") && (tbCodigo.Text != null)) achaCliente(Convert.ToInt32(tbCodigo.Text));
        }

        private void atualizaCliente()
        {
            dalCliente cliente = new dalCliente();
            if (MessageBox.Show("Tem certeza que deseja atualizar o cliente?", "Confirmar atualização", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cliente.atualizaCliente(new Clientes(Convert.ToInt32(tbCodigo.Text),tbNome.Text, tbEndereco.Text, tbBairro.Text, tbNumero.Text, tbCep.Text, Convert.ToInt32(cbEstado.SelectedValue), Convert.ToInt32(cbCidade.SelectedValue), tbTelefone.Text, Convert.ToChar(cbSexo.SelectedValue), tbEmail.Text, tbCpfcnpj.Text, rbAtivo.Checked));
                resetCampos();
            }
        }

        private void excluiCliente()
        {
            dalCliente cliente = new dalCliente();
            if (MessageBox.Show("Tem certeza que deseja excluir o cliente?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cliente.deletaCliente(Convert.ToInt32(tbCodigo.Text));
                resetCampos();
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if ((tbCodigo.Enabled == false) && (valida())) atualizaCliente();
            else MessageBox.Show("ERRO: Selecione um cliente para alterar/Preencha todos os campos.", "ERRO");
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Enabled == false) excluiCliente();
            else MessageBox.Show("Selecione um cliente para excluir.", "ERRO");
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            pesCliente abrir = new pesCliente();
            abrir.Show();
        }
    }
}
