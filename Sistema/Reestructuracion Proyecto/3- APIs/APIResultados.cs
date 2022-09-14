using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class APIResultados
    {

         public string obtenerNoticiasRecientes()
        {         
            return JsonConvert.SerializeObject(Controlador.obtenerListaNoticiasUsuariosPublicos());    
        }
    public string obtenerResultadosEquiposRecientes()
    {
        return JsonConvert.SerializeObject(Controlador.obtenerListaResulatadosEquiposUsuariosPublicos());
    }
}