using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Posiciones_pantalla
{
    protected int _id;
    protected string _nombre;

    public Posiciones_pantalla(int id, string nombre)
    {
        _id = id;
        _nombre = nombre;
    }

    public int id { 
    
        get { return _id; }
        set { _id = value; }
    }
    public string nombre
    {

        get { return _nombre; }
        set { _nombre = value; }
    }


}

