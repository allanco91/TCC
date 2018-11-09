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
            cbCidade.Enabled = true;
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
            if (valida()) cadastrarCliente();
            else MessageBox.Show("ERRO: Não foi possível cadastrar, preencha todos os campos", "ERRO");
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

        private void btGerenciar_Click(object sender, EventArgs e)
        {
            modCliente abrir = new modCliente();
            abrir.Show();
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
            tbNome.Text = "";
            tbEndereco.Text = "";
            tbNumero.Text = "";
            tbBairro.Text = "";
            tbCep.Text = "";
            cbEstado.SelectedIndex = 0;
            cbCidade.SelectedIndex = 0;
            tbCpfcnpj.Text = "";
            cbSexo.SelectedIndex = 0;
            rbAtivo.Checked = true;
            rbInativo.Checked = false;
            tbEmail.Text = "";
            tbTelefone.Text = "";
            tbNome.Select();
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
                MessageBox.Show("ERRO: Digite um e-mail válido.","ERRO");
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

        private void cadastrarCliente()
        {
            try
            {
                dalCliente cliente = new dalCliente();
                cliente.insereCliente(new Clientes(tbNome.Text, tbEndereco.Text, tbBairro.Text, tbNumero.Text, tbCep.Text, Convert.ToInt32(cbEstado.SelectedValue), Convert.ToInt32(cbCidade.SelectedValue), tbTelefone.Text, Convert.ToChar(cbSexo.SelectedValue), tbEmail.Text, tbCpfcnpj.Text, rbAtivo.Checked));
                MessageBox.Show("Cliente cadastrado com sucesso.");
                resetCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO:" + ex.ToString(), "ERRO");
            }
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

    }
}
