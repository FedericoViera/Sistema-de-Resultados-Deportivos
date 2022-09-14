using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Equipos
{
    private int _id;
    private string _nombre;
    private string _deporte;
    private string _pais;

    public Equipos(int id, string nombre,string deporte, string pais)
    {
        _id = id;
        _nombre = nombre;
        _deporte = deporte;
        _pais = pais;
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
    public string disciplina
    {
        get { return _deporte; }
        set { _deporte = value; }
    }
    public string pais
    {
        get { return _pais; }
        set { _pais = value; }
    }

}

