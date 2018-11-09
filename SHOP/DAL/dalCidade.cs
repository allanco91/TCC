using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;

namespace SHOP.DAL
{
    public class dalCidade
    {
        public List<cidade> listaCidades()
        {
            Table<cidade> cidade = acessoLinqTabelas.getTabelaCidade();

            return (from cid in cidade
                    select cid).ToList<cidade>();
        }

        public List<cidade> listaCidades(int idEstado)
        {
            Table<cidade> cidade = acessoLinqTabelas.getTabelaCidade();

            return (from cid in cidade
                    where cid.EstadoId == idEstado
                    select cid).ToList<cidade>();
        }
    }
}
