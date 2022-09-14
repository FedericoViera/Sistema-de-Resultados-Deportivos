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
    public partial class Resultados_Individuales : UserControl
    {
        protected int _sets;
        protected int _encuentro;
        List<string> lista_deportistas_participantes;
        public Resultados_Individuales()
        {
            InitializeComponent();
        }
        
        public void actualizarElementos(int encuentro,string deporte)
        {
            listTiempos.Items.Clear();
            _encuentro = encuentro;
            cmoDep.DataSource = Controlador.DeportistasDeDeporte(deporte);
            lista_deportistas_participantes = Controlador.DeportistasParticipantesEncuentro(encuentro);
            foreach (string item in lista_deportistas_participantes)
            {
                listDeportistas.Items.Add(item);
            }
            _sets = Controlador.SetsEncuentroCantiddad(encuentro);
            for (int i = 1; i <= _sets; i++)
            {
                listTiempos.Items.Add(i);
            }                  
            limpiarFiltros();
        }
        public void limpiarFiltros()
        {
            dataResultados.Enabled = true;
            dataResultados.DefaultCellStyle.BackColor = Color.White;
            foreach (DataGridViewRow row in dataResultados.Rows)
            {
                row.Selected = false;
            }
        }
        private void btnAccion2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresarResultado_Click(object sender, EventArgs e)
        {

        }

        private void listTiempos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tiempo = Int16.Parse(listTiempos.SelectedItem.ToString());
            dataResultados.DataSource = Controlador.obtenerResultadosIndividualesPorTiempo(_encuentro, tiempo);
            dataResultados.Columns[0].Visible = false;
            dataResultados.Columns[1].Visible = false;
            dataResultados.Columns[2].Visible = false;
            dataResultados.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
