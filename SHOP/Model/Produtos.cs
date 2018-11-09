using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHOP.Model
{
    public class Produtos
    {
        private int idProdutos { get; set; }
        private string nome { get; set; }
        private int idCategoria { get; set; }
        private string marca { get; set; }
        private string descricao { get; set; }
        private double valor { get; set; }

        public Produtos(int idProdutos, string nome, int idCategoria, string marca, string descricao, double valor)
        {
            this.idProdutos = idProdutos;
            this.nome = nome;
            this.idCategoria = idCategoria;
            this.marca = marca;
            this.descricao = descricao;
            this.valor = valor;
        }

        public Produtos(string nome, int idCategoria, string marca, string descricao, double valor)
        {
            this.nome = nome;
            this.idCategoria = idCategoria;
            this.marca = marca;
            this.descricao = descricao;
            this.valor = valor;
        }
    }
}
