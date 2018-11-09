using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using SHOP.Model;

namespace SHOP.DAL
{
    class dalPedido
    {
        public int inserePedido(Pedidos obj_pedidos, List<ItensPedidos> list_itenspedidos)
        {
            try
            {
                //grava tabela pedido
                Table<pedido> pedido = acessoLinqTabelas.getTabelaPedido();
                pedido ped = new pedido();

                ped.idcliente = obj_pedidos.idCliente;
                ped.valortotal = obj_pedidos.valorTotal;
                ped.statuspedido = obj_pedidos.statusPedido;
                ped.data = obj_pedidos.data;
                ped.datamodificacao = obj_pedidos.datamodificacao;

                pedido.InsertOnSubmit(ped);
                pedido.Context.SubmitChanges();

                //grava itenspedido
                Table<itenspedido> itens = acessoLinqTabelas.getTabelaItensPedido();
                foreach (var l in list_itenspedidos)
                {
                    itenspedido itensped = new itenspedido();
                    itensped.idpedido = ped.idpedidos;
                    itensped.idproduto = l.idProduto;
                    itensped.quantidade = l.quantidade;
                    itensped.valor = l.valor;
                    itensped.valortotal = l.valortotal;

                    itens.InsertOnSubmit(itensped);
                }

                itens.Context.SubmitChanges();

                return ped.idpedidos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Lista geral de pedidos
        public List<pedido> listaPedidos()
        {
            Table<pedido> pedidos = acessoLinqTabelas.getTabelaPedido();

            return (from ped in pedidos
                    select ped).ToList();
        }

        public List<pedido> listaPedidos(int cod)
        {
            Table<pedido> pedidos = acessoLinqTabelas.getTabelaPedido();

            return (from ped in pedidos
                    where ped.idpedidos == cod
                    select ped).ToList();
        }

        public class imprimePedido
        {
            public int ped_codigo { get; set; }
            public DateTime? ped_data_registro { get; set; }
            public DateTime? ped_data_liberacao { get; set; }
            public DateTime? ped_data_entrega { get; set; }
            public DateTime? ped_data_pagamento { get; set; }
            public string ped_status { get; set; }
            public decimal? ped_valortotal { get; set; }

            public int cli_codigo { get; set; }
            public string cli_nome { get; set; }
            public string cli_endereco { get; set; }
            public string cli_numero { get; set; }
            public string cli_bairro { get; set; }
            public string cli_cidade { get; set; }
            public string cli_uf { get; set; }
            public string cli_cep { get; set; }
            public string cli_cpfcnpj { get; set; }
            public string cli_sexo { get; set; }
            public string cli_email { get; set; }

            public int pro_codigo { get; set; }
            public string pro_nome { get; set; }
            public decimal pro_quantidade { get; set; }
            public decimal pro_valor { get; set; }
            public decimal pro_valortotal { get; set; }
        }

        public List<imprimePedido> sourceRelatorioPedido(int cod)
        {
            Table<itenspedido> itens = acessoLinqTabelas.getTabelaItensPedido();

            var result = (from i in itens
                          where i.idpedido == cod
                          select new imprimePedido
                          {
                              ped_codigo = i.pedido.idpedidos,
                              ped_data_registro = i.pedido.data.Value,
                              ped_data_liberacao = i.pedido.dataliberacao.Value,
                              ped_data_entrega = i.pedido.dataentregue.Value,
                              ped_data_pagamento = i.pedido.datapagamento.Value,
                              ped_status = i.pedido.statuspedido1.descricao,
                              ped_valortotal = i.pedido.valortotal,

                              cli_codigo = i.pedido.cliente.idclientes,
                              cli_nome = i.pedido.cliente.nome,
                              cli_endereco = i.pedido.cliente.endereco,
                              cli_numero = i.pedido.cliente.numero,
                              cli_bairro = i.pedido.cliente.bairro,
                              cli_cidade = i.pedido.cliente.cidade1.Nome,
                              cli_uf = i.pedido.cliente.estado.Sigla,
                              cli_cep = i.pedido.cliente.cep,
                              cli_cpfcnpj = i.pedido.cliente.cpf_cnpj,
                              cli_sexo = i.pedido.cliente.sexo1.descricao,
                              cli_email = i.pedido.cliente.email,

                              pro_codigo = i.idproduto,
                              pro_nome = i.produto.nome,
                              pro_quantidade = i.quantidade,
                              pro_valor = i.valor,
                              pro_valortotal = i.valortotal
                          }
                              ).ToList();

            return result;
        }

        public List<imprimePedido> relatorioPedidoCompleto(DateTime date1, DateTime date2, int status)
        {
            Table<itenspedido> itens = acessoLinqTabelas.getTabelaItensPedido();

            if (status == 0)
            {
                var result = (from i in itens
                              where i.pedido.data.Value >= date1 && i.pedido.data.Value <= date2
                              select new imprimePedido
                              {
                                  ped_codigo = i.pedido.idpedidos,
                                  ped_data_registro = i.pedido.data.Value,
                                  ped_data_liberacao = i.pedido.dataliberacao.Value,
                                  ped_data_entrega = i.pedido.dataentregue.Value,
                                  ped_data_pagamento = i.pedido.datapagamento.Value,
                                  ped_status = i.pedido.statuspedido1.descricao,
                                  ped_valortotal = i.pedido.valortotal,

                                  cli_codigo = i.pedido.cliente.idclientes,
                                  cli_nome = i.pedido.cliente.nome,
                                  cli_endereco = i.pedido.cliente.endereco,
                                  cli_numero = i.pedido.cliente.numero,
                                  cli_bairro = i.pedido.cliente.bairro,
                                  cli_cidade = i.pedido.cliente.cidade1.Nome,
                                  cli_uf = i.pedido.cliente.estado.Sigla,
                                  cli_cep = i.pedido.cliente.cep,
                                  cli_cpfcnpj = i.pedido.cliente.cpf_cnpj,
                                  cli_sexo = i.pedido.cliente.sexo1.descricao,
                                  cli_email = i.pedido.cliente.email,

                                  pro_codigo = i.idproduto,
                                  pro_nome = i.produto.nome,
                                  pro_quantidade = i.quantidade,
                                  pro_valor = i.valor,
                                  pro_valortotal = i.valortotal
                              }
                                  ).ToList();

                return result;
            }
            else
            {
                var result = (from i in itens
                              where i.pedido.data.Value >= date1 && i.pedido.data.Value <= date2 && i.pedido.statuspedido == status
                              select new imprimePedido
                              {
                                  ped_codigo = i.pedido.idpedidos,
                                  ped_data_registro = i.pedido.data.Value,
                                  ped_data_liberacao = i.pedido.dataliberacao.Value,
                                  ped_data_entrega = i.pedido.dataentregue.Value,
                                  ped_data_pagamento = i.pedido.datapagamento.Value,
                                  ped_status = i.pedido.statuspedido1.descricao,
                                  ped_valortotal = i.pedido.valortotal,

                                  cli_codigo = i.pedido.cliente.idclientes,
                                  cli_nome = i.pedido.cliente.nome,
                                  cli_endereco = i.pedido.cliente.endereco,
                                  cli_numero = i.pedido.cliente.numero,
                                  cli_bairro = i.pedido.cliente.bairro,
                                  cli_cidade = i.pedido.cliente.cidade1.Nome,
                                  cli_uf = i.pedido.cliente.estado.Sigla,
                                  cli_cep = i.pedido.cliente.cep,
                                  cli_cpfcnpj = i.pedido.cliente.cpf_cnpj,
                                  cli_sexo = i.pedido.cliente.sexo1.descricao,
                                  cli_email = i.pedido.cliente.email,

                                  pro_codigo = i.idproduto,
                                  pro_nome = i.produto.nome,
                                  pro_quantidade = i.quantidade,
                                  pro_valor = i.valor,
                                  pro_valortotal = i.valortotal
                              }
                                  ).ToList();

                return result;
            }
        }

        public List<pesqPedido> relatorioPedidoSimples(DateTime data1, DateTime data2, int status)
        {
            Table<pedido> pedido = acessoLinqTabelas.getTabelaPedido();

            if (status == 0)
            {
                return (from p in pedido
                        where p.data >= data1.Date && p.data <= data2.Date
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
            else
            {
                return (from p in pedido
                        where p.data >= data1.Date && p.data <= data2.Date && p.statuspedido == status
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
        }

        public List<cliente> mostraClientePedido(int cod)
        {
            Table<pedido> ped = acessoLinqTabelas.getTabelaPedido();

            return (from p in ped
                    where p.idpedidos == cod
                    select p.cliente).ToList();
        }

        //Atualiza um pedido existe
        public void atualizaPedido(Pedidos obj_pedidos)
        {
            try
            {
                hskDataContext hsk = new hskDataContext();
                var achaIdPed = (from p in hsk.GetTable<pedido>()
                                 where p.idpedidos == obj_pedidos.idPedidos
                                 select p).SingleOrDefault();

                if (achaIdPed != null)
                {
                    achaIdPed.idcliente = obj_pedidos.idCliente;
                    achaIdPed.valortotal = obj_pedidos.valorTotal;
                    achaIdPed.datamodificacao = DateTime.Now.Date;
                    
                    hsk.SubmitChanges();
                    System.Windows.Forms.MessageBox.Show("Pedido atualizado com sucesso.");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("ERRO: Não foi possível atualizar o pedido.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Deleta um pedido existente
        public void deletaPedido(int cod)
        {
            hskDataContext hsk = new hskDataContext();
            var achaIdPed = (from p in hsk.GetTable<pedido>()
                             where p.idpedidos == cod
                             select p).SingleOrDefault();
            try
            {
                hsk.pedidos.DeleteOnSubmit(achaIdPed);
                hsk.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public class pesqPedido
        {
            public int id { get; set; }
            public DateTime? data { get; set; }
            public string cliente { get; set; }
            public decimal? valor { get; set; }
            public string pagamento { get; set; }
            public string status { get; set; }
        }

        public List<pesqPedido> pesqPedidoCODIGO(int codigo, int status)
        {
            Table<pedido> pedido = acessoLinqTabelas.getTabelaPedido();

            if (status == 0)
            {
                return (from p in pedido
                        where p.idpedidos == codigo && p.statuspedido > status
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
            else
            {
                return (from p in pedido
                        where p.idpedidos == codigo && p.statuspedido == status
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
        }

        public List<pesqPedido> pesqPedidoCODCLIENTE(int codigo, int status)
        {
            Table<pedido> pedido = acessoLinqTabelas.getTabelaPedido();

            if (status == 0)
            {
                return (from p in pedido
                        where p.idcliente == codigo && p.statuspedido > status
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
            else
            {
                return (from p in pedido
                        where p.idcliente == codigo && p.statuspedido == status
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
        }

        public List<pesqPedido> pesqPedidoCLIENTE(string nome, int status)
        {
            Table<pedido> pedido = acessoLinqTabelas.getTabelaPedido();

            if (status == 0)
            {
                return (from p in pedido
                        where p.cliente.nome.StartsWith(nome) && p.statuspedido > status
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
            else
            {
                return (from p in pedido
                        where p.cliente.nome.StartsWith(nome) && p.statuspedido == status
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
        }

        public List<pesqPedido> pesqPedidoDATA(DateTime data, int status)
        {
            Table<pedido> pedido = acessoLinqTabelas.getTabelaPedido();

            if (status == 0)
            {
                return (from p in pedido
                        where p.data == data && p.statuspedido > status
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
            else
            {
                return (from p in pedido
                        where p.data == data && p.statuspedido == status
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
        }

        public List<pesqPedido> pesqPedidoDATALIB(DateTime data, int status)
        {
            Table<pedido> pedido = acessoLinqTabelas.getTabelaPedido();

            if (status == 0)
            {
                return (from p in pedido
                        where p.dataliberacao == data && p.statuspedido > 1
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
            else
            {
                return (from p in pedido
                        where p.dataliberacao == data && p.statuspedido == status
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
        }

        public List<pesqPedido> pesqPedidoDATAENTR(DateTime data, int status)
        {
            Table<pedido> pedido = acessoLinqTabelas.getTabelaPedido();

            if (status == 0)
            {
                return (from p in pedido
                        where p.dataentregue == data && p.statuspedido > 2
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
            else
            {
                return (from p in pedido
                        where p.dataentregue == data && p.statuspedido == status
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
        }

        public List<pesqPedido> pesqPedidoDATAPAG(DateTime data, int status)
        {
            Table<pedido> pedido = acessoLinqTabelas.getTabelaPedido();

            if (status == 0)
            {
                return (from p in pedido
                        where p.datapagamento == data && p.statuspedido > 1
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
            else
            {
                return (from p in pedido
                        where p.datapagamento == data && p.statuspedido == status
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
        }

        public List<pesqPedido> pesqPedidoPAGAMENTO(int controle)
        {
            Table<pedido> pedido = acessoLinqTabelas.getTabelaPedido();

            if (controle == 0)
            {
                return (from p in pedido
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
            else if (controle == 1)
            {
                return (from p in pedido
                        where p.datapagamento == null
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
            else
            {
                return (from p in pedido
                        where p.datapagamento != null
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
        }

        public List<pesqPedido> pesqPedidoSTATUS(int status)
        {
            Table<pedido> pedido = acessoLinqTabelas.getTabelaPedido();

            if (status == 0)
            {
                return (from p in pedido
                        where p.statuspedido > status
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
            else
            {
                return (from p in pedido
                        where p.statuspedido == status
                        select new pesqPedido
                        {
                            id = p.idpedidos,
                            data = p.data,
                            cliente = p.cliente.nome,
                            valor = p.valortotal,
                            pagamento = p.datapagamento.Value != null ? "Efetuado" : "Não efetuado",
                            status = p.statuspedido1.descricao
                        }).ToList();
            }
        }

        //gerenciamento do pedido
        public void liberarPedido(int cod)
        {
            try
            {
                hskDataContext hsk = new hskDataContext();
                var achaIdPed = (from p in hsk.GetTable<pedido>()
                                 where p.idpedidos == cod
                                 select p).SingleOrDefault();

                if (achaIdPed != null)
                {
                    achaIdPed.dataliberacao = DateTime.Now.Date;
                    achaIdPed.statuspedido = 2;

                    hsk.SubmitChanges();
                    System.Windows.Forms.MessageBox.Show("Pedido liberado com sucesso.");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("ERRO: Não foi possível liberar o pedido.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void confirmarEntrega(int cod)
        {
            try
            {
                hskDataContext hsk = new hskDataContext();
                var achaIdPed = (from p in hsk.GetTable<pedido>()
                                 where p.idpedidos == cod
                                 select p).SingleOrDefault();

                if (achaIdPed != null)
                {
                    achaIdPed.dataentregue = DateTime.Now.Date;
                    achaIdPed.statuspedido = 3;

                    hsk.SubmitChanges();
                    System.Windows.Forms.MessageBox.Show("Entrega confirmada com sucesso.");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("ERRO: Não foi possível confirmar a entrega.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void confirmarPagamento(int cod)
        {
            try
            {
                hskDataContext hsk = new hskDataContext();
                var achaIdPed = (from p in hsk.GetTable<pedido>()
                                 where p.idpedidos == cod
                                 select p).SingleOrDefault();

                if (achaIdPed != null)
                {
                    achaIdPed.datapagamento = DateTime.Now.Date;

                    hsk.SubmitChanges();
                    System.Windows.Forms.MessageBox.Show("Pagamento confirmado com sucesso.");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("ERRO: Não foi possível confirmar o pagamento.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
