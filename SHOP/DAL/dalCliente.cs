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

        public List<cliente> listarClientes()
        {
            Table<cliente> cliente = acessoLinqTabelas.getTabelaCliente();

            return (from cli in cliente
                    select cli).ToList<cliente>();
        }

        public List<cliente> listarClientesID(int id)
        {
            Table<cliente> cliente = acessoLinqTabelas.getTabelaCliente();

            return (from cli in cliente
                    where cli.idclientes == id
                    select cli).ToList();
        }
    }
}
