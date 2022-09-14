using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Disciplinas
{
    protected int _id;
    protected string _nombre;
    protected int _id_categoria;

    public Disciplinas(int id, string nombre, int id_categoria)
    {
        _id = id;
        _nombre = nombre;
        _id_categoria = id_categoria;
    }
    public Disciplinas(int id, string nombre)
    {
        _id = id;
        _nombre = nombre;
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

    public int id_categoria
    {
        get { return _id_categoria; }
        set { _id_categoria = value; }
    }
}

