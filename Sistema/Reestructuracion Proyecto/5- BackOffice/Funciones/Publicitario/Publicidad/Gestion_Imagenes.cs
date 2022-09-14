
using Proyecto._2__Logica.Dominio.Entidades;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Publicitario.Publicidad
{
    public partial class Gestion_Imagenes : UserControl
    {
        protected string directorio_imagen;
        public Gestion_Imagenes()
        {
            InitializeComponent();
            pteImagen.SizeMode = PictureBoxSizeMode.StretchImage;
           
        }

        public void cargarInformacion()
        {
            cargarEmpresas();
            cargarImagenes();
        }
        private void cargarImagenes()
        {
            dataGridImagenes.DataSource = Controlador.Lista_A_DataTable().Convertir<Imagenes>(Controlador.getDominio().imagenes);
            dataGridImagenes.Columns[0].Visible = false;
            dataGridImagenes.Columns[2].Visible = false;
        }

        private void cargarEmpresas()
        {
            cmoEmpresas.Items.Clear();
            var manejador = Controlador.getDominio().empresas;
            for (int i = 0; i < manejador.Count; i++)
            {
                cmoEmpresas.Items.Add(manejador.ElementAt(i).nombre);
            }
        }




        private void btnBuscarImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog busqueda = new OpenFileDialog();
            busqueda.Filter = "Image Files (*.png *.jpg *.bmp) |*.png; *.jpg; *.bmp|All Files(*.*) |*.*";
            if (busqueda.ShowDialog() == DialogResult.OK)
            {
                pteImagen.Visible = true;
                panel_Informacion.Enabled = true;
                txtNombreArchivo.Text = Path.GetFileName(busqueda.FileName);
                directorio_imagen = busqueda.FileName;
                pteImagen.Image = new Bitmap(busqueda.FileName);
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            string directorio = Path.Combine(Environment.CurrentDirectory, Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName);
            directorio = Path.Combine(directorio, "00- Recursos/");
            directorio = Path.Combine(directorio, txtNombreArchivo.Text);
            string[] recurso = directorio.Split('C');
            if (Controlador.crearImagenPublicitaria(txtNombre.Text, recurso[1], cmoEmpresas.Text) == true)
            {
                MessageBox.Show("Creado correctamente");
                File.Copy(directorio_imagen, directorio, true);
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
            cargarImagenes();
            limpiarFiltros();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFiltros();
        }
        private void limpiarFiltros()
        {
            panel_Informacion.Enabled = false;
            txtNombreArchivo.Text = "";
            directorio_imagen = "";
            txtNombre.Text = "";
            cmoEmpresas.Text = "";
            pteImagen.Visible = false;
        }

        private void dataGridImagenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                limpiarFiltros();
                string directorio = Path.Combine(Environment.CurrentDirectory, Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName);
                string origen_imagen = dataGridImagenes.SelectedRows[0].Cells[2].Value.ToString();
                origen_imagen = Convert.ToChar(92) + origen_imagen.Substring(1);
                string directorio_imagen = string.Concat(directorio, origen_imagen);
                pteImagen.Visible = true;
                pteImagen.Image = new Bitmap(directorio_imagen);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
