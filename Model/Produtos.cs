using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHOP.Model
{
    public class Produtos
    {
        public int idProdutos { get; set; }
        public string nome { get; set; }
        public int idCategoria { get; set; }
        public string marca { get; set; }
        public string descricao { get; set; }
        public decimal valorcompra { get; set; }
        public decimal valorvenda { get; set; }
        public decimal saldoestoque { get; set; }

        public Produtos(int idProdutos, string nome, int idCategoria, string marca, string descricao, decimal valorcompra, decimal valorvenda, decimal saldoestoque)
        {
            this.idProdutos = idProdutos;
            this.nome = nome;
            this.idCategoria = idCategoria;
            this.marca = marca;
            this.descricao = descricao;
            this.valorcompra = valorcompra;
            this.valorvenda = valorvenda;
            this.saldoestoque = saldoestoque;
        }

        public Produtos(string nome, int idCategoria, string marca, string descricao, decimal valorcompra, decimal valorvenda, decimal saldoestoque)
        {
            this.nome = nome;
            this.idCategoria = idCategoria;
            this.marca = marca;
            this.descricao = descricao;
            this.valorcompra = valorcompra;
            this.valorvenda = valorvenda;
            this.saldoestoque = saldoestoque;
        }
    }
}
