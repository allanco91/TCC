using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace SHOP.DAL
{
    class acessoLinqTabelas
    {
        public static Table<categoria> getTabelaCategoria()
        {
            hskDataContext dc = new hskDataContext();
            return dc.GetTable<categoria>();
        }

        public static Table<sexo> getTabelaSexo()
        {
            hskDataContext dc = new hskDataContext();
            return dc.GetTable<sexo>();
        }

        public static Table<estado> getTabelaEstado()
        {
            hskDataContext dc = new hskDataContext();
            return dc.GetTable<estado>();
        }

        public static Table<cidade> getTabelaCidade()
        {
            hskDataContext dc = new hskDataContext();
            return dc.GetTable<cidade>();
        }

        public static Table<cliente> getTabelaCliente()
        {
            hskDataContext dc = new hskDataContext();
            return dc.GetTable<cliente>();
        }
    }
}
