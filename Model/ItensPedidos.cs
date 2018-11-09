using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHOP.Model
{
    public class ItensPedidos
    {
        public int idItensPedido { get; set; }
        public int idPedido { get; set; }
        public int idProduto { get; set; }
        public decimal quantidade { get; set; }
        public decimal valor { get; set; }
        public decimal valortotal { get; set; }

        public ItensPedidos(int idItensPedido, int idPedido, int idProduto, decimal quantidade, decimal valor, decimal valortotal)
        {
            this.idItensPedido = idItensPedido;
            this.idPedido = idPedido;
            this.idProduto = idProduto;
            this.quantidade = quantidade;
            this.valor = valor;
            this.valortotal = valortotal;
        }

        public ItensPedidos(int idPedido, int idProduto, decimal quantidade, decimal valor, decimal valortotal)
        {
            this.idPedido = idPedido;
            this.idProduto = idProduto;
            this.quantidade = quantidade;
            this.valor = valor;
            this.valortotal = valortotal;
        }
        
        public ItensPedidos(int idProduto, decimal quantidade, decimal valor, decimal valortotal)
        {
            this.idProduto = idProduto;
            this.quantidade = quantidade;
            this.valor = valor;
            this.valortotal = valortotal;
        }
    }
}
