using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Superusuario.Deportes
{
    public partial class Gestion_Integrantes : UserControl
    {
        private DataTable deportistas_equipo;
        private DataTable deportistas_sin_equipo;

        public Gestion_Integrantes()
        {
            InitializeComponent();
            deportistas_equipo = new DataTable();
            deportistas_sin_equipo = new DataTable();
            cargarInformacion();
        }

        public void cargarInformacion()
        {
            cargarEquipos();
            CargarJugadoresSinEquipo();
        }

        private void cargarEquipos()
        {
            foreach (Equipos item in Controlador.getDominio().equipos)
            {
                cmoEquipos.Items.Add(item.nombre);
            }
            cmoEquipos.Items.Remove("-Sin_equipo-");
        }
        private void CargarJugadoresSinEquipo()
        {
            deportistas_sin_equipo = Controlador.DeportistasDeEquipo("-Sin_equipo-");
            dataGridDeportistas_Sin_Equipo.DataSource = deportistas_sin_equipo;
            dataGridDeportistas_Sin_Equipo.Columns[0].Visible = false;
            dataGridDeportistas_Sin_Equipo.Columns[3].Visible = false;
            dataGridDeportistas_Sin_Equipo.Columns[4].Visible = false;
            dataGridDeportistas_Sin_Equipo.Columns[5].Visible = false;
        }
        private void CargarJugadoresEquipo()
        {
            deportistas_equipo = Controlador.DeportistasDeEquipo(cmoEquipos.Text);
            dataGridDeportistas.DataSource = deportistas_equipo;
            dataGridDeportistas.Columns[0].Visible = false;
            dataGridDeportistas.Columns[3].Visible = false;
            dataGridDeportistas.Columns[4].Visible = false;
            dataGridDeportistas.Columns[5].Visible = false;

        }
        private void cmoEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarJugadoresEquipo();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!(cmoEquipos.Text == ""))
            {
                int fila = dataGridDeportistas_Sin_Equipo.CurrentRow.Index;
                int id_deportista = Int16.Parse(dataGridDeportistas_Sin_Equipo.Rows[fila].Cells[0].Value.ToString());
                Controlador.Integrante_Equipo(cmoEquipos.Text, id_deportista);
                CargarJugadoresSinEquipo();
                CargarJugadoresEquipo();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un equipo primero");
            }


        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (!(cmoEquipos.Text == ""))
            {
                int fila = dataGridDeportistas.CurrentRow.Index;
                int id_deportista = Int16.Parse(dataGridDeportistas.Rows[fila].Cells[0].Value.ToString());
                Controlador.Integrante_Equipo("-Sin_equipo-", id_deportista);
                CargarJugadoresSinEquipo();
                CargarJugadoresEquipo();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un equipo primero");
            }

        }

        private void dataGridDeportistas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridDeportistas_Sin_Equipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridDeportistas.Rows)
            {
                row.Selected = false;
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {

        }
    }
}
