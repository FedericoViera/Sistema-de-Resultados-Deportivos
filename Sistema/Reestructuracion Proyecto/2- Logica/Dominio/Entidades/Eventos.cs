
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Eventos
    {
    protected int _id;
    protected string _anio;
    protected DateTime _fecha_inicio;
    protected DateTime _fecha_fin;
    protected string _pais;
    protected string _disciplina;
    protected string _campeonato;
    protected string _modalidad;
    protected string _culminado;
    public Eventos(
        int id, string anio, DateTime fecha_inicio, DateTime fecha_fin, string pais, string disciplina, string campeonato, string modalidad,string culminado)
    {
        _id = id;
        _anio = anio;
        _fecha_inicio = fecha_inicio;
        _fecha_fin = fecha_fin;
        _pais = pais;
        _disciplina = disciplina;
        _campeonato = campeonato;
        _modalidad = modalidad;
        _culminado = culminado;
    }

    public int id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string campeonato
    {
        get { return _campeonato; }
        set { _campeonato = value; }
    }
    public string anio
    {
        get { return _anio; } 
        set { _anio = value; }
    }

    public string disciplina
    {
        get { return _disciplina; }
        set { _disciplina = value; }
    }

    public string modalidad
    {
        get { return _modalidad; }
        set
        {
            _modalidad = value;
        }
    }
    
    public string pais
    {
        get { return _pais; }
        set
        {
            _pais = value;
        }
    }

    public string fecha_inicio
    {
        get { return _fecha_inicio.ToShortDateString(); }
        set { _fecha_inicio = Convert.ToDateTime(value); }
    }

    public string fecha_fin
    {
        get { return _fecha_fin.ToShortDateString(); }
        set
        {
            _fecha_fin = Convert.ToDateTime(value); ;
        }
    }
    public string culminado
    {
        get { return _culminado; }
        set
        {
            _culminado = value;
        }
    }
}

