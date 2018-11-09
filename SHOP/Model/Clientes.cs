using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHOP.Model
{
    public class Clientes
    {
        public int idClientes { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }
        public int uf { get; set; }
        public int cidade { get; set; }
        public string telefone { get; set; }
        public char sexo { get; set; }
        public string email { get; set; }
        public string cpfcnpj { get; set; }
        public bool status { get; set; }

        public Clientes(int idClientes, string nome, string endereco, string bairro, string numero, string cep, int uf, int cidade, string telefone, char sexo, string email, string cpfcnpj, bool status)
        {
            this.idClientes = idClientes;
            this.nome = nome;
            this.endereco = endereco;
            this.bairro = bairro;
            this.numero = numero;
            this.cep = cep;
            this.uf = uf;
            this.cidade = cidade;
            this.telefone = telefone;
            this.sexo = sexo;
            this.email = email;
            this.cpfcnpj = cpfcnpj;
            this.status = status;
        }

        public Clientes(string nome, string endereco, string bairro, string numero, string cep, int uf, int cidade, string telefone, char sexo, string email, string cpfcnpj, bool status)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.bairro = bairro;
            this.numero = numero;
            this.cep = cep;
            this.uf = uf;
            this.cidade = cidade;
            this.telefone = telefone;
            this.sexo = sexo;
            this.email = email;
            this.cpfcnpj = cpfcnpj;
            this.status = status;
        }
    }
}
