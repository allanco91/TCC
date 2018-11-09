using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using SHOP.Model;

namespace SHOP.DAL
{
    public class dalCliente
    {
        public void insereCliente(Clientes obj_clientes)
        {
            try
            {
                Table<cliente> cliente = acessoLinqTabelas.getTabelaCliente();
                cliente cli = new cliente();

                cli.nome = obj_clientes.nome;
                cli.telefone = obj_clientes.telefone;
                cli.sexo = obj_clientes.sexo;
                cli.email = obj_clientes.email;
                cli.endereco = obj_clientes.endereco;
                cli.bairro = obj_clientes.bairro;
                cli.numero = obj_clientes.numero;
                cli.cep = obj_clientes.cep;
                cli.uf = obj_clientes.uf;
                cli.cidade = obj_clientes.cidade;
                cli.status = obj_clientes.status;
                cli.cpf_cnpj = obj_clientes.cpfcnpj;

                cliente.InsertOnSubmit(cli);
                cliente.Context.SubmitChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Atualiza um cliente existe
        public void atualizaCliente(Clientes obj_clientes)
        {
            try
            {
                hskDataContext hsk = new hskDataContext();

                var achaIdCli = (from c in hsk.GetTable<cliente>()
                                 where c.idclientes == obj_clientes.idClientes
                                 select c).SingleOrDefault();

                if (achaIdCli != null)
                {                  
                    achaIdCli.nome = obj_clientes.nome;
                    achaIdCli.telefone = obj_clientes.telefone;
                    achaIdCli.sexo = obj_clientes.sexo;
                    achaIdCli.email = obj_clientes.email;
                    achaIdCli.endereco = obj_clientes.endereco;
                    achaIdCli.bairro = obj_clientes.bairro;
                    achaIdCli.numero = obj_clientes.numero;
                    achaIdCli.cep = obj_clientes.cep;
                    achaIdCli.uf = obj_clientes.uf;
                    achaIdCli.cidade = obj_clientes.cidade;
                    achaIdCli.status = obj_clientes.status;
                    achaIdCli.cpf_cnpj = obj_clientes.cpfcnpj;
                    
                    hsk.SubmitChanges();

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("ERRO: Não foi possível atualizar o cliente.","ERRO");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Deleta uma cliente existente
        public void deletaCliente(int codigo)
        {
            int i = (from ped in acessoLinqTabelas.getTabelaPedido()
                     where ped.idcliente == codigo
                     select ped).Count();

            if (i == 0)
            {
                hskDataContext hsk = new hskDataContext();

                var achaIdCli = (from c in hsk.GetTable<cliente>()
                                 where c.idclientes == codigo
                                 select c).SingleOrDefault();
                try
                {
                    hsk.clientes.DeleteOnSubmit(achaIdCli);
                    hsk.SubmitChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else System.Windows.Forms.MessageBox.Show("ERRO: Não foi possível excluir o cliente, porque há um ou mais pedidos cadastrados com o mesmo.", "ERRO");
        }

        //Lista geral de clientes
        public List<cliente> listarClientes()
        {
            Table<cliente> cliente = acessoLinqTabelas.getTabelaCliente();

            return (from cli in cliente
                    select cli).ToList<cliente>();
        }

        //Acha cliente apartir do parâmetro id
        public List<cliente> achaClienteId(int id)
        {
            Table<cliente> cliente = acessoLinqTabelas.getTabelaCliente();

            return (from cli in cliente
                    where cli.idclientes == id
                    select cli).ToList<cliente>();
        }

        public class mostraCliente
        {
            public int idclientes { get; set; }
            public string nome { get; set; }
            public string endereco { get; set; }
            public string bairro { get; set; }
            public string numero { get; set; }
            public string cep { get; set; }
            public string uf { get; set; }
            public string cidade { get; set; }
            public string telefone { get; set; }
            public string sexo { get; set; }
            public string email { get; set; }
            public string cpfcnpj { get; set; }
            public bool status { get; set; }
        }

        public List<mostraCliente> sourceRelatorioCliente()
        {
            Table<cliente> cliente = acessoLinqTabelas.getTabelaCliente();

            var result = (from c in cliente
                          select new mostraCliente
                          {
                              idclientes = c.idclientes,
                              nome = c.nome,
                              endereco = c.endereco,
                              bairro = c.bairro,
                              numero = c.numero,
                              cep = c.cep,
                              uf = c.estado.Sigla,
                              cidade = c.cidade1.Nome,
                              telefone = c.telefone,
                              sexo = c.sexo1.descricao,
                              email = c.email,
                              cpfcnpj = c.cpf_cnpj,
                              status = c.status

                          }).ToList();

            return result;
        }

        #region pesqCliente

        public List<mostraCliente> pesqClienteCODIGO(int codigo, bool status)
        {
            Table<cliente> cliente = acessoLinqTabelas.getTabelaCliente();

            return (from c in cliente
                    where c.idclientes == codigo && c.status == status
                    select new mostraCliente
                    {
                        idclientes = c.idclientes,
                        nome = c.nome,
                        endereco = c.endereco,
                        bairro = c.bairro,
                        numero = c.numero,
                        cep = c.cep,
                        uf = c.estado.Sigla,
                        cidade = c.cidade1.Nome,
                        telefone = c.telefone,
                        sexo = c.sexo1.descricao,
                        email = c.email,
                        cpfcnpj = c.cpf_cnpj,
                        status = c.status
                    }).ToList<mostraCliente>();
        }

        public List<mostraCliente> pesqClienteNOME(string nome, bool status)
        {
            Table<cliente> cliente = acessoLinqTabelas.getTabelaCliente();

            return (from c in cliente
                    where c.nome.StartsWith(nome) && c.status == status
                    select new mostraCliente
                    {
                        idclientes = c.idclientes,
                        nome = c.nome,
                        endereco = c.endereco,
                        bairro = c.bairro,
                        numero = c.numero,
                        cep = c.cep,
                        uf = c.estado.Sigla,
                        cidade = c.cidade1.Nome,
                        telefone = c.telefone,
                        sexo = c.sexo1.descricao,
                        email = c.email,
                        cpfcnpj = c.cpf_cnpj,
                        status = c.status
                    }).ToList<mostraCliente>();
        }

        public List<mostraCliente> pesqClienteENDCIDUF(string endereco,int cidade,int estado, bool status)
        {
            Table<cliente> cliente = acessoLinqTabelas.getTabelaCliente();

            return (from c in cliente
                    where c.endereco.StartsWith(endereco) && c.uf == estado && c.cidade == cidade && c.status == status
                    select new mostraCliente
                    {
                        idclientes = c.idclientes,
                        nome = c.nome,
                        endereco = c.endereco,
                        bairro = c.bairro,
                        numero = c.numero,
                        cep = c.cep,
                        uf = c.estado.Sigla,
                        cidade = c.cidade1.Nome,
                        telefone = c.telefone,
                        sexo = c.sexo1.descricao,
                        email = c.email,
                        cpfcnpj = c.cpf_cnpj,
                        status = c.status
                    }).ToList<mostraCliente>();
        }

        public List<mostraCliente> pesqClienteCIDUF(int cidade, int estado, bool status)
        {
            Table<cliente> cliente = acessoLinqTabelas.getTabelaCliente();

            return (from c in cliente
                    where c.uf == estado && c.cidade == cidade && c.status == status
                    select new mostraCliente
                    {
                        idclientes = c.idclientes,
                        nome = c.nome,
                        endereco = c.endereco,
                        bairro = c.bairro,
                        numero = c.numero,
                        cep = c.cep,
                        uf = c.estado.Sigla,
                        cidade = c.cidade1.Nome,
                        telefone = c.telefone,
                        sexo = c.sexo1.descricao,
                        email = c.email,
                        cpfcnpj = c.cpf_cnpj,
                        status = c.status
                    }).ToList<mostraCliente>();
        }

        public List<mostraCliente> pesqClienteUF(int estado, bool status)
        {
            Table<cliente> cliente = acessoLinqTabelas.getTabelaCliente();

            return (from c in cliente
                    where c.uf == estado && c.status == status
                    select new mostraCliente
                    {
                        idclientes = c.idclientes,
                        nome = c.nome,
                        endereco = c.endereco,
                        bairro = c.bairro,
                        numero = c.numero,
                        cep = c.cep,
                        uf = c.estado.Sigla,
                        cidade = c.cidade1.Nome,
                        telefone = c.telefone,
                        sexo = c.sexo1.descricao,
                        email = c.email,
                        cpfcnpj = c.cpf_cnpj,
                        status = c.status
                    }).ToList<mostraCliente>();
        }

        public List<mostraCliente> pesqClienteCEP(string cep, bool status)
        {
            Table<cliente> cliente = acessoLinqTabelas.getTabelaCliente();

            return (from c in cliente
                    where c.cep.StartsWith(cep) && c.status == status
                    select new mostraCliente
                    {
                        idclientes = c.idclientes,
                        nome = c.nome,
                        endereco = c.endereco,
                        bairro = c.bairro,
                        numero = c.numero,
                        cep = c.cep,
                        uf = c.estado.Sigla,
                        cidade = c.cidade1.Nome,
                        telefone = c.telefone,
                        sexo = c.sexo1.descricao,
                        email = c.email,
                        cpfcnpj = c.cpf_cnpj,
                        status = c.status
                    }).ToList<mostraCliente>();
        }

        public List<mostraCliente> pesqClienteTELEFONE(string telefone, bool status)
        {
            Table<cliente> cliente = acessoLinqTabelas.getTabelaCliente();

            return (from c in cliente
                    where c.telefone.StartsWith(telefone) && c.status == status
                    select new mostraCliente
                    {
                        idclientes = c.idclientes,
                        nome = c.nome,
                        endereco = c.endereco,
                        bairro = c.bairro,
                        numero = c.numero,
                        cep = c.cep,
                        uf = c.estado.Sigla,
                        cidade = c.cidade1.Nome,
                        telefone = c.telefone,
                        sexo = c.sexo1.descricao,
                        email = c.email,
                        cpfcnpj = c.cpf_cnpj,
                        status = c.status
                    }).ToList<mostraCliente>();
        }

        public List<mostraCliente> pesqClienteSEXOTIPO(char sexotipo, bool status)
        {
            Table<cliente> cliente = acessoLinqTabelas.getTabelaCliente();

            return (from c in cliente
                    where c.sexo == sexotipo && c.status == status
                    select new mostraCliente
                    {
                        idclientes = c.idclientes,
                        nome = c.nome,
                        endereco = c.endereco,
                        bairro = c.bairro,
                        numero = c.numero,
                        cep = c.cep,
                        uf = c.estado.Sigla,
                        cidade = c.cidade1.Nome,
                        telefone = c.telefone,
                        sexo = c.sexo1.descricao,
                        email = c.email,
                        cpfcnpj = c.cpf_cnpj,
                        status = c.status
                    }).ToList<mostraCliente>();
        }

        public List<mostraCliente> pesqClienteEMAIL(string email, bool status)
        {
            Table<cliente> cliente = acessoLinqTabelas.getTabelaCliente();

            return (from c in cliente
                    where c.email.StartsWith(email) && c.status == status
                    select new mostraCliente
                    {
                        idclientes = c.idclientes,
                        nome = c.nome,
                        endereco = c.endereco,
                        bairro = c.bairro,
                        numero = c.numero,
                        cep = c.cep,
                        uf = c.estado.Sigla,
                        cidade = c.cidade1.Nome,
                        telefone = c.telefone,
                        sexo = c.sexo1.descricao,
                        email = c.email,
                        cpfcnpj = c.cpf_cnpj,
                        status = c.status
                    }).ToList<mostraCliente>();
        }

        public List<mostraCliente> pesqClienteCPFCNPJ(string cpfcnpj, bool status)
        {
            Table<cliente> cliente = acessoLinqTabelas.getTabelaCliente();

            return (from c in cliente
                    where c.cpf_cnpj.StartsWith(cpfcnpj) && c.status == status
                    select new mostraCliente
                    {
                        idclientes = c.idclientes,
                        nome = c.nome,
                        endereco = c.endereco,
                        bairro = c.bairro,
                        numero = c.numero,
                        cep = c.cep,
                        uf = c.estado.Sigla,
                        cidade = c.cidade1.Nome,
                        telefone = c.telefone,
                        sexo = c.sexo1.descricao,
                        email = c.email,
                        cpfcnpj = c.cpf_cnpj,
                        status = c.status
                    }).ToList<mostraCliente>();
        }

        public List<mostraCliente> pesqClienteSTATUS(bool status)
        {
            Table<cliente> cliente = acessoLinqTabelas.getTabelaCliente();

            return (from c in cliente
                    where c.status == status
                    select new mostraCliente
                    {
                        idclientes = c.idclientes,
                        nome = c.nome,
                        endereco = c.endereco,
                        bairro = c.bairro,
                        numero = c.numero,
                        cep = c.cep,
                        uf = c.estado.Sigla,
                        cidade = c.cidade1.Nome,
                        telefone = c.telefone,
                        sexo = c.sexo1.descricao,
                        email = c.email,
                        cpfcnpj = c.cpf_cnpj,
                        status = c.status
                    }).ToList<mostraCliente>();
        }
        #endregion
    }
}
