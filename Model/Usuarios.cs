using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHOP.Model
{
    class Usuarios
    {
        public int id { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public bool admin { get; set; }

        public Usuarios(int id, string login, string senha, bool admin)
        {
            this.id = id;
            this.login = login;
            this.senha = senha;
            this.admin = admin;
        }

        public Usuarios(string login, string senha, bool admin)
        {
            this.login = login;
            this.senha = senha;
            this.admin = admin;
        }
    }
}
