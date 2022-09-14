using System;
using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Menu_Backoffice_Controles
{
    public partial class Navegacion_Notificativo : UserControl
    {
        protected string seleccion;
        public delegate void StatusUpdateHandler(string control);
        public event StatusUpdateHandler CambiarControl;
        public Navegacion_Notificativo()
        {
            InitializeComponent();
        }
        private void ActualizarControl(string control)
        {
            cambiarBotonFocus();
            CambiarControl?.Invoke(control);
        }
        private void cambiarBotonFocus()
        {
            btnActivacion.IndicateFocus = false;
            btnResultados.IndicateFocus = false;
            btnBajas.IndicateFocus = false;
            switch (seleccion)
            {
                case "activacion":
                    btnActivacion.IndicateFocus = true;
                    break;
                case "rebocar":
                    btnBajas.IndicateFocus = true;
                    break;
                case "resultados":
                    btnResultados.IndicateFocus = true;
                    break;
                default:
                    break;
            }
        }        

        private void btnActivacion_Click(object sender, EventArgs e)
        {
            seleccion = "activacion";
            ActualizarControl(seleccion);
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            seleccion = "resultados";
            ActualizarControl(seleccion);
        }


        private void btnBajas_Click(object sender, EventArgs e)
        {
            seleccion = "rebocar";
            ActualizarControl(seleccion);
        }
    }
}
