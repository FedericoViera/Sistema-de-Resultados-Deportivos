using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Menu_Backoffice_Controles
{
    public partial class Navegacion_Publicitario : UserControl
    {
        protected string seleccion;
        public delegate void StatusUpdateHandler(string control);
        public event StatusUpdateHandler CambiarControl;
        public Navegacion_Publicitario()
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
            btnAsignaciones.IndicateFocus = false;
            btnBanners.IndicateFocus = false;
            btnCrearEvento.IndicateFocus = false;
            btnImagenes.IndicateFocus = false;
            switch (seleccion)
            {
                case "asignaciones":
                    btnAsignaciones.IndicateFocus = true;
                    break;
                case "banners":
                    btnBanners.IndicateFocus = true;
                    break;
                case "gestionEventos":
                    btnCrearEvento.IndicateFocus = true;
                    break;
                case "imagenes":
                    btnImagenes.IndicateFocus = true;
                    break;
                default:
                    break;
            }
        }
        private void btnAsignaciones_Click(object sender, EventArgs e)
        {
            seleccion = "asignaciones";
            ActualizarControl(seleccion);
        }

        private void btnBanners_Click(object sender, EventArgs e)
        {
            seleccion = "banners";
            ActualizarControl(seleccion);
        }

        private void btnSubirImagenes_Click(object sender, EventArgs e)
        {
            seleccion = "imagenes";
            ActualizarControl(seleccion);

        }

        private void btnCrearEvento_Click(object sender, EventArgs e)
        {
            seleccion = "eventos";
            ActualizarControl(seleccion);
        }
    }
}
