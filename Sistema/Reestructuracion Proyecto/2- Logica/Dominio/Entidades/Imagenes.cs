

namespace Proyecto._2__Logica.Dominio.Entidades
{
    public class Imagenes
    {
        protected int _id;
        protected string _nombre;
        protected string _origen;
        protected string _empresa;

        public Imagenes(int id, string nombre, string origen, string empresa)
        {
            _id = id;
            _nombre = nombre;
            _origen = origen;
            _empresa = empresa;
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

        public string origen
        {
            get { return _origen; }
            set { _origen = value; }
        }
        public string empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }
    }
}
