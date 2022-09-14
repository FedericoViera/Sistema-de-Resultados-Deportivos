using System;
using System.Windows.Forms;

namespace Reestructuracion_Proyecto._5__BackOffice.Funciones.Notificativo
{
    public partial class Activar_Cuenta : UserControl
    {
        public Activar_Cuenta()
        {
            InitializeComponent();
            actualizarTabla();
        }

        private void actualizarTabla()
        {
            dataSolicitudes.DataSource = Controlador.ListaSolicitudes();
            dataSolicitudes.Columns[0].Visible = false;
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            if (Controlador.AprobarSolicitud(Int16.Parse(dataSolicitudes.CurrentCell.OwningRow.Cells[0].Value.ToString())) == true)
            {
                actualizarTabla();
                MessageBox.Show("Solicitud aprobada exitosamente");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            if (Controlador.EliminarSolicitud(Int16.Parse(dataSolicitudes.CurrentCell.OwningRow.Cells[0].Value.ToString())) == true)
            {
                actualizarTabla();
                MessageBox.Show("Solicitud rechazada exitosamente");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
