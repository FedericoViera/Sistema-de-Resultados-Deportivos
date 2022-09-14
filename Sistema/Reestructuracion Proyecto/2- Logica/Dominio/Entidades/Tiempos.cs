using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reestructuracion_Proyecto._2__Logica.Dominio.Entidades
{
    public class Tiempos
    {
        protected int _id_partido;
        protected int _numero_ordinal;
        protected string _equipo1;
        protected int _score_eq_1;
        protected int _score_eq_2;
        protected string _equipo2;
        protected string _detalle_a_destacar;
        protected string _detalle_a_destacar2;

        public Tiempos(int id_partido, int numero_ordinal, string equipo1, int score_eq_1, int score_eq_2, string equipo2, string detalle_a_destacar, string detalle_a_destacar2)
        {
            _id_partido = id_partido;
            _numero_ordinal = numero_ordinal;
            _equipo1 = equipo1;
            _score_eq_1 = score_eq_1;
            _score_eq_2 = score_eq_2;
            _equipo2 = equipo2;
            _detalle_a_destacar = detalle_a_destacar;
            _detalle_a_destacar2 = detalle_a_destacar2;
        }

        public int id_partido
        {
            get { return _id_partido; }
            set { _id_partido = value; }  
        }
        public int tiempo
        {
            get { return _numero_ordinal; }
            set { _numero_ordinal = value; }
        }
        public string detalle1
        {
            get { return _detalle_a_destacar; }
            set { _detalle_a_destacar = value; }
        }
        public string local
        {
            get { return _equipo1; }
            set { _equipo1 = value; }
        }
        public int score_eq_1
        {
            get { return _score_eq_1; }
            set { _score_eq_1 = value; }
        }
        public int score_eq_2
        {
            get { return _score_eq_2; }
            set { _score_eq_2 = value; }
        }
        public string visitante
        {
            get { return _equipo2; }
            set { _equipo2 = value; }
        }

        public string detalle2
        {
            get { return _detalle_a_destacar2; }
            set { _detalle_a_destacar2 = value; }
        }
    }
}
