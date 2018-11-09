using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using SHOP.Model;

namespace SHOP.DAL
{
    class dalUsuarios
    {
        //Cadastra um usuario
        public void insereUsuario(Usuarios obj_usuarios)
        {
            try
            {
                Table<usuario> usuario = acessoLinqTabelas.getTabelaUsuario();
                usuario user = new DAL.usuario();

                user.login = obj_usuarios.login;
                user.senha = obj_usuarios.senha;
                user.admin = obj_usuarios.admin;

                usuario.InsertOnSubmit(user);
                usuario.Context.SubmitChanges();
                System.Windows.Forms.MessageBox.Show("Cadastro realizado com sucesso","Sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Atualiza um usuario existe
        public void atualizaUsuario(Usuarios obj_usuarios)
        {
            try
            {
                Table<usuario> usuario = acessoLinqTabelas.getTabelaUsuario();

                var achaIdUser = (from u in usuario
                                 where u.id == obj_usuarios.id
                                 select u).SingleOrDefault();

                if (achaIdUser != null)
                {
                    achaIdUser.login = obj_usuarios.login;
                    achaIdUser.senha = obj_usuarios.senha;
                    achaIdUser.admin = obj_usuarios.admin;

                    usuario.Context.SubmitChanges();
                    System.Windows.Forms.MessageBox.Show("Usuario atualizado com sucesso.");

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("ERRO: Não foi possível atualizar o cadastro do usuario.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Deleta um usuario existente
        public void deletaUsuario(int codigo)
        {
            Table<usuario> usuario = acessoLinqTabelas.getTabelaUsuario();

            var achaIdUser = (from u in usuario
                              where u.id == codigo
                              select u).SingleOrDefault();
            try
            {
                usuario.DeleteOnSubmit(achaIdUser);
                usuario.Context.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int logar(string login, string senha)
        {
            Table<usuario> usuario = acessoLinqTabelas.getTabelaUsuario();

            var achaUser = from u in usuario
                            where u.login.Equals(login) && u.senha.Equals(senha)
                            select u;

            if (achaUser.Count() > 0)
            {
                var verAdmin = from u in usuario
                               where u.login.Equals(login) && u.senha.Equals(senha) && u.admin == true
                               select u;
                if (verAdmin.Count() > 0) return 2;
                else return 1;
            }
            else return 0;
        }

        public usuario achaUsuarioID(int cod)
        {
            Table<usuario> usuario = acessoLinqTabelas.getTabelaUsuario();

            return (from u in usuario
                    where u.id == cod
                    select u).SingleOrDefault();
        }

        public class listaUser
        {
            public int id { get; set; }
            public string login { get; set; }
            public string admin { get; set; }
        }

        public List<listaUser> listaUsuario(int cod)
        {
            Table<usuario> usuario = acessoLinqTabelas.getTabelaUsuario();

            return (from u in usuario
                    where u.id == cod
                    select new listaUser
                    {
                        id = u.id,
                        login = u.login,
                        admin = u.admin ? "Administrador" : "Operador"
                    }).ToList();
        }

        public List<listaUser> listaUsuario(string login)
        {
            Table<usuario> usuario = acessoLinqTabelas.getTabelaUsuario();

            return (from u in usuario
                    where u.login.StartsWith(login)
                    select new listaUser
                    {
                        id = u.id,
                        login = u.login,
                        admin = u.admin ? "Administrador" : "Operador"
                    }).ToList();
        }
    }
}
