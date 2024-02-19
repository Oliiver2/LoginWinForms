using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LoginWinForms
{
    class Usuario
    {
        public String nombre;
        public String correo;
        public String passwd;

        public static List<Usuario> usuarios = new List<Usuario>();

        public Usuario(string nombre, string passwd, string correo)
        {
            this.nombre = nombre;
            this.passwd = passwd;
            this.correo = correo;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getPasswd()
        {
            return passwd;
        }

        public void setPasswd(String passwd)
        {
            this.passwd = passwd;
        }

        public String getCorreo()
        {
            return correo;
        }

        public void setCorreo(String correo)
        {
            this.correo = correo;
        }

        
    }
}
