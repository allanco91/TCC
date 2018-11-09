using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHOP.Model
{
    public class Pedidos
    {
        private int idPedidos { get; set; }
        private int idCliente { get; set; }
        private double valorTotal { get; set; }

        public Pedidos(int idPedidos, int idCliente, double valorTotal)
        {
            this.idPedidos = idPedidos;
            this.idCliente = idCliente;
            this.valorTotal = valorTotal;
        }
    }
}
