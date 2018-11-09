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
    public partial class modPedido : Form
    {
        public modPedido()
        {
            InitializeComponent();
        }
        
        #region lista itens do pedido        
        private List<ItensPedidos> listItens = new List<ItensPedidos>();

        private class ItensView
        {
            public int Codigo { get; set; }
            public string Nome { get; set; }
            public decimal Quantidade { get; set; }
            public decimal Valor { get; set; }
            public decimal ValorTotal { get; set; }
        }

        private void populaGrid()
        {
            dalProduto p = new dalProduto();

            dgvItens.DataSource = (from i in listItens
                                   select new ItensView { Codigo = i.idProduto, Nome = p.retornaNome(i.idProduto), Quantidade = i.quantidade, Valor = i.valor, ValorTotal = i.valortotal }).ToList();
        }

        private void carregaItens(int cod)
        {
            dalItensPedido ip = new dalItensPedido();

            foreach (var itens in ip.mostraItensPedido(cod))
            {
                listItens.Add(new ItensPedidos(itens.idpedido, itens.idproduto,itens.quantidade, itens.valor,itens.valortotal));
            }
        }
        #endregion

        private void modPedido_Load(object sender, EventArgs e)
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

        private void tbNumeropedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(e);

            if (e.KeyChar == 13)
            {
                if ((tbNumeropedido.Text != "") && (tbNumeropedido.Text != null))
                {
                    achaClientePedido(Convert.ToInt32(tbNumeropedido.Text));
                    carregaItens(Convert.ToInt32(tbNumeropedido.Text));
                    populaGrid();
                    calculaValorTotal();
                    ativaCampos();
                    mostraPedido(Convert.ToInt32(tbNumeropedido.Text));
                }
                else MessageBox.Show("Erro: Digite um número de pedido para procurar.");
            }            
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

        private void btProcurar_Click(object sender, EventArgs e)
        {
            pesCliente abrir = new pesCliente();
            abrir.Show();
        }

        private void achaClientePedido(int cod)
        {
            dalPedido pedido = new dalPedido();
            
                List<cliente> clientes = pedido.mostraClientePedido(cod);

                foreach (var c in clientes)
                {
                    tbCodigo.Text = c.idclientes.ToString();
                    tbNome.Text = c.nome;
                    tbEndereco.Text = c.endereco;
                    tbNumero.Text = c.numero;
                    tbBairro.Text = c.bairro;
                    tbCep.Text = c.cep;
                    cbEstado.SelectedValue = c.uf;
                    cbCidade.SelectedValue = c.cidade;
                    tbCpfcnpj.Text = c.cpf_cnpj;
                    cbSexo.SelectedValue = c.sexo;
                    tbEmail.Text = c.email;
                    tbTelefone.Text = c.telefone;

                    if (c.status)
                    {
                        rbAtivo.Checked = true;
                    }
                    else
                    {
                        rbInativo.Checked = true;
                    }
                }                        
        }

        private void tbValor_Leave(object sender, EventArgs e)
        {
            if (tbValor.Text != "")
                tbValor.Text = Decimal.Parse(tbValor.Text).ToString("N2");
        }

        private void tbValortotal_Leave(object sender, EventArgs e)
        {
            if (tbValortotal.Text != "")
                tbValortotal.Text = Decimal.Parse(tbValortotal.Text).ToString("N2");
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (validaItem()) addItem();
            else MessageBox.Show("ERRO: Não foi possível adicionar o produto, preencha todos os campos.", "ERRO");
        }

        private void addItem()
        {
            dalProduto p = new dalProduto();
            
            if (p.verificaProduto(Convert.ToInt32(tbCodigoProd.Text), lbNome.Text))
            {
                listItens.Add(new ItensPedidos(Convert.ToInt32(tbCodigoProd.Text), Convert.ToDecimal(tbQuantidade.Text), Convert.ToDecimal(tbValor.Text), Convert.ToDecimal(tbValortotal.Text)));
                populaGrid();
                calculaValorTotal();

                tbCodigoProd.Text = "";
                lbNome.Text = "";
                tbQuantidade.Text = "";
                tbValor.Text = "";
                tbValortotal.Text = "";
                tbCodigoProd.Select();
            }
            else
            {
                MessageBox.Show("ERRO: O Código " + tbCodigoProd.Text + " não pertence ao produto " + lbNome.Text + ".", "ERRO");
            }
        }

        private void tbQuantidade_TextChanged(object sender, EventArgs e)
        {
            calculaValorItem();
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (dgvItens.RowCount > 0) apagarItem(dgvItens.CurrentCell.RowIndex);
        }

        private void apagarItem(int index)
        {
            listItens.RemoveAt(index);
            populaGrid();
            calculaValorTotal();
        }

        private void tbCodigoProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(e);

            //mostrando o produto quando insere o codigo
            if (e.KeyChar == 13)
            {
                dalProduto prod = new dalProduto();

                if ((tbCodigoProd.Text != "") && (tbCodigoProd.Text != null))
                {
                    foreach (produto pro in prod.listarProdutos(Convert.ToInt32(tbCodigoProd.Text)))
                    {
                        lbNome.Text = pro.nome;
                        tbValor.Text = pro.valorvenda.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Erro: Digite um codigo do produto.");
                }
            }
        }

        public static void AllowNumber(object sender, KeyPressEventArgs e, char cSymbol)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != cSymbol)
            {
                e.Handled = true;
            }

            if (e.KeyChar == cSymbol && (sender as TextBox).Text.IndexOf(cSymbol) > -1)
            {
                e.Handled = true;
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

        private void tbQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(sender, e, ',');
        }

        private void tbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(sender, e, ',');
        }

        private void resetCampos()
        {
            tbNumeropedido.Text = "";
            tbNumeropedido.Enabled = true;
            tbCodigo.Text = "";
            tbCodigo.Enabled = false;
            tbNome.Text = "";
            tbEndereco.Text = "";
            tbNumero.Text = "";
            tbBairro.Text = "";
            tbCep.Text = "";
            cbEstado.SelectedIndex = 0;
            cbCidade.SelectedIndex = 0;
            tbCpfcnpj.Text = "";
            cbSexo.SelectedIndex = 0;
            tbEmail.Text = "";
            tbTelefone.Text = "";

            tbCodigoProd.Text = "";
            tbCodigoProd.Enabled = false;
            tbQuantidade.Text = "";
            tbQuantidade.Enabled = false;
            tbValor.Text = "";
            tbValor.Enabled = false;
            btAdd.Enabled = false;
            btApagar.Enabled = false;
            tbValortotal.Text = "";
            tbValorTotalPedido.Text = "";
            btProcurar.Enabled = false;
            btPesquisarProd.Enabled = false;
            btImprimir.Enabled = false;

            lbLiberado.Visible = false;
            dtLiberado.Visible = false;
            lbEntregue.Visible = false;
            dtEntregue.Visible = false;
            
            listItens.Clear();
            populaGrid();

            tabControl.SelectedTab = tabCliente;
            tbNumeropedido.Select();
        }

        private void ativaCampos()
        {
            tbNumeropedido.Enabled = false;
            tbCodigo.Enabled = true;
            tbCodigoProd.Enabled = true;
            tbQuantidade.Enabled = true;
            tbValor.Enabled = true;
            btProcurar.Enabled = true;
            btPesquisarProd.Enabled = true;
            btAdd.Enabled = true;
            btApagar.Enabled = true;
            btImprimir.Enabled = true;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            resetCampos();
        }

        private bool valida()
        {
            if ((tbCodigo.Text != "") && (tbCodigo.Text != null) &&
                (tbNome.Text != "") && (tbNome.Text != null) &&
                (listItens.Count != 0)) return true;
            else return false;
        }

        private bool validaItem()
        {
            if ((tbCodigoProd.Text != "") && (tbCodigoProd.Text != null) &&
                (tbQuantidade.Text != "") && (tbQuantidade.Text != null) &&
                (tbValor.Text != "") && (tbValor.Text != null) &&
                (tbValortotal.Text != "") && (tbValortotal.Text != null)) return true;
            else return false;
        }

        private void calculaValorItem()
        {
            if (!tbQuantidade.Text.Equals("") && !tbValor.Text.Equals(""))
            {
                decimal vl1 = Convert.ToDecimal(tbQuantidade.Text), vl2 = Convert.ToDecimal(tbValor.Text), vlt = 0;
                vlt = vl1 * vl2;
                tbValortotal.Text = vlt.ToString();
            }
        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {
            calculaValorItem();
        }

        private void atualizaPedido()
        {
            dalPedido ped = new dalPedido();
            dalItensPedido itens = new dalItensPedido();

            if (MessageBox.Show("Tem certeza que deseja atualizar o pedido?", "Confirmar atualização", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ped.atualizaPedido(new Pedidos(Convert.ToInt32(tbNumeropedido.Text), Convert.ToInt32(tbCodigo.Text), Convert.ToDecimal(tbValorTotalPedido.Text), DateTime.Today));
                itens.deletaItens(Convert.ToInt32(tbNumeropedido.Text));
                itens.insereItensPedido(listItens, Convert.ToInt32(tbNumeropedido.Text));
                listItens.Clear();
                resetCampos();
            }
        }

        private void btPesquisarProd_Click(object sender, EventArgs e)
        {
            pesProduto abrir = new pesProduto();
            abrir.Show();
        }

        private void mostraPedido(int cod)
        {
            dalPedido ped = new dalPedido();
            List<pedido> pedido = ped.listaPedidos(cod);

            foreach (var p in pedido)
            {
                dtPedido.Value = p.data.Value;
                dtAtualizacao.Value = p.datamodificacao.Value;
                if (p.statuspedido == 1) rbEmAberto.Checked = true;
                else if (p.statuspedido == 2)
                {
                    rbLiberado.Checked = true;
                    btAlterar.Enabled = false;
                    btExcluir.Enabled = false;
                    tbCodigo.Enabled = false;
                    btProcurar.Enabled = false;
                    btPesquisarProd.Enabled = false;
                    tbCodigoProd.Enabled = false;
                    tbQuantidade.Enabled = false;
                    tbValor.Enabled = false;
                    btAdd.Enabled = false;
                    btApagar.Enabled = false;

                    lbLiberado.Visible = true;
                    dtLiberado.Value = p.dataliberacao.Value;
                    dtLiberado.Visible = true;
                    MessageBox.Show("Pedido marcado como liberado, não será possivel alterar","Aviso");
                }
                else if (p.statuspedido == 3)
                {
                    rbEntregue.Checked = true;
                    btAlterar.Enabled = false;
                    btExcluir.Enabled = false;
                    tbCodigo.Enabled = false;
                    btProcurar.Enabled = false;
                    btPesquisarProd.Enabled = false;
                    tbCodigoProd.Enabled = false;
                    tbQuantidade.Enabled = false;
                    tbValor.Enabled = false;
                    btAdd.Enabled = false;
                    btApagar.Enabled = false;

                    lbLiberado.Visible = true;
                    dtLiberado.Value = p.dataliberacao.Value;
                    dtLiberado.Visible = true;

                    lbEntregue.Visible = true;
                    dtEntregue.Value = p.dataentregue.Value;
                    dtEntregue.Visible = true;
                    MessageBox.Show("Pedido marcado como entregue, não será possivel alterar", "Aviso");
                }
                else if (p.statuspedido == 4)
                {
                    rbCancelado.Checked = true;
                    btAlterar.Enabled = false;
                    btExcluir.Enabled = false;
                    tbCodigo.Enabled = false;
                    btProcurar.Enabled = false;
                    btPesquisarProd.Enabled = false;
                    tbCodigoProd.Enabled = false;
                    tbQuantidade.Enabled = false;
                    tbValor.Enabled = false;
                    btAdd.Enabled = false;
                    btApagar.Enabled = false;
                    MessageBox.Show("Pedido cancelado, não será possivel alterar", "Aviso");
                }
            }

        }

        private void calculaValorTotal()
        {
            decimal valorpedido = 0;

            for (int i = 0; i < dgvItens.Rows.Count; i++)
            {
                valorpedido += Convert.ToDecimal(dgvItens.Rows[i].Cells[4].Value);
            }

            tbValorTotalPedido.Text = valorpedido.ToString();
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(e);

            if (e.KeyChar == 13)
            {
                if ((tbCodigo.Text != "") && (tbCodigo.Text != null)) achaCliente(Convert.ToInt32(tbCodigo.Text));
                else MessageBox.Show("Erro: Digite um código para procurar o cliente.");
            }
        }

        private void achaCliente(int cod)
        {
            dalCliente cliente = new dalCliente();

            List<cliente> clientes = cliente.achaClienteId(cod);

            foreach (cliente c in clientes)
            {
                tbNome.Text = c.nome;
                tbEndereco.Text = c.endereco;
                tbNumero.Text = c.numero;
                tbBairro.Text = c.bairro;
                tbCep.Text = c.cep;
                cbEstado.SelectedValue = c.uf;
                cbCidade.SelectedValue = c.cidade;
                tbCpfcnpj.Text = c.cpf_cnpj;
                cbSexo.SelectedValue = c.sexo;
                tbEmail.Text = c.email;
                tbTelefone.Text = c.telefone;

                if (c.status)
                {
                    rbAtivo.Checked = true;
                }
                else
                {
                    rbInativo.Checked = true;
                }
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if ((tbNumeropedido.Enabled == false) && (valida())) atualizaPedido();
            else MessageBox.Show("ERRO: Selecione um pedido para alterar/Preencha todos os campos.", "ERRO");
        }

        private void excluiPedido()
        {
            dalPedido pedido = new dalPedido();
            dalItensPedido itenspedido = new dalItensPedido();
            if (MessageBox.Show("Tem certeza que deseja excluir o pedido?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                itenspedido.deletaItens(Convert.ToInt32(tbNumeropedido.Text));
                pedido.deletaPedido(Convert.ToInt32(tbNumeropedido.Text));
                resetCampos();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (tbNumeropedido.Enabled == false) excluiPedido();
            else MessageBox.Show("Selecione um pedido para excluir.", "ERRO");
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            dalPedido ped = new dalPedido();
            repwImprimePedido abrir = new repwImprimePedido();
            if (tbNumeropedido.Enabled == false)
            {
                abrir.imprimePedidoBindingSource.DataSource = ped.sourceRelatorioPedido(Convert.ToInt32(tbNumeropedido.Text));
                abrir.Show();
            }
        }
    }
}
