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
    public partial class gerPedido : Form
    {
        public gerPedido()
        {
            InitializeComponent();
        }

        private List<ItensPedidos> semEstoque = new List<ItensPedidos>();
        #region lista itens do pedido
        private List<ItensPedidos> listItens = new List<ItensPedidos>();

        public class ItensView
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
                listItens.Add(new ItensPedidos(itens.idpedido, itens.idproduto, itens.quantidade, itens.valor, itens.valortotal));
            }
        }
        #endregion

        private void btProcurar_Click(object sender, EventArgs e)
        {
            pesPedido abrir = new pesPedido();
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

        private void mostraPedido(int cod)
        {
            dalPedido ped = new dalPedido();
            List<pedido> pedido = ped.listaPedidos(cod);
            btLimpar.Enabled = true;

            foreach (var p in pedido)
            {
                tbNome.Text = p.cliente.nome;

                //condicao controle de pagamento
                if (p.datapagamento == null)
                {
                    btPagamento.Enabled = true;
                    lbPagamento.Visible = true;
                    lbPagamento.Text = "Não Efetuado";
                }
                else
                {
                    btPagamento.Enabled = false;
                    lbPagamento.Visible = true;
                    lbPagamento.Text = "Efetuado";
                }

                //condicao controle de liberacao e entrega
                if (p.statuspedido == 1)
                {
                    lbStatus.Visible = true;
                    lbStatus.Text = "Em aberto";
                    btLiberar.Enabled = true;
                    btEntrega.Enabled = false;
                }
                else if (p.statuspedido == 2)
                {
                    lbStatus.Visible = true;
                    lbStatus.Text = "Liberado";
                    btLiberar.Enabled = false;
                    btEntrega.Enabled = true;
                }
                else if (p.statuspedido == 3)
                {
                    lbStatus.Visible = true;
                    lbStatus.Text = "Entregue";
                    btLiberar.Enabled = false;
                    btEntrega.Enabled = false;
                }
                else
                {
                    lbStatus.Visible = true;
                    lbStatus.Text = "Cancelado";
                    btLiberar.Enabled = false;
                    btEntrega.Enabled = false;
                    btPagamento.Enabled = false;
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

        private void tbNumeropedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(e);

            if (e.KeyChar == 13)
            {
                mostraPedido();
            }
        }

        private void mostraPedido()
        {
            if ((tbNumeropedido.Text != "") && (tbNumeropedido.Text != null))
            {
                mostraPedido(Convert.ToInt32(tbNumeropedido.Text));
                carregaItens(Convert.ToInt32(tbNumeropedido.Text));
                populaGrid();
                calculaValorTotal();
                mostraPedido(Convert.ToInt32(tbNumeropedido.Text));
                tbNumeropedido.Enabled = false;
            }
            else MessageBox.Show("Erro: Digite um número de pedido para procurar.");
        }

        private void resetCampos()
        {
            tbNome.Text = "";
            tbNumeropedido.Text = "";
            listItens.Clear();
            populaGrid();
            tbValorTotalPedido.Text = "";
            btLiberar.Enabled = false;
            btEntrega.Enabled = false;
            btPagamento.Enabled = false;
            btLimpar.Enabled = false;
            lbStatus.Visible = false;
            lbPagamento.Visible = false;
            tbNumeropedido.Enabled = true;
            tbNumeropedido.Select();
        }

        private void liberaPedido(List<ItensPedidos> list, int cod)
        {
            dalProduto produto = new dalProduto();
            if (MessageBox.Show("Tem certeza que deseja liberar o pedido?", "Confirmar liberação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                semEstoque.AddRange(produto.liberaBaixaEstoque(list, cod));

                if (semEstoque.Count > 0)
                {
                    populaGridSemEstoque();
                    resetCampos();
                }
                else
                {
                    listItens.Clear();
                    mostraPedido();
                }
            }
        }

        private void populaGridSemEstoque()
        {
            dalProduto p = new dalProduto();
            if (MessageBox.Show("Deseja visualizar os produtos sem estoque?", "Visualizar produtos sem estoque", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                repwProdSemEstoque abrir = new repwProdSemEstoque();
                abrir.ItensViewBindingSource.DataSource = (from i in semEstoque
                                                      select new ItensView { Codigo = i.idProduto, Nome = p.retornaNome(i.idProduto), Quantidade = i.quantidade, Valor = i.valor, ValorTotal = i.valortotal }).ToList();
                semEstoque.Clear();
                abrir.Show();
            }
            else semEstoque.Clear(); 
        }

        private void confirmaEntrega(int cod)
        {
            dalPedido pedido = new dalPedido();
            if (MessageBox.Show("Tem certeza que deseja confirmar a entrega do pedido?", "Confirmar entrega", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pedido.confirmarEntrega(cod);
                listItens.Clear();
                mostraPedido();
            }
        }

        private void confirmaPagamento(int cod)
        {
            dalPedido pedido = new dalPedido();
            if (MessageBox.Show("Tem certeza que deseja confirmar o pagamento do pedido?", "Confirmar pagamento", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pedido.confirmarPagamento(cod);
                listItens.Clear();
                mostraPedido();
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            resetCampos();
        }

        private void btLiberar_Click(object sender, EventArgs e)
        {
            if (tbNumeropedido.Enabled == false) liberaPedido(listItens, Convert.ToInt32(tbNumeropedido.Text));
        }

        private void btEntrega_Click(object sender, EventArgs e)
        {
            if (tbNumeropedido.Enabled == false) confirmaEntrega(Convert.ToInt32(tbNumeropedido.Text));
        }

        private void btPagamento_Click(object sender, EventArgs e)
        {
            if (tbNumeropedido.Enabled == false) confirmaPagamento(Convert.ToInt32(tbNumeropedido.Text));
        }
    }
}
