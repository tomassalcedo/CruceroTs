using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string nombreUsuario;
        private string password;
        private bool esAdmin;

        public Usuario(string nombreUsuario, string password, bool esAdmin)
        {
            this.nombreUsuario = nombreUsuario;
            this.password = password;
            this.esAdmin = esAdmin;
        }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public bool EsAdmin { get => esAdmin; set => esAdmin = value; }

        private string MostrarDatosUsuario()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.nombreUsuario);

            return sb.ToString();


        }


        public bool VerificarPassword(string password)
        {
            bool retorno = false;

            if (this.Password == password)
            {
                retorno = true;
            }

            return retorno;
        }

        public bool VerificarPassword(List<Usuario> usuarios, string password)
        {
            bool retorno = false;

            if (usuarios is not null)
            {
                foreach (Usuario usuario in Datos.HardcodearUsuarios())
                {
                    if (usuario.Password == password)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }


        public bool VerificarPassword(List<Usuario> usuarios, string password, string nombreUsuario)
        {
            bool retorno = false;

            if (usuarios is not null)
            {
                foreach (Usuario usuario in Datos.HardcodearUsuarios())
                {
                    if (usuario.Password == password && usuario.NombreUsuario == nombreUsuario)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }


        public override string ToString()
        {
            return MostrarDatosUsuario();
        }


    }
}
