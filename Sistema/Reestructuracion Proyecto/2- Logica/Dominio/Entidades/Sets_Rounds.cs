using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reestructuracion_Proyecto._2__Logica.Dominio.Entidades
{
    public class Sets_Rounds
    {
        protected int _id_encuentro;
        protected int _numero_ordinal;
        protected string _detalle_a_destacar;

        public Sets_Rounds(int id_encuentro, int numero_ordinal, string detalle_a_destacar)
        {
            _id_encuentro = id_encuentro;
            _numero_ordinal = numero_ordinal;
            _detalle_a_destacar = detalle_a_destacar;
        }

        public int id_encuentro
        {
            get { return _id_encuentro; }
            set { _id_encuentro = value; }
        }

        public string detalle_a_destacar
        {
            get { return _detalle_a_destacar; }
            set { _detalle_a_destacar = value; }
        }
        public int numero_ordinal
        {
            get { return _numero_ordinal; }
            set { _numero_ordinal = value; }
        }
    }
}
