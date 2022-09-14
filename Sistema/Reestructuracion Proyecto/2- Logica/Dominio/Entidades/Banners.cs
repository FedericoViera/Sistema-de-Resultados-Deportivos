

namespace Proyecto._2__Logica.Dominio.Entidades
{
    public class Banners
    {
        protected int _id;
        protected string _nombre;
        protected string _posicion;

        public Banners (int id, string nombre, string posicion)
        {
            _id = id;
            _nombre = nombre;
            _posicion = posicion;
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string posicion
        {
            get { return _posicion; }
            set { _posicion = value; }
        }

    }
}
