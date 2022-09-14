using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Categoria_disciplina
{
    protected int id;
    protected string nombre;

    public Categoria_disciplina(int id, string nombre)
    {
        this.id = id;
        this.nombre = nombre;
    }
    
    public int getId()
    {
        return id;
    }

    public string getNombre()
    {
        return nombre;
    }

}

