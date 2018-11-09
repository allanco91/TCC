using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;

namespace SHOP.DAL
{
    public class dalEstado
    {
        public List<estado> listaEstados()
        {
            Table<estado> estado = acessoLinqTabelas.getTabelaEstado();

            return (from est in estado
                    select est).ToList<estado>();
        }
    }
}
