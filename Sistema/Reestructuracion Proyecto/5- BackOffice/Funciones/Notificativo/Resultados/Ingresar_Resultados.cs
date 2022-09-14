using Reestructuracion_Proyecto._5__BackOffice.Funciones.Notificativo.Resultados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Notificativo.Resultados.Ingresar_Resultado
{
    public partial class Ingresar_Resultados : Form
    {
        Resultados_Equipos resultados_equipos;
        Resultados_Individuales resultados_individuales;
        private string modo_formulario;
        private string _eq1;
        private string _eq2;
        private int _partido;
        public Ingresar_Resultados()
        {
            InitializeComponent();
            resultados_equipos = new Resultados_Equipos();
            resultados_individuales = new Resultados_Individuales();
            modo_formulario = "";
        }
        
        public void formularioEquipos(string eq1,string eq2,string evento,int partido)
        {
            panelResultados.Controls.Clear();
            _eq1 = eq1;
            _eq2 = eq2;
            _partido = partido;
            resultados_equipos.Dock = DockStyle.Fill;
            panelResultados.Controls.Add(resultados_equipos);
            lblEvento.Text = evento;
            resultados_equipos.actualizarElementos(_partido,_eq1, _eq2);
            modo_formulario = "equipos";
        }
        public void formularioEncuentros(string evento, int encuentro,string deporte)
        {
            panelResultados.Controls.Clear();
            _partido = encuentro;
            resultados_individuales.Dock = DockStyle.Fill;
            panelResultados.Controls.Add(resultados_individuales);
            lblEvento.Text = evento;
            resultados_individuales.actualizarElementos(encuentro,deporte);
            modo_formulario = "individual";
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (modo_formulario)
            {
                case "equipos":
                    string detalle1 = resultados_equipos.detalle1;
                    string[] _score1 = detalle1.Split(';');
                    int score1 = 0;
                    for (int i = 0; i < _score1.Length ; i++)
                    {
                        string[] datos = _score1[i].Split('-');
                        if (String.IsNullOrWhiteSpace(_score1[i].Split('-')[0].Trim())==false)
                        {
                            score1 = score1 + Int16.Parse(datos[0].Trim());
                        }
                    }
                    string detalle2 = resultados_equipos.detalle2;
                    string[] _score2 = detalle2.Split(';');
                    int score2 = 0;
                    for (int i = 0; i < _score2.Length; i++)
                    {
                        string[] datos = _score2[i].Split('-');
                        if (String.IsNullOrWhiteSpace(_score2[i].Split('-')[0].Trim()) == false)
                        {
                            score2 = score2 + Int16.Parse(datos[0].Trim());
                        }
                    }
                    int id_partid = resultados_equipos.id_partido;
                    int numero_ordinal = resultados_equipos.numero_ordinal;
                    if (Controlador.ActualizarResultadoEquipo(id_partid, numero_ordinal, score1, score2, detalle1, detalle2))
                    {
                        resultados_equipos.actualizarElementos(_partido, _eq1, _eq2);
                        MessageBox.Show("Actualizado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Ha habido un error");
                    }
                    break;
                default:
                    break;
            }            
        }

        private void btnAdicionarTiempo_Click(object sender, EventArgs e)
        {
            switch (modo_formulario)
            {
                case "equipos":
                    resultados_equipos.adicionarTiempo();
                    break;
                default:
                    break;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            switch (modo_formulario)
            {
                case "equipos":
                    resultados_equipos.limpiarFiltros();
                    break;
                default:
                    break;
            }
        }

        private void btnEliminarTiempo_Click(object sender, EventArgs e)
        {
            switch (modo_formulario)
            {
                case "equipos":
                    resultados_equipos.eliminarTiempo();
                    break;
                default:
                    break;
            }
        }
    }
}
