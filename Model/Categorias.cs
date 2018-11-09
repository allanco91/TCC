using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHOP.Model
{
    public class Categorias
    {
        public int idcategorias { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }

        public Categorias(int idcategorias)
        {
            this.idcategorias = idcategorias;
        }
        
        public Categorias(string tipo, string descricao)
        {
            this.tipo = tipo;
            this.descricao = descricao;
        }
        
        public Categorias(int idcategorias, string tipo, string descricao)
        {
            this.idcategorias = idcategorias;
            this.tipo = tipo;
            this.descricao = descricao;
        }
    }
}
