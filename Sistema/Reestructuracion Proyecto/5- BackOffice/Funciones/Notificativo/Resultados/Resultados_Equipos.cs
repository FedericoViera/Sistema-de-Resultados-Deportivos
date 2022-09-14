using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reestructuracion_Proyecto._5__BackOffice.Funciones.Notificativo.Resultados
{
    public partial class Resultados_Equipos : UserControl
    {
        private DataTable resultadosPartido;
        private int filaSeleccionada;
        private int _id_partido;
        public Resultados_Equipos()
        {
            InitializeComponent();
        }

        public int id_partido
        {
            get
            {
                return _id_partido;
            }
        }
        public int numero_ordinal
        {
            get
            {
                if (!(dataResultados.Rows.Count == 0))
                {
                    return Int16.Parse(dataResultados.Rows[filaSeleccionada].Cells[1].Value.ToString());
                }
                else
                {
                    return 0;
                }
            }
        }
        public string detalle1
        {
            get {
                StringBuilder sb = new StringBuilder();
                foreach (object o in listEq1.Items)
                {
                    sb.AppendLine(o.ToString()+";");
                }
                return sb.ToString();                
            }
        }
        public int score1
        {
            get { return Int16.Parse(txtPunto1.Text); }
        }
        public int score2
        {
            get { return Int16.Parse(txtPunto2.Text); }
        }
        public string detalle2
        {
            get
            {
                StringBuilder sb = new StringBuilder(";");
                foreach (object o in listEq2.Items)
                {
                    sb.AppendLine(o.ToString()+";");
                }
                return sb.ToString();

            }
        }
        public void adicionarTiempo()
        {
            if (Controlador.adicionarTiempo(id_partido,lblEq1.Text,lblEq2.Text))
            {
                actualizarTabla(id_partido);
                MessageBox.Show("Tiempo adicionado correctamente");                
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
        public void eliminarTiempo()
        {
            int numero_ordinal = Int16.Parse(dataResultados.Rows[filaSeleccionada].Cells[1].Value.ToString());
            if (Controlador.eliminarTiempo(id_partido, numero_ordinal))
            {
                actualizarTabla(id_partido);
                limpiarFiltros();
                MessageBox.Show("Tiempo eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
        public void actualizarElementos(int id_partido,string eq1, string eq2)
        {
            btnAccion1.Enabled = false;
            btnAccion2.Enabled = false;
            btnEliminar1.Enabled = false;
            btnEliminar2.Enabled = false;
            _id_partido = id_partido;
            actualizarTabla(id_partido);
            lblEq1.Text = eq1;
            lblEq2.Text = eq2;
            cmoEq1.DataSource= Controlador.DeportistasDeEquipoNombreApellido(eq1);
            cmoEq2.DataSource = Controlador.DeportistasDeEquipoNombreApellido(eq2);
            seleccionarIndiceTrasCargar();
            limpiarFiltros();
        }
        private void actualizarTabla(int id_partido)
        {
            resultadosPartido = Controlador.obtenerResultadosEquipos(id_partido);
            dataResultados.DataSource = resultadosPartido;
            dataResultados.Columns[0].Visible = false;
            dataResultados.Columns[1].Visible = false;
            dataResultados.Columns[2].Visible = false;
            dataResultados.Columns[7].Visible = false;
            dataResultados.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataResultados.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void actualizarDetalles()
        {
            listEq1.Items.Clear();
            listEq2.Items.Clear();
            List<string> listaDetalleEq1 = dataResultados.CurrentCell.OwningRow.Cells[2].Value.ToString().Split(';').ToList();
            foreach (String item in listaDetalleEq1)
            {
                listEq1.Items.Add(item);
            }
            for (int i = listEq1.Items.Count - 1; i >= 0; i--)
            {
                if (String.IsNullOrWhiteSpace(listEq1.Items[i].ToString()))
                {
                    listEq1.Items.RemoveAt(i);
                }
            }
            List<string> listaDetalleEq2 = dataResultados.CurrentCell.OwningRow.Cells[7].Value.ToString().Split(';').ToList();
            foreach (String item in listaDetalleEq2)
            {
                listEq2.Items.Add(item);
            }
            for (int i = listEq2.Items.Count - 1; i >= 0; i--)
            {
                if (String.IsNullOrWhiteSpace(listEq2.Items[i].ToString()))
                {
                    listEq2.Items.RemoveAt(i);
                }
            }
        }
        private void dataResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAccion1.Enabled = true;
            btnAccion2.Enabled = true;
            btnEliminar1.Enabled = true;
            btnEliminar2.Enabled = true;
            dataResultados.Enabled = false;
            dataResultados.DefaultCellStyle.BackColor = Color.Gray;
            filaSeleccionada = dataResultados.SelectedRows[0].Index;
            actualizarDetalles();            
        }               
        public void limpiarFiltros()
        {
            dataResultados.Enabled = true;
            dataResultados.DefaultCellStyle.BackColor = Color.White;
            listEq1.Items.Clear();
            listEq2.Items.Clear();
            foreach (DataGridViewRow row in dataResultados.Rows)
            {
                row.Selected = false;
            }
        }
        private void btnAccion_Click(object sender, EventArgs e)
        {
            listEq1.Items.Add(txtPunto1.Text + " - " +cmoEq1.Text + " "+ DateTime.Now.ToString("HH:mm"));
        }

        private void btnAccion2_Click(object sender, EventArgs e)
        {
            listEq2.Items.Add(txtPunto2.Text + " - " + cmoEq2.Text + " " + DateTime.Now.ToString("HH:mm"));
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            listEq1.Items.Remove(listEq1.SelectedItem);
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            listEq2.Items.Remove(listEq2.SelectedItem);
        }

        private void seleccionarIndiceTrasCargar()
        {
            foreach (DataGridViewRow row in dataResultados.Rows)
            {
                if (row.Index==filaSeleccionada)
                {
                    row.Selected = true;
                }
                else
                {
                    row.Selected = false;
                }                
            }            
        }
    }
}
