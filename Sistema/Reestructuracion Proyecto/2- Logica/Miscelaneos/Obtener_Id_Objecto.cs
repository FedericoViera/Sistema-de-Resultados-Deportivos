using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class Obtener_Id_Objeto
{
    public int Obtener_Id<T>(List<T> items,string nombre)
    {
        int id_objeto = 0;

        PropertyInfo[] Propiedades = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        
        foreach (T item in items)
        {
            var values = new object[Propiedades.Length];
                if (Propiedades[1].GetValue(item, null).ToString() == nombre)
                {
                    id_objeto = Int16.Parse(Propiedades[0].GetValue(item, null).ToString());
                }            
        }
        return id_objeto;
    }
}
