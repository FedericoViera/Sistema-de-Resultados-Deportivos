using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class Convertir_A_DataTable
{
    public DataTable Convertir<T>(List<T> items)
    {
        DataTable dataTable = new DataTable(typeof(T).Name);

        PropertyInfo[] Propiedades = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (PropertyInfo propiedad in Propiedades)
        {
            dataTable.Columns.Add(propiedad.Name);
        }
        foreach (T item in items)
        {
            var values = new object[Propiedades.Length];
            for (int i = 0; i < Propiedades.Length; i++)
            {
                values[i] = Propiedades[i].GetValue(item, null);
            }
            dataTable.Rows.Add(values);
        }
        return dataTable;
    }
}
