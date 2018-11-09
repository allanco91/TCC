using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHOP.Model
{
    public class Pedidos
    {
        public int idPedidos { get; set; }
        public int idCliente { get; set; }
        public decimal valorTotal { get; set; }
        public int statusPedido { get; set; }
        public DateTime data { get; set; }
        public DateTime datamodificacao { get; set; }
        public DateTime dataLiberacao { get; set; }
        public DateTime dataEntregue { get; set; }
        public DateTime dataPagamento { get; set; }

        public Pedidos(int idPedidos, int idCliente, decimal valorTotal, int statusPedido, DateTime data, DateTime datamodificacao)
        {
            this.idPedidos = idPedidos;
            this.idCliente = idCliente;
            this.valorTotal = valorTotal;
            this.statusPedido = statusPedido;
            this.data = data;
            this.datamodificacao = datamodificacao;
        }

        public Pedidos(int idCliente, decimal valorTotal, int statusPedido, DateTime data, DateTime datamodificacao)
        {
            this.idCliente = idCliente;
            this.valorTotal = valorTotal;
            this.statusPedido = statusPedido;
            this.data = data;
            this.datamodificacao = datamodificacao;
        }

        public Pedidos(int idPedidos, int idCliente, decimal valorTotal, DateTime datamodificacao)
        {
            this.idPedidos = idPedidos;
            this.idCliente = idCliente;
            this.valorTotal = valorTotal;
            this.datamodificacao = datamodificacao;
        }
    }
}
