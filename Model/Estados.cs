using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHOP.Model
{
    public class Estados
    {
        public int idEstado { get; set; }
        public string sigla { get; set; }

        public Estados(int idEstado, string sigla)
        {
            this.idEstado = idEstado;
            this.sigla = sigla;
        }
    }
}
