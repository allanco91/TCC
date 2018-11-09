using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;

namespace SHOP.DAL
{
    public class dalSexo
    {        
        public List<sexo> listaSexos()
        {
            Table<sexo> sexo = acessoLinqTabelas.getTabelaSexo();

            return (from sex in sexo
                    select sex).ToList<sexo>();
        }
    }
}
