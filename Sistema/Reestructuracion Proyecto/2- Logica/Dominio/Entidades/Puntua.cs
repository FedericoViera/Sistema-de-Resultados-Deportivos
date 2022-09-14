using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reestructuracion_Proyecto._2__Logica.Dominio.Entidades
{
    public class Puntua
    {
        protected int _id_encuentro;
        protected int _numero_ordinal;
        protected int _id_deportista;
        protected string _nombre_deportista;
        protected string _apellido_deportista;
        protected int _puntaje;

        public Puntua(int id_encuentro, int numero_ordinal, int id_deportista, string nombre_deportista, string apellido_deportista, int puntaje)
        {
            _id_encuentro = id_encuentro;
            _numero_ordinal = numero_ordinal;
            _id_deportista = id_deportista;
            _nombre_deportista = nombre_deportista;
            _apellido_deportista = apellido_deportista;
            _puntaje = puntaje;
        }

        public int id_encuentro
        {
            get { return _id_encuentro; }
            set { _id_encuentro = value; }
        }
        public int numero_ordinal
        {
            get { return _numero_ordinal; }
            set { _numero_ordinal = value; }
        }
        public int id_deportista
        {
            get { return _id_deportista; }
            set { _id_deportista = value; }
        }
        public string nombre_deportista
        {
            get { return _nombre_deportista; }
            set { _nombre_deportista = value; }
        }
        public string apellido_deportista
        {
            get { return _apellido_deportista; }
            set { _apellido_deportista = value; }
        }
        public int puntaje
        {
            get { return _puntaje; }
            set { _puntaje = value; }
        }
    }
}
