using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Servidores
{
    protected string _ip;
    protected string _nombre;

    public Servidores(string ip, string nombre)
    {
        _ip = ip;
        _nombre = nombre;
    }

    public string ip { 
    
        get { return _ip; }
        set { _ip = value; }
    }
    public string nombre
    {

        get { return _nombre; }
        set { _nombre = value; }
    }


}

