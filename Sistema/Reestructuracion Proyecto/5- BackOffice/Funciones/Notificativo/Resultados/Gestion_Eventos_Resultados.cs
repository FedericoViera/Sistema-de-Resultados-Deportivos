using System;
using System.Data;
using System.Windows.Forms;
using Proyecto._5__BackOffice.Funciones.Notificativo.Resultados.Ingresar_Resultado;

namespace Proyecto._5__BackOffice.Funciones.Notificativo.Resultados.Gestion_Eventos_Resultado
{
    public partial class Gestion_Eventos_Resultados : UserControl
    {
        private Ingresar_Resultados ingresar_resultados;
        private string modalidad_evento;
        private string deporte;
        private DataTable partidos_evento = new DataTable();

        public Gestion_Eventos_Resultados()
        {
            InitializeComponent();
            cargarInformacion();
            ingresar_resultados = new Ingresar_Resultados();
            partidos_evento = new DataTable();
        }

        public void cargarInformacion()
        {
            cargarEquipos();
            actualizarTabla();
        }

        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ingresar_resultados.ShowDialog();
            this.Show();
            actualizarTabla();
        }

        private void cargarEquipos()
        {
            foreach (Equipos item in Controlador.getDominio().equipos)
            {
                cmoEq1.Items.Add(item.nombre);
                cmoEq2.Items.Add(item.nombre);
            }
            cmoEq1.Items.Remove("-Sin_equipo-");
            cmoEq2.Items.Remove("-Sin_equipo-");
        }

        private void actualizarTabla()
        {
            switch (cmoMostrarEventos.Text)
            {
                case "En curso":
                    btnCulminar.Enabled = true;
                    btnReabrir.Enabled = false;
                    break;
                case "Culminados":
                    btnCulminar.Enabled = false;
                    btnReabrir.Enabled = true;
                    break;
                default:
                    break;
            }
            dataEventos.DataSource = Controlador.Eventos_Estado(cmoMostrarEventos.Text);
            dataEventos.Columns[0].Visible = false;
            dataEventos.Columns[4].Visible = false;
            dataEventos.Columns[8].Visible = false;
            dataEventos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!(txtBuscarUsuario.Text==""))
            {
                dataEventos.DataSource = Controlador.ListaUsuariosPorAproximacion(txtBuscarUsuario.Text);
                dataEventos.Columns.RemoveAt(5);
            } else
            {
                MessageBox.Show("Ingrese un criterio de busqueda");
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBuscarUsuario.Text = "";
            actualizarTabla();
        }

        private void cmoMostrarEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarTabla();
            
        }

        private void btnCulminar_Click(object sender, EventArgs e)
        {
            if (Controlador.CulminarEvento(Int16.Parse(dataEventos.CurrentCell.OwningRow.Cells[0].Value.ToString()),dteCulminar.Value) == true)
            {
                cargarInformacion();
                MessageBox.Show("Evento culminado exitosamente");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnReabrir_Click(object sender, EventArgs e)
        {
            if (Controlador.ReAbrirEvento(Int16.Parse(dataEventos.CurrentCell.OwningRow.Cells[0].Value.ToString())) == true)
            {
                cargarInformacion();
                MessageBox.Show("Evento reabierto exitosamente");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        private void cargarPartidos_Eventos()
        {
            modalidad_evento = dataEventos.CurrentCell.OwningRow.Cells[4].Value.ToString();
            deporte = dataEventos.CurrentCell.OwningRow.Cells[3].Value.ToString();
            switch (modalidad_evento)
            {
                case "En_equipo":
                    partidos_evento = Controlador.PartidosDeEquipo(Int16.Parse(dataEventos.CurrentCell.OwningRow.Cells[0].Value.ToString()));
                    dataPartidos.DataSource = partidos_evento;
                    dataPartidos.Columns[0].Visible = false;
                    dataPartidos.Columns[4].Visible = false;
                    dataPartidos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
                    break;
                case "Individual":
                    partidos_evento = Controlador.EncuentrosDeIndividuales(Int16.Parse(dataEventos.CurrentCell.OwningRow.Cells[0].Value.ToString()));
                    dataPartidos.DataSource = partidos_evento;
                    dataPartidos.Columns[0].Visible = false;
                    dataPartidos.Columns[2].Visible = false;
                    dataPartidos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    foreach (DataGridViewColumn item in dataPartidos.Columns)
                    {
                        item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    break;
                default:
                    break;
            }
        }
        private void dataEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarPartidos_Eventos();
        }


        private void btnCrearPartido_Click(object sender, EventArgs e)
        {
            int id_evento = Int16.Parse(dataEventos.CurrentCell.OwningRow.Cells[0].Value.ToString());
            switch (modalidad_evento)
            {
                case "En_equipo":
                    if (Controlador.crearPartido(id_evento, dtimePartido.Value, cmoEq1.Text, cmoEq2.Text))
                    {
                        cargarPartidos_Eventos();
                        MessageBox.Show("Partido creado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    break;
                default:
                    break;
            }
           

        }

        private void dataPartidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();

            switch (modalidad_evento)
            {
                case "En_equipo":
                    string equipo1 = dataPartidos.CurrentCell.OwningRow.Cells[1].Value.ToString();
                    string equipo2 = dataPartidos.CurrentCell.OwningRow.Cells[2].Value.ToString();
                    int partido = Int16.Parse(dataPartidos.CurrentCell.OwningRow.Cells[0].Value.ToString());
                    string evento = dataEventos.CurrentCell.OwningRow.Cells[1].Value.ToString() + " " + dataEventos.CurrentCell.OwningRow.Cells[2].Value.ToString();
                    ingresar_resultados.formularioEquipos(equipo1, equipo2, evento, partido);
                    ingresar_resultados.ShowDialog();
                    actualizarTabla();
                    break;
                case "Individual":
                    string eventos = dataEventos.CurrentCell.OwningRow.Cells[1].Value.ToString() + " " + dataEventos.CurrentCell.OwningRow.Cells[2].Value.ToString();
                    int encuentro = Int16.Parse(dataPartidos.CurrentCell.OwningRow.Cells[0].Value.ToString());
                    ingresar_resultados.formularioEncuentros(eventos,encuentro,deporte);
                    ingresar_resultados.ShowDialog();
                    break;
                default:
                    break;
            }            
            this.Show();
        }

        private void btnEliminarPartido_Click(object sender, EventArgs e)
        {

        }
    }
}
