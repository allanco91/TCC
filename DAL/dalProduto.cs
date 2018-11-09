using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using SHOP.Model;

namespace SHOP.DAL
{
    class dalProduto
    {
        public string t { get; set; }

        public void insereProduto(Produtos obj_produto)
        {
            try
            {
                Table<produto> produto = acessoLinqTabelas.getTabelaProduto();
                produto pro = new produto();

                pro.nome = obj_produto.nome;
                pro.idcategoria = obj_produto.idCategoria;
                pro.marca = obj_produto.marca;                
                pro.descricao = obj_produto.descricao;
                pro.valorcompra = obj_produto.valorcompra;
                pro.valorvenda = obj_produto.valorvenda;
                pro.saldoestoque = obj_produto.saldoestoque;

                produto.InsertOnSubmit(pro);
                produto.Context.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Atualiza um produto existe
        public void atualizaProduto(Produtos obj_produto)
        {
            try
            {
                hskDataContext hsk = new hskDataContext();
                var achaIdPro = (from c in hsk.GetTable<produto>()
                                 where c.idprodutos == obj_produto.idProdutos
                                 select c).SingleOrDefault();

                if (achaIdPro != null)
                {
                    achaIdPro.nome = obj_produto.nome;
                    achaIdPro.idcategoria = obj_produto.idCategoria;
                    achaIdPro.marca = obj_produto.marca;
                    achaIdPro.descricao = obj_produto.descricao;
                    achaIdPro.valorcompra = obj_produto.valorcompra;
                    achaIdPro.valorvenda = obj_produto.valorvenda;
                    achaIdPro.saldoestoque = obj_produto.saldoestoque;
                    hsk.SubmitChanges();
                    System.Windows.Forms.MessageBox.Show("Produto atualizado com sucesso.");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("ERRO: Não foi possível atualizar o produto.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Deleta um produto existente
        public void deletaProduto(int codigo)
        {
            int i = (from pi in acessoLinqTabelas.getTabelaItensPedido()
                     where pi.idproduto == codigo
                     select pi).Count();

            if (i == 0)
            {
                hskDataContext hsk = new hskDataContext();
                var achaIdPro = (from c in hsk.GetTable<produto>()
                                 where c.idprodutos == codigo
                                 select c).SingleOrDefault();
                try
                {
                    hsk.produtos.DeleteOnSubmit(achaIdPro);
                    hsk.SubmitChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else System.Windows.Forms.MessageBox.Show("ERRO: Não foi possível excluir o peoduto, porque há um ou mais pedidos cadastrados com o mesmo.", "ERRO");
        }

        //Lista geral de produtos
        public List<produto> listarProdutos()
        {
            Table<produto> produto = acessoLinqTabelas.getTabelaProduto();

            return (from pro in produto
                    select pro).ToList<produto>();
        }

        //Lista produtos pelo codigo
        public List<produto> listarProdutos(int codigo)
        {
            Table<produto> produto = acessoLinqTabelas.getTabelaProduto();

            return (from pro in produto
                    where pro.idprodutos == codigo
                    select pro).ToList<produto>();
        }

        public List<consultaProduto> listarProdutosC(int codigo)
        {
            Table<produto> produto = acessoLinqTabelas.getTabelaProduto();

            return (from pro in produto
                    where pro.idprodutos == codigo
                    select new consultaProduto
                    {
                        codigo = pro.idprodutos,
                        nome = pro.nome,
                        marca = pro.marca,
                        categoria = pro.categoria.tipo,
                        valorvenda = pro.valorvenda,
                        saldoestoque = pro.saldoestoque
                    }).ToList<consultaProduto>();
        }

        public List<consultaProduto> listarProdutosN(string nome)
        {
            Table<produto> produto = acessoLinqTabelas.getTabelaProduto();

            return (from pro in produto
                    where pro.nome.StartsWith(nome)
                    select new consultaProduto
                    {
                        codigo = pro.idprodutos,
                        nome = pro.nome,
                        marca = pro.marca,
                        categoria = pro.categoria.tipo,
                        valorvenda = pro.valorvenda,
                        saldoestoque = pro.saldoestoque
                    }).ToList<consultaProduto>();
        }

        public List<consultaProduto> listarProdutosM(string marca)
        {
            Table<produto> produto = acessoLinqTabelas.getTabelaProduto();

            return (from pro in produto
                    where pro.marca.StartsWith(marca)
                    select new consultaProduto
                    {
                        codigo = pro.idprodutos,
                        nome = pro.nome,
                        marca = pro.marca,
                        categoria = pro.categoria.tipo,
                        valorvenda = pro.valorvenda,
                        saldoestoque = pro.saldoestoque
                    }).ToList<consultaProduto>();
        }

        public List<consultaProduto> listarProdutosCA(int categoria)
        {
            Table<produto> produto = acessoLinqTabelas.getTabelaProduto();

            return (from pro in produto
                    where pro.idcategoria == categoria
                    select new consultaProduto
                    {
                        codigo = pro.idprodutos,
                        nome = pro.nome,
                        marca = pro.marca,
                        categoria = pro.categoria.tipo,
                        valorvenda = pro.valorvenda,
                        saldoestoque = pro.saldoestoque
                    }).ToList<consultaProduto>();
        }

        public List<consultaProduto> listarProdutosE(int estoque)
        {
            Table<produto> produto = acessoLinqTabelas.getTabelaProduto();

            return (from pro in produto
                    where pro.saldoestoque == estoque
                    select new consultaProduto
                    {
                        codigo = pro.idprodutos,
                        nome = pro.nome,
                        marca = pro.marca,
                        categoria = pro.categoria.tipo,
                        valorvenda = pro.valorvenda,
                        saldoestoque = pro.saldoestoque
                    }).ToList<consultaProduto>();
        }

        public class consultaProduto
        {
            public int codigo { get; set; }
            public string nome { get; set; }
            public string marca { get; set; }
            public string categoria { get; set; }
            public decimal? valorvenda { get; set; }
            public decimal? saldoestoque { get; set; }
        }

        public string retornaNome(int cod)
        {
            Table<produto> produtos = acessoLinqTabelas.getTabelaProduto();

            var txt = (from it in produtos
                       where it.idprodutos == cod
                       select it).ToList();

            foreach (var p in txt)
            {
                t = p.nome;
            }
            return t;
        }

        public bool verificaProduto(int cod, string nome)
        {
            Table<produto> produtos = acessoLinqTabelas.getTabelaProduto();

            int count = (from p in produtos
                       where p.idprodutos == cod && p.nome.Equals(nome)
                       select p).Count();

            if (count > 0) return true;
            else return false;
        }

        /*gerenciamento estoque
            abaixo LINQ consulta compilada*/
        Func<hskDataContext, Int32, produto> query_compilada =
                CompiledQuery.Compile<hskDataContext, Int32, produto>(
                (ctx, id) => (from p in ctx.produtos
                             where p.idprodutos == id
                             select p).SingleOrDefault());

        public List<ItensPedidos> liberaBaixaEstoque(List<ItensPedidos> list_itenspedidos, int cod)
        {
            List<ItensPedidos> itensSemEstoque = new List<ItensPedidos>();
            hskDataContext hsk = new hskDataContext();

            //verifica saldo no estoque >se não insere item na lista
            foreach (var l in list_itenspedidos)
            {
                produto prod = query_compilada.Invoke(hsk, l.idProduto);

                if (prod.saldoestoque < l.quantidade)
                {
                    itensSemEstoque.Add(l);
                }
            }

            //baixa estoque caso nao tenha nenhum produto sem estoque
            if (itensSemEstoque.Count == 0)
            {
                foreach (var l in list_itenspedidos)
                {
                    produto prod = query_compilada.Invoke(hsk, l.idProduto);

                    if (prod.saldoestoque >= l.quantidade)
                    {
                        prod.saldoestoque = prod.saldoestoque - l.quantidade;
                    }
                }

                hsk.SubmitChanges();
                dalPedido ped = new dalPedido();
                ped.liberarPedido(cod);
                return itensSemEstoque.ToList();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERRO: Não foi possível liberar o pedido, produtos sem estoque.");
                return itensSemEstoque.ToList();
            }
        }
    }
}
