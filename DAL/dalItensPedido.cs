using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using SHOP.Model;

namespace SHOP.DAL
{
    class dalItensPedido
    {
        public void insereItensPedido(List<ItensPedidos> list_itenspedidos, int cod)
        {
            Table<itenspedido> itens = acessoLinqTabelas.getTabelaItensPedido();

            foreach (var l in list_itenspedidos)
            {
                itenspedido itensped = new itenspedido();
                itensped.idpedido = cod;
                itensped.idproduto = l.idProduto;
                itensped.quantidade = l.quantidade;
                itensped.valor = l.valor;
                itensped.valortotal = l.valortotal;

                itens.InsertOnSubmit(itensped);
            }

            itens.Context.SubmitChanges();
        }

        //Lista geral de itenspedido
        public List<itenspedido> listaItensPedido()
        {
            Table<itenspedido> itenspedidos = acessoLinqTabelas.getTabelaItensPedido();

            return (from it in itenspedidos
                    select it).ToList();
        }

        public List<itenspedido> mostraItensPedido(int cod)
        {
            Table<itenspedido> ped = acessoLinqTabelas.getTabelaItensPedido();

            return (from p in ped
                    where p.idpedido == cod
                    select p).ToList();
        }

        public void deletaItens(int cod)
        {
            hskDataContext hsk = new hskDataContext();
            var del = from ip in hsk.GetTable<itenspedido>()
                      where ip.idpedido == cod
                      select ip;
            try
            {
                hsk.itenspedidos.DeleteAllOnSubmit(del);
                hsk.SubmitChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("ERRO: Não foi possível excluir os itens." + ex, "ERRO");
            }
        }
    }
}
