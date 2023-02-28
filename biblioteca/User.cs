using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class User
    {
        private string _usuario;
        private string _senha;
        private string _email;

        public string Usuario { get { return _usuario; } set { _usuario = value; } }
        public string Senha { get { return _senha; } set { _senha = value; } }
        public string Email { get { return _email; } set { _email = value; } }
    }
}
