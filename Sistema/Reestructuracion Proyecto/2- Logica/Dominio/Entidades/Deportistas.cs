
    public class Deportistas
    {
    protected int _id;
    protected string _nombre;
    protected string _apellido;
    protected string _pais;
    protected string _deporte;
    protected string _equipo;
    public Deportistas(int id, string nombre, string apellido, string pais, string deporte,string equipo)
    {
        _id = id;
        _nombre = nombre;
        _apellido = apellido;
        _pais = pais;
        _deporte = deporte;
        _equipo = equipo;
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

    public string apellido
    {
        get { return _apellido; }
        set { _apellido = value; }
    }

    public string pais
    {
        get { return _pais; }
        set { _pais = value; }
    }

    public string deporte
    {
        get { return _deporte; }
        set { _deporte = value; }
    }
    public string equipo
    {
        get { return _equipo; }
        set { _equipo = value; }
    }
}

