using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHOP.Model
{
    public class Cidades
    {
        public int idCidade { get; set; }
        public string nome { get; set; }
        public int idEstado { get; set; }
        public bool capital { get; set; }

        public Cidades(int idCidade, string nome, int idEstado)
        {
            this.idCidade = idCidade;
            this.nome = nome;
            this.idEstado = idEstado;
        }
    }
}
