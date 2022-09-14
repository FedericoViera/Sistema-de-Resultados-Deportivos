using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;

public class Conexion
{
    // private readonly MySqlConnection conexion; 

    private readonly OdbcConnection conexion;
    public Conexion()// se intenta realizar conexion con la base de datos, en caso contrario se muestra un error  
    {                     // y se detiene la ejecucion del programa
        conexion = new OdbcConnection("dsn=chain;uid=root;pwd=");
        try
        {
           
            //conexion = new OdbcConnection("Server=localhost;username=root;password=;database=ChainTechnology_2");
            conexion.Open();
        } catch (Exception) {
                MessageBox.Show("No se pudo realizar la conexion a la base de datos");
                Environment.Exit(0);
                throw;
        }  
    }

    public OdbcConnection GetConexion()
    {
        return conexion;
    }

}
