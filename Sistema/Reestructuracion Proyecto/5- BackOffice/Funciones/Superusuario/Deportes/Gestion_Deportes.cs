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
    public partial class Gestion_Deportes : UserControl
    {
        public Gestion_Deportes()
        {
            InitializeComponent();
            cargarInformacion();
        }

        public void cargarInformacion()
        {
            cargarCatDeportes();
            cargarDisciplinas();
        }
        private void btnCrearDepor_Click(object sender, EventArgs e)
        {
            guardarCatDeportes();
            tablaCatDeportes.Sort(tablaCatDeportes.Columns[0], ListSortDirection.Ascending);
        }

        private void cargarCatDeportes()
        {
            tablaCatDeportes.Rows.Clear();
            var catDisc = Controlador.getDominio().categorias_deportes;
            for (int i = 0; i < catDisc.Count; i++)
            {
                tablaCatDeportes.Rows.Add(catDisc.ElementAt(i).getNombre());
            }

        }
        private void cargarDisciplinas()
        {
            tablaDeportes.Rows.Clear();
            var disciplinas = Controlador.getDominio().deportes;
            for (int i = 0; i < disciplinas.Count; i++)
            {
                tablaDeportes.Rows.Add(disciplinas.ElementAt(i).nombre);
            }

        }
        private void guardarCatDeportes()
        {
            bool existe = true;
            for (int i = 0; i < tablaCatDeportes.Rows.Count - 1; i++)
            {
                if (Controlador.guardarCatDeportes(txtAgregarCatDep.Text) == false)
                {
                    existe = false;
                    tablaCatDeportes.Rows.Add(txtAgregarCatDep.Text);
                }
            }
            if (existe == true)
            {
                MessageBox.Show("Nombre de categoria ya existe");
            }
            else
            {
                MessageBox.Show("Creado correctamente");
            }
        }

        private void btnEliminarCatDep_Click(object sender, EventArgs e)
        {

            if (Controlador.eliminarCatDeportes(tablaCatDeportes.CurrentCell.OwningRow.Cells[0].Value.ToString()) == true)
            {
                tablaCatDeportes.Rows.RemoveAt(tablaCatDeportes.CurrentCell.RowIndex);
            }
        }


        private void btnAgregarDeporte_Click(object sender, EventArgs e)
        {
            bool existe = true;
            int contador = tablaDeportes.Rows.Count - 1;
            for (int i = 0; i < contador; i++)
            {
                if (Controlador.guardarDeportes(txtDeporte.Text) == false)
                {
                    existe = false;
                    tablaDeportes.Rows.Add(txtDeporte.Text);
                    tablaDeportes.Sort(tablaDeportes.Columns[0], ListSortDirection.Ascending);
                }
            }
            if (existe == true)
            {
                MessageBox.Show("Nombre de categoria ya existe");
            }
            else
            {
                MessageBox.Show("Creado correctamente");
            }
        }

        private void btnEliminarDeporte_Click(object sender, EventArgs e)
        {
            if (Controlador.eliminarDeporte(tablaDeportes.CurrentCell.OwningRow.Cells[0].Value.ToString()) == true)
            {
                tablaDeportes.Rows.RemoveAt(tablaDeportes.CurrentCell.RowIndex);
            }
        }

        private void btnAsociar_Click(object sender, EventArgs e)
        {
            if (Controlador.asociarDeporteConCategoria(txtDeporteAsociar.Text, txtCategoriaAsociar.Text))
            {
                MessageBox.Show("Deporte asociado a la categoria seleccionada");
            }
            else
            {
                MessageBox.Show("Ha habido un error");
            }
        }

        private void tablaCatDeportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoriaAsociar.Text = tablaCatDeportes.SelectedCells[0].Value.ToString();
        }

        private void tablaDeportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDeporteAsociar.Text = tablaDeportes.SelectedCells[0].Value.ToString();
            txtCategoriaAsociar.Text = Controlador.obtenerCategoriaDeDeporte(txtDeporteAsociar.Text);
        }
    }
}
