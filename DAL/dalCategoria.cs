using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using SHOP.Model;

namespace SHOP.DAL
{
    public class dalCategoria
    {
        public class CategoriaInfo
        {
            public string Tipo { get; set; }
            public string Descricao { get; set; }
        }

        
        //Cadastra uma categoria
        public void insereCategoria(Categorias obj_categorias)
        {
            try
            {
                Table<categoria> categoria = acessoLinqTabelas.getTabelaCategoria();
                categoria cat = new categoria();                

                cat.tipo = obj_categorias.tipo;
                cat.descricao = obj_categorias.descricao;

                categoria.InsertOnSubmit(cat);
                categoria.Context.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Atualiza uma categoria existe
        public void atualizaCategoria(Categorias obj_categorias)
        {
            try
            {
                hskDataContext hsk = new hskDataContext();

                var achaIdCat = (from c in hsk.GetTable<categoria>()
                                 where c.idcategorias == obj_categorias.idcategorias
                                 select c).SingleOrDefault();

                if (achaIdCat != null)
                {
                    achaIdCat.tipo = obj_categorias.tipo;
                    achaIdCat.descricao = obj_categorias.descricao;
                    hsk.SubmitChanges();
                    System.Windows.Forms.MessageBox.Show("Categoria atualizada com sucesso.");

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("ERRO: Não foi possível atualizar a categoria.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Deleta uma categoria existente
        public void deletaCategoria(int codigo)
        {            
            int i = (from p in acessoLinqTabelas.getTabelaProduto()
                     where p.idcategoria == codigo
                     select p).Count();

            if (i == 0)
            {
                hskDataContext hsk = new hskDataContext();
                var achaIdCat = (from c in hsk.GetTable<categoria>()
                                 where c.idcategorias == codigo
                                 select c).SingleOrDefault();
                try
                {
                    hsk.categorias.DeleteOnSubmit(achaIdCat);
                    hsk.SubmitChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else System.Windows.Forms.MessageBox.Show("ERRO: Não foi possível excluir a categoria, porque há um ou mais produtos cadastrados com a mesma.","ERRO");
        }

        //Lista geral de categorias
        public List<categoria> listaCategorias()
        {
            Table<categoria> categorias = acessoLinqTabelas.getTabelaCategoria();

            return (from cat in categorias
                    select cat).ToList<categoria>();
        }

        //Lista de categorias por codigo
        public List<categoria> listaCategorias(int codigo)
        {
            Table<categoria> categorias = acessoLinqTabelas.getTabelaCategoria();

            return (from cat in categorias
                    where codigo == cat.idcategorias
                    select cat).ToList<categoria>();
        }

        //Lista de categorias por tipo
        public List<categoria> listaCategorias(string tipo)
        {
            Table<categoria> categorias = acessoLinqTabelas.getTabelaCategoria();

            return (from cat in categorias
                    where cat.tipo.StartsWith(tipo)
                    select cat).ToList<categoria>();
        }        
        
        //Lista categorias sem mostrar id
        public List<CategoriaInfo> listaCategoriasNoId()
        {
            Table<categoria> categorias = acessoLinqTabelas.getTabelaCategoria();

            var catList = from cat in categorias
                       select new CategoriaInfo { Tipo = cat.tipo, Descricao = cat.descricao };

            return catList.ToList();
        }
    }
}
