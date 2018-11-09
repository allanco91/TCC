using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHOP.Model
{
    public class Sexos
    {
        public string idSexos { get; set; }
        public string descricao { get; set; }

        public Sexos(string idSexos, string descricao)
        {
            this.idSexos = idSexos;
            this.descricao = descricao;
        }
    }
}
