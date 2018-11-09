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
    public partial class modCategoria : Form
    {
        public modCategoria()
        {
            InitializeComponent();
        }

        private void achaCategoria(int codigo)
        {
            dalCategoria categoria = new dalCategoria();

            var result = from c in categoria.listaCategorias(codigo)
                         select c;

            if (result.Count() > 0)
            {
                foreach (var cat in result)
                {
                    tbTipo.Text = cat.tipo;
                    tbDescricao.Text = cat.descricao;
                    
                    tbCodigo.Enabled = false;
                    tbTipo.Enabled = true;
                    tbDescricao.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Nenhuma categoria encontrada");
            }
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            pesCategoria abrir = new pesCategoria();
            abrir.Show();
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(e);

            if (e.KeyChar == 13)
                if ((tbCodigo.Text != "") && (tbCodigo.Text != null)) achaCategoria(Convert.ToInt32(tbCodigo.Text));
        }

        public static void AllowNumber(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Letras
                char.IsSymbol(e.KeyChar) || //Símbolos
                char.IsWhiteSpace(e.KeyChar) || //Espaço
                char.IsPunctuation(e.KeyChar)) //Pontuação
                e.Handled = true; //Não permitir            
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            resetCampos();
        }

        private void resetCampos()
        {
            tbCodigo.Text = "";
            tbCodigo.Enabled = true;
            tbTipo.Text = "";
            tbTipo.Enabled = false;
            tbDescricao.Text = "";
            tbDescricao.Enabled = false;
        }

        private void brAlterar_Click(object sender, EventArgs e)
        {
            if ((tbCodigo.Enabled == false) && (valida())) atualizaCategoria();
            else MessageBox.Show("ERRO: Selecione uma categoria para alterar/Preencha todos os campos.", "ERRO");

        }

        private void atualizaCategoria()
        {
            dalCategoria categoria = new dalCategoria();
            if (MessageBox.Show("Tem certeza que deseja atualizar a categoria?", "Confirmar atualização", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                categoria.atualizaCategoria(new Categorias(Convert.ToInt32(tbCodigo.Text), tbTipo.Text, tbDescricao.Text));
                resetCampos();
            }
        }

        private void excluiCategoria()
        {
            dalCategoria categoria = new dalCategoria();
            if (MessageBox.Show("Tem certeza que deseja excluir a categoria?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                categoria.deletaCategoria(Convert.ToInt32(tbCodigo.Text));
                resetCampos();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Enabled == false) excluiCategoria();
            else MessageBox.Show("Selecione uma categoria para excluir.","ERRO");
        }

        private bool valida()
        {
            if ((tbTipo.Text != "") && (tbTipo.Text != null) && (tbDescricao.Text != "") && (tbDescricao.Text != null)) return true;
            else return false;
        }
    }
}
