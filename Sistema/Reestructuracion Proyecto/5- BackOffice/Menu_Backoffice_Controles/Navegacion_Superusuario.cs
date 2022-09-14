using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto._5__BackOffice.Funciones.Superusuario.Deportes;
using Proyecto._5__BackOffice.Superusuario;

namespace Proyecto._5__BackOffice.Menu_Backoffice_Controles
{
    public partial class Navegacion_superusuario : UserControl
    {
        protected string seleccion = "";
        public delegate void StatusUpdateHandler(string control);
        public event StatusUpdateHandler CambiarControl;

        public Gestion_Equipos gestion_Equipos;
        
        public Navegacion_superusuario()
        {
            InitializeComponent();
            gestion_Equipos = new Gestion_Equipos();
        }
        private void ActualizarControl(string control)
        {
            cambiarBotonFocus();
            CambiarControl?.Invoke(control);
        }
        private void cambiarBotonFocus()
        {
            btnDeportistas.IndicateFocus = false;
            btnDisciplinas.IndicateFocus = false;
            btnEquipo.IndicateFocus = false;
            btnIntegrantes.IndicateFocus = false;
            btnMiscelaneo.IndicateFocus = false;
            btnUsuarios.IndicateFocus=false;
            switch (seleccion)
            {
                case "equipo":
                    btnEquipo.IndicateFocus = true;
                    break;
                case "deportistas":
                    btnDeportistas.IndicateFocus = true;
                    break;
                case "deportes":
                    btnDisciplinas.IndicateFocus = true;
                    break;
                case "integrantes":
                    btnIntegrantes.IndicateFocus = true;      
                    break;
                case "usuario":
                    btnUsuarios.IndicateFocus = true;
                    break;
                case "otros":
                    btnMiscelaneo.IndicateFocus = true;
                    break; 
                default:
                    break;
            }
        }

        public void btnEquipo_Click(object sender, EventArgs e)
        {
            seleccion = "equipo";
            ActualizarControl(seleccion);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            seleccion = "usuario";
            ActualizarControl(seleccion);
        }

        private void btnDeportistas_Click(object sender, EventArgs e)
        {
            seleccion = "deportistas";
            ActualizarControl(seleccion);
        }

        private void btnDisciplinas_Click(object sender, EventArgs e)
        {
            seleccion = "deportes";
            ActualizarControl(seleccion);
        }

        private void btnIntegrantes_Click(object sender, EventArgs e)
        {
            seleccion = "integrantes";
            ActualizarControl(seleccion);
        }

        private void btnMiscelaneo_Click(object sender, EventArgs e)
        {
            seleccion = "otros";
            ActualizarControl(seleccion);
        }
    }
}
