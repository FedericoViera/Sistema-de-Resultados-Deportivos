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
    public partial class Gestion_Equipos : UserControl
    {
        protected int id = 0;
        public Gestion_Equipos()
        {
            InitializeComponent();
            cargarInformacion();
        }

        public void cargarInformacion()
        {
            limpiarFiltros();
            cargarEquipos();
            cargarPaises();
            cargarDeportes();
            dataGridEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void cargarEquipos()
        {
            dataGridEquipos.DataSource = Controlador.Lista_A_DataTable().Convertir<Equipos>(Controlador.getDominio().equipos);
         
            dataGridEquipos.Sort(dataGridEquipos.Columns[1], ListSortDirection.Ascending);
            foreach (DataGridViewRow row in dataGridEquipos.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals("-Sin_equipo-"))
                {
                    dataGridEquipos.Rows.Remove(row);
                }
            }
            dataGridEquipos.Columns[0].Visible = false;
        }

        private void cargarPaises()
        {
            cmoPaises.Items.Clear();
            foreach (var item in Controlador.getDominio().paises)
                cmoPaises.Items.Add(item.nombre);
        }
        private void cargarDeportes()
        {
            cmoDeportes.Items.Clear();
            foreach (var item in Controlador.getDominio().deportes)
                cmoDeportes.Items.Add(item.nombre);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (btnAgregar.Text)
            {
                case "Agregar equipo":

                    if (Controlador.guardarEquipos(txtNombre.Text, cmoPaises.Text, cmoDeportes.Text) == true)
                    {
                        cargarEquipos();

                        MessageBox.Show("Equipo creado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    break;
                case "Guardar":

                    if (Controlador.editarEquipo(id, txtNombre.Text, cmoPaises.Text, cmoDeportes.Text) == true)
                    {
                        cargarEquipos();
                        MessageBox.Show("Equipo editado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                    break;
                default:
                    break;
            }
            limpiarFiltros();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] busqueda = txtBuscar.Text.Split(' ');
                bool encontrado = false;
                foreach (DataGridViewRow row in dataGridEquipos.Rows)
                {
                    row.Selected = false;
                }
                foreach (DataGridViewRow row in dataGridEquipos.Rows)
                {
                    if (busqueda.Length == 1)
                    {
                        if (row.Cells[1].Value.ToString().ToUpper().Equals(busqueda[0].ToUpper()))
                        {
                            int rowIndex = row.Index;
                            dataGridEquipos.Rows[rowIndex].Selected = true;
                            encontrado = true;
                            break;
                        }
                    }
                    else
                    {
                        if (row.Cells[1].Value.ToString().ToUpper().Equals(busqueda[0].ToUpper()) && row.Cells[2].Value.ToString().ToUpper().Equals(busqueda[1].ToUpper()))
                        {
                            int rowIndex = row.Index;
                            dataGridEquipos.Rows[rowIndex].Selected = true;
                            dataGridEquipos.Rows[rowIndex].Selected = true;
                            encontrado = true;
                            break;

                        }
                    }

                }
                if (!encontrado)
                {
                    MessageBox.Show("No se encontró a: " + txtBuscar.Text);
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            limpiarFiltros();
        }

        private void limpiarFiltros()
        {
            btnAgregar.Text = "Agregar equipo";
            txtBuscar.Text = "";
            cmoPaises.Text = "";
            cmoDeportes.Text = "";
            txtNombre.Text = "";
            foreach (DataGridViewRow row in dataGridEquipos.Rows)
            {
                dataGridEquipos.Rows[row.Index].Selected = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Controlador.eliminarEquipo(Int16.Parse(dataGridEquipos.CurrentCell.OwningRow.Cells[0].Value.ToString()));
            cargarEquipos();
            limpiarFiltros();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dataGridEquipos.CurrentCell.OwningRow.Cells[1].Value.ToString();
            cmoDeportes.Text = dataGridEquipos.CurrentCell.OwningRow.Cells[2].Value.ToString();
            cmoPaises.Text = dataGridEquipos.CurrentCell.OwningRow.Cells[3].Value.ToString();
            btnAgregar.Text = "Guardar";
            id = Int16.Parse(dataGridEquipos.CurrentCell.OwningRow.Cells[0].Value.ToString());
        }
    }
}
