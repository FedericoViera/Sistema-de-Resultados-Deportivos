using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto._2__Logica.Dominio.Entidades;

namespace Proyecto._5__BackOffice.Funciones.Publicitario.Eventos
{
    public partial class Gestion_Eventos : UserControl
    {
        public Gestion_Eventos()
        {
            InitializeComponent();
            cargarInformacion();
        }

        public void cargarInformacion()
        {
            cargarCampeonatos();
            cargarPaises();
            cargarDeportes();
            cargarModalidades();
            cargarEventos();
        }
        
        private void cargarEventos() 
        {
            dataGridEventos.DataSource = Controlador.Lista_A_DataTable().Convertir<global::Eventos>(Controlador.getDominio().eventos);
            dataGridEventos.Sort(dataGridEventos.Columns[2], ListSortDirection.Ascending);
            dataGridEventos.Columns[0].Visible = false;
            dataGridEventos.Columns[5].Visible = false;
            dataGridEventos.Columns[6].Visible = false;
            dataGridEventos.Columns[7].Visible = false;
            dataGridEventos.Columns[8].Visible = false;
        }
        private void cargarModalidades()
        {
            cmoModalidad.Items.Clear();
            var manejador = Controlador.getDominio().modalidades;
            for (int i = 0; i < manejador.Count(); i++)
            {
                cmoModalidad.Items.Add(manejador.ElementAt(i).nombre);
            }
        }
        private void cargarPaises()
        {
            cmoPais.Items.Clear();
            var manejador = Controlador.getDominio().paises;
            for (int i = 0; i < manejador.Count; i++)
            {
                cmoPais.Items.Add(manejador.ElementAt(i).nombre);
            }
        }
        private void cargarDeportes()
        {
            cmoDeportes.Items.Clear();
            var manejador = Controlador.getDominio().deportes;
            for (int i = 0; i < manejador.Count; i++)
            {
                cmoDeportes.Items.Add(manejador.ElementAt(i).nombre);
            }
        }

        private void cargarCampeonatos()
        {
            cmoCampeonato.Items.Clear();
            var manejador = Controlador.getDominio().campeonatos;
            for (int i = 0; i < manejador.Count(); i++)
            {
                cmoCampeonato.Items.Add(manejador.ElementAt(i).nombre);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            btnCrearEvento.Text = "Crear evento";
            dataGridEventos.Enabled = true;
            dataGridEventos.DefaultCellStyle.BackColor = Color.White;
            txtNombre.Text = "";
            dtimeInicio.Value = DateTime.Now;
            cmoPais.Text = "";
            cmoDeportes.Text = "";
            cmoCampeonato.Text = "";
            cmoModalidad.Text = "";
        }

        private void btnCrearEvento_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || cmoCampeonato.Text == "" || cmoDeportes.Text=="" || cmoModalidad.Text=="" || cmoPais.Text==""){
                MessageBox.Show("No puede dejar ningun campo en blanco");
            }
            else
            {
                bool nombre_en_uso = false;
                foreach (DataGridViewRow item in dataGridEventos.Rows)
                {
                    if (item.Cells[1].Value.ToString() == txtNombre.Text)
                    {
                        nombre_en_uso = true;
                    }
                }
                switch (nombre_en_uso)
                {
                    case true:
                        MessageBox.Show("Nombre de evento uso, elije otro");
                        break;
                    case false:
                        if (Controlador.GuardarEvento(btnCrearEvento.Text, txtNombre.Text, cmoCampeonato.Text, cmoDeportes.Text, cmoPais.Text, cmoModalidad.Text, dtimeInicio.Value.Date.ToString("yyyy-MM-dd")) == true)
                        {
                            MessageBox.Show("Evento guardado");
                        }
                        else
                        {
                            MessageBox.Show("Ha habido un error al guardar el evento");
                        }
                        cargarEventos();
                        limpiar();
                        break;
                    default:
                        break;
                }
            }

        }

        private void dataGridEventos_Click(object sender, DataGridViewCellEventArgs e)
        {
            btnCrearEvento.Text = "Guardar";
            dataGridEventos.Enabled = false;
            dataGridEventos.DefaultCellStyle.BackColor = Color.Gray;
            txtNombre.Text = dataGridEventos.CurrentCell.OwningRow.Cells[2].Value.ToString();
            DateTime fecha_inicio = Controlador.InicioEvento(Int16.Parse(dataGridEventos.CurrentCell.OwningRow.Cells[0].Value.ToString()));
            dtimeInicio.Value = fecha_inicio;
            cmoPais.Text= dataGridEventos.CurrentCell.OwningRow.Cells[5].Value.ToString();
            cmoDeportes.Text = dataGridEventos.CurrentCell.OwningRow.Cells[3].Value.ToString();
            cmoCampeonato.Text = dataGridEventos.CurrentCell.OwningRow.Cells[1].Value.ToString();
            cmoModalidad.Text = dataGridEventos.CurrentCell.OwningRow.Cells[4].Value.ToString();
        }
    }
}
