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
    public partial class Gestion_Banners : UserControl
    {
        public Gestion_Banners()
        {
            InitializeComponent();
            cargarInformacion();
        }

        public void cargarInformacion()
        {
            cargarBanners();
            cargarPosiciones();
            cargarImagenesNoAsociadas();
        }
        private void cargarImagenesNoAsociadas()
        {
            dataGridBanners.DataSource = Controlador.Lista_A_DataTable().Convertir<Banners>(Controlador.getDominio().banners);
            dataGridBanners.Columns[0].Visible = false;
        }
        private void cargarBanners()
        {
            dataGridBanners.DataSource = Controlador.Lista_A_DataTable().Convertir<Banners>(Controlador.getDominio().banners);
            dataGridBanners.Columns[0].Visible = false;
        }
        private void cargarPosiciones()
        {
            cmoPosicion.Items.Clear();
            foreach (var item in Controlador.getDominio().posiciones)
                cmoPosicion.Items.Add(item.nombre);
        }

        private void actualizarImagenes()
        {
            dataGridAsociadas.DataSource = Controlador.ImagenesDeBanner(Int16.Parse(dataGridBanners.SelectedRows[0].Cells[0].Value.ToString()));
            dataGridAsociadas.Columns[0].Visible = false;
            dataGridAsociadas.Columns[2].Visible = false;
            dataGridSinAsociar.DataSource = Controlador.ImagenesNoDeBanner(Int16.Parse(dataGridBanners.SelectedRows[0].Cells[0].Value.ToString()));
            dataGridSinAsociar.Columns[0].Visible = false;
            dataGridSinAsociar.Columns[2].Visible = false;
        }
        private void btnCrearBanner_Click(object sender, EventArgs e)
        {
            int id_banner = Int16.Parse(dataGridBanners.SelectedRows[0].Cells[0].Value.ToString());
            switch (btnCrearBanner.Text)
            {
                case "Agregar banner":
                    if (Controlador.guardarBanner("Crear", id_banner, txtNombre.Text, cmoPosicion.Text) == true)
                    {
                        MessageBox.Show("Banner creado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }
                    break;
                case "Guardar":
                    if (Controlador.guardarBanner("Editar", id_banner, txtNombre.Text, cmoPosicion.Text) == true)
                    {
                        MessageBox.Show("Banner editado exitosamente");
                        limpiarFiltros();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }

                    break;
                default:
                    break;
            }
            cargarBanners();
        }

        private void btnEliminarBanner_Click(object sender, EventArgs e)
        {
            int id_banner = Int16.Parse(dataGridBanners.SelectedRows[0].Cells[0].Value.ToString());
            if (Controlador.eliminarBanner(id_banner))
                MessageBox.Show("Eliminado correctamente");
            else
                MessageBox.Show("Ha ocurrido un error");
            cargarBanners();
        }
        private void dataGridBanners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizarImagenes();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Asociar_Desasociar("Asociar");
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            Asociar_Desasociar("Desasociar");
        }
        private void Asociar_Desasociar(string modo)
        {
            try
            {
                int id_banner = Int16.Parse(dataGridBanners.SelectedRows[0].Cells[0].Value.ToString());
                int id_imagen = 0;
                switch (modo)
                {
                    case "Asociar":
                        id_imagen = Int16.Parse(dataGridSinAsociar.SelectedRows[0].Cells[0].Value.ToString());
                        break;
                    case "Desasociar":
                        id_imagen = Int16.Parse(dataGridAsociadas.SelectedRows[0].Cells[0].Value.ToString());
                        break;
                    default:
                        break;
                }
                Controlador.Asociar_Desasociar_Imagen(modo, id_banner, id_imagen);
                actualizarImagenes();
            }
            catch (Exception)
            {
            }
           
        }

        private void dataGridAsociadas_CelltClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridSinAsociar.Rows)
            {
                row.Selected = false;
            }
        }
        private void dataGridNoAsociadas_CelltClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridAsociadas.Rows)
            {
                row.Selected = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dataGridAsociadas.DataSource = null;
            dataGridSinAsociar.DataSource = null;
            dataGridBanners.DefaultCellStyle.BackColor = Color.Gray;
            txtNombre.Text = dataGridBanners.SelectedRows[0].Cells[1].Value.ToString();
            cmoPosicion.Text = dataGridBanners.SelectedRows[0].Cells[2].Value.ToString();
            dataGridBanners.Enabled = false;
            btnCrearBanner.Text = "Guardar";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFiltros();
        }
        private void limpiarFiltros()
        {
            dataGridAsociadas.DataSource = null;
            dataGridSinAsociar.DataSource = null;
            dataGridBanners.DefaultCellStyle.BackColor = Color.White;
            btnCrearBanner.Text = "Agregar banner";
            txtNombre.Text = "";
            cmoPosicion.Text = "";
            dataGridBanners.Enabled = true;
        }
    }
}
