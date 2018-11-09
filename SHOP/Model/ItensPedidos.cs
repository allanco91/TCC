using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHOP.Model
{
    public class ItensPedidos
    {
        private int idItensPedido { get; set; }
        private int idPedido { get; set; }
        private int idProduto { get; set; }
        private double quantidade { get; set; }
        private double valor { get; set; }

        public ItensPedidos(int idItensPedido, int idPedido, int idProduto, double quantidade, double valor)
        {
            this.idItensPedido = idItensPedido;
            this.idPedido = idPedido;
            this.idProduto = idProduto;
            this.quantidade = quantidade;
            this.valor = valor;
        }
    }
}
