using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej1.Entidades;

namespace Ej1.Entidades
{
    public class Usuario
    {
        private string NombreUsuario;
        private string Contrasena;



        public Usuario(string nombreUsu, string pass)
        {
            this.NombreUsuario = nombreUsu;
            this.Contrasena = pass;
        }

        public string NombreDeUsuario
        {
            get => NombreUsuario;
            set => NombreUsuario = value;
        }

        public string Password
        {
            get => Contrasena;
            set => Contrasena = value;
        }
    }
}
