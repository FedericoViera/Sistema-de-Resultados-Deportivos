using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Partidos
    {
    protected int _id;
    protected DateTime _fecha_partido;
    protected string _equipo_1;
    protected string _equipo_2;
    protected int _id_evento;

    public Partidos(int id, DateTime _fecha_partido, string equipo_1, string equipo_2, int evento)
    {
        this._id = id;
        this._fecha_partido = _fecha_partido;
        this._equipo_1 = equipo_1;
        this._equipo_2 = equipo_2;
        this._id_evento = evento;
    }

    public int id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string equipo_1
    {
        get { return _equipo_1; }
        set { _equipo_1 = value; }
    }
    public string equipo_2
    {
        get { return _equipo_2; }
        set { _equipo_2 = value; }
    }

    public string fecha
    {
        get { return _fecha_partido.ToShortDateString(); }
        set { _fecha_partido = Convert.ToDateTime(value); }
    }
    public int evento
    {
        get { return _id_evento; }
        set { _id_evento = value; }
    }
}

