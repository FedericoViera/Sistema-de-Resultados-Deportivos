using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto._2__Logica.Dominio.Entidades
{
    public class ImagenesAsociadas
    {
        protected int _id_imagen;
        protected int _id_banner;

        public ImagenesAsociadas(int id_imagen, int id_banner)
        {
            _id_imagen = id_imagen;
            _id_banner = id_banner;
        }

        public int id_imagen
        {
            get { return _id_imagen; }
            set { _id_imagen = value; }
        }

        public int id_banner
        {
            get { return _id_banner; }
            set { _id_banner = value; }
        }
    }
}
