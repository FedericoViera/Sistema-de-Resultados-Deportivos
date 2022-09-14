using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto._2__Logica.Datos
{
    public static class CacheUsuario
    {
        private static bool _existe;
        private static int _id_usuario;
        private static string _nombre_usuario;
        private static string _nombre;
        private static string _apellido;
        private static string _email;
        private static string _string_imagen;
        private static string _rol;

        public static bool existe
        {
            get { return _existe; }
            set { _existe = value; }
        }
        public static int id_usuario
        {
            get { return _id_usuario; }
            set { _id_usuario = value; }
        }

        public static string nombre_usuario
        {
            get { return _nombre_usuario; }
            set { _nombre_usuario = value; }
        }

        public static string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        public static string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public static string correo
        {
            get { return _email; }
            set { _email = value; }
        }

        public static string string_imagen
        {
            get { return _string_imagen; }
            set { _string_imagen = value; }
        }

        public static string rol
        {
            get { return _rol; }
            set { _rol = value; }
        }

    }
}
