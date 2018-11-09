using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHOP.Model
{
    public class Categorias
    {
        public int idCategorias { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }

        public Categorias(int idCategorias)
        {
            this.idCategorias = idCategorias;
        }
        
        public Categorias(string tipo, string descricao)
        {
            this.tipo = tipo;
            this.descricao = descricao;
        }
        
        public Categorias(int idCategorias, string tipo, string descricao)
        {
            this.idCategorias = idCategorias;
            this.tipo = tipo;
            this.descricao = descricao;
        }
    }
}
