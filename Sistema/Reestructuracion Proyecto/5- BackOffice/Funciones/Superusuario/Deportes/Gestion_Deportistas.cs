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
    public partial class Gestion_Deportistas : UserControl
    {

        protected int id = 0;
        public Gestion_Deportistas()
        {
            InitializeComponent();
            cargarDeportistas();
            cargarInformacion();
        }

        public void cargarInformacion()
        {
            cargarPaises();
            cargarDeportes();
        }
        private void cargarDeportistas()
        {
            dataGridDeportistas.DataSource = Controlador.Lista_A_DataTable().Convertir<Deportistas>(Controlador.getDominio().deportistas);
            dataGridDeportistas.Columns[0].Visible = false;
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
                case "Agregar deportista":

                    if (Controlador.guardarDeportista(txtNombre.Text, txtApellido.Text, cmoPaises.Text, cmoDeportes.Text) == true)
                    {
                        dataGridDeportistas.DataSource = Controlador.Lista_A_DataTable().Convertir<Deportistas>(Controlador.getDominio().deportistas);
                        dataGridDeportistas.Sort(dataGridDeportistas.Columns[1], ListSortDirection.Ascending);
                        MessageBox.Show("Deportista creado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    break;
                case "Guardar":

                    if (Controlador.editarDeportista(id, txtNombre.Text, txtApellido.Text, cmoPaises.Text, cmoDeportes.Text) == true)
                    {
                        dataGridDeportistas.DataSource = Controlador.Lista_A_DataTable().Convertir<Deportistas>(Controlador.getDominio().deportistas);
                        dataGridDeportistas.Sort(dataGridDeportistas.Columns[1], ListSortDirection.Ascending);
                        MessageBox.Show("Deportista editado con exito");
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
            int indexEncontrado = 0;
            foreach (DataGridViewRow row in dataGridDeportistas.Rows)
            {
                row.Selected = false;
            }
            try
            {
                string[] busqueda = txtBuscar.Text.Split(' ');
                bool encontrado = false;
                foreach (DataGridViewRow row in dataGridDeportistas.Rows)
                {
                    if (busqueda.Length == 1)
                    {
                        if (row.Cells[1].Value.ToString().ToUpper().Equals(busqueda[0].ToUpper()))
                        {
                            dataGridDeportistas.Rows[row.Index].Selected = true;
                            encontrado = true;
                        }
                    }
                    else
                    {
                        if (row.Cells[1].Value.ToString().ToUpper().Equals(busqueda[0].ToUpper()) && row.Cells[2].Value.ToString().ToUpper().Equals(busqueda[1].ToUpper()))
                        {
                            dataGridDeportistas.Rows[row.Index].Selected = true;

                            encontrado = true;
                            indexEncontrado = row.Index;
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
        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }
        private void editar()
        {
            txtNombre.Text = dataGridDeportistas.CurrentCell.OwningRow.Cells[1].Value.ToString();
            txtApellido.Text = dataGridDeportistas.CurrentCell.OwningRow.Cells[2].Value.ToString();
            cmoDeportes.Text = dataGridDeportistas.CurrentCell.OwningRow.Cells[4].Value.ToString();
            cmoPaises.Text = dataGridDeportistas.CurrentCell.OwningRow.Cells[3].Value.ToString();
            btnAgregar.Text = "Guardar";
            id = Int16.Parse(dataGridDeportistas.CurrentCell.OwningRow.Cells[0].Value.ToString());
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
            txtApellido.Text = "";
            txtNombre.Text = "";
            foreach (DataGridViewRow row in dataGridDeportistas.Rows)
            {
                dataGridDeportistas.Rows[row.Index].Selected = false;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Controlador.eliminarDeportista(Int16.Parse(dataGridDeportistas.CurrentCell.OwningRow.Cells[0].Value.ToString()));
            dataGridDeportistas.DataSource = Controlador.Lista_A_DataTable().Convertir<Deportistas>(Controlador.getDominio().deportistas);
            limpiarFiltros();
        }

        private void dataGridDeportistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            editar();
        }
    }
}
