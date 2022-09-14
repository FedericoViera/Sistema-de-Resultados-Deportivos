using Proyecto._2__Logica.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Publicitario.Publicidad
{
    public partial class Gestion_Asignaciones : UserControl
    {
        public Gestion_Asignaciones()
        {
            InitializeComponent();
            cargarInformacion();
        }
        public void cargarInformacion()
        {
            cargarBannersUsuariosPublicos();
            cargarBanners();
        }
        private void cargarBanners()
        {
            dataGridBanners.DataSource = Controlador.Lista_A_DataTable().Convertir<Banners>(Controlador.getDominio().banners);
            dataGridBanners.Columns[0].Visible = false;
        }
        private void cargarBannersUsuariosPublicos()
        {
            dataGridUsuarios.DataSource = Controlador.BannersUsuariosPublicos();
            dataGridUsuarios.Sort(dataGridUsuarios.Columns[5], ListSortDirection.Ascending);
            dataGridUsuarios.Columns[0].Visible = false;
            dataGridUsuarios.Columns[2].Visible = false;
            dataGridUsuarios.Columns[3].Visible = false;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridUsuarios.ClearSelection();
            dataGridBanners.ClearSelection();
            txtBuscarBanner.Text = "";
            txtBuscarUsuario.Text = "";

        }

        private void btnAsociar_Click(object sender, EventArgs e)
        {
            int id_banner = Int16.Parse(dataGridBanners.SelectedRows[0].Cells[0].Value.ToString());
            int id_usuario = Int16.Parse(dataGridUsuarios.SelectedRows[0].Cells[0].Value.ToString());
            string tieneBannerAsociado = dataGridUsuarios.SelectedRows[0].Cells[5].Value.ToString();
            Controlador.AsociarBannerUsuario(tieneBannerAsociado,id_usuario, id_banner);
            cargarBannersUsuariosPublicos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int indexEncontrado = 0;
            foreach (DataGridViewRow row in dataGridUsuarios.Rows)
            {
                row.Selected = false;
            }
            try
            {
                string[] busqueda = txtBuscarUsuario.Text.Split(' ');
                bool encontrado = false;
                foreach (DataGridViewRow row in dataGridUsuarios.Rows)
                {
                    if (busqueda.Length == 1)
                    {
                        if (row.Cells[1].Value.ToString().ToUpper().Equals(busqueda[0].ToUpper()))
                        {
                            dataGridUsuarios.Rows[row.Index].Selected = true;
                            encontrado = true;
                        }
                    }
                    else
                    {
                        if (row.Cells[1].Value.ToString().ToUpper().Equals(busqueda[0].ToUpper()) && row.Cells[2].Value.ToString().ToUpper().Equals(busqueda[1].ToUpper()))
                        {
                            dataGridUsuarios.Rows[row.Index].Selected = true;

                            encontrado = true;
                            indexEncontrado = row.Index;
                        }
                    }

                }
                if (!encontrado)
                {
                    MessageBox.Show("No se encontró a: " + txtBuscarUsuario.Text);
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnBuscarBanner_Click(object sender, EventArgs e)
        {
            int indexEncontrado = 0;
            foreach (DataGridViewRow row in dataGridBanners.Rows)
            {
                row.Selected = false;
            }
            try
            {
                string[] busqueda = txtBuscarBanner.Text.Split(' ');
                bool encontrado = false;
                foreach (DataGridViewRow row in dataGridBanners.Rows)
                {
                    if (busqueda.Length == 1)
                    {
                        if (row.Cells[1].Value.ToString().ToUpper().Equals(busqueda[0].ToUpper()))
                        {
                            dataGridBanners.Rows[row.Index].Selected = true;
                            encontrado = true;
                        }
                    }
                    else
                    {
                        if (row.Cells[1].Value.ToString().ToUpper().Equals(busqueda[0].ToUpper()) && row.Cells[2].Value.ToString().ToUpper().Equals(busqueda[1].ToUpper()))
                        {
                            dataGridBanners.Rows[row.Index].Selected = true;

                            encontrado = true;
                            indexEncontrado = row.Index;
                        }
                    }

                }
                if (!encontrado)
                {
                    MessageBox.Show("No se encontró el banner: " + txtBuscarUsuario.Text);
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
