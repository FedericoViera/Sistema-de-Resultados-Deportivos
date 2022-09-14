using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reestructuracion_Proyecto._2__Logica.Dominio.Entidades
{
    public class Encuentros
    {
        protected int _id;
        protected DateTime _fecha_encuentro;
        protected int _id_evento;

        public Encuentros(int id, DateTime _fecha_partido, int evento)
        {
            this._id = id;
            this._fecha_encuentro = _fecha_partido;
            this._id_evento = evento;
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }        

        public string fecha
        {
            get { return _fecha_encuentro.ToShortDateString(); }
            set { _fecha_encuentro = Convert.ToDateTime(value); }
        }
        public int evento
        {
            get { return _id_evento; }
            set { _id_evento = value; }
        }
    }
}
