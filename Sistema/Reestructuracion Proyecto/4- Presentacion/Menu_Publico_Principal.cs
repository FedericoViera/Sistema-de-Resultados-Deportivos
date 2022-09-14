using Newtonsoft.Json;
using Presentacion;
using Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Menu_Publico_Principal : Form
    {
        private APIResultados apiresultados;
        private Login login;
        private string[,] noticiasRecientes;
        private string[,] resultadosEquiposRecientes;
        ClientePresentacion clientePresentacion;
        public Menu_Publico_Principal()
        {
            InitializeComponent();
            login = new Login();
            apiresultados = new APIResultados();
            noticiasRecientes = new string[3, 6];
            resultadosEquiposRecientes = new string[3, 7];
            actualizarNoticiasRecientes();
            actualizarResultadosEquiposRecientes();
        }

        private void actualizarNoticiasRecientes()
        {
            noticiasRecientes = JsonConvert.DeserializeObject<string[,]>(apiresultados.obtenerNoticiasRecientes());
            lblTitulo1.Text = noticiasRecientes[0, 3];
            lblTitulo2.Text = noticiasRecientes[1, 3];
            lblTitulo3.Text = noticiasRecientes[2, 3];
            lblCampeonato1.Text= noticiasRecientes[0, 1] + " - " + noticiasRecientes[0, 2];
            lblCampeonato2.Text = noticiasRecientes[1, 1] + " - " + noticiasRecientes[1, 2];
            lblCampeonato3.Text = noticiasRecientes[2, 1] + " - " + noticiasRecientes[2, 2];
            lblFechaNoticia1.Text = noticiasRecientes[0, 5];
            lblFechaNoticia2.Text = noticiasRecientes[1, 5];
            lblFechaNoticia3.Text = noticiasRecientes[2, 5];
            lblTexto_noticia1.Text= noticiasRecientes[0, 4];
            lblTexto_noticia2.Text = noticiasRecientes[1, 4];
            lblTexto_noticia3.Text = noticiasRecientes[2, 4];
        }

        private void actualizarResultadosEquiposRecientes()
        {
            resultadosEquiposRecientes = JsonConvert.DeserializeObject<string[,]>(apiresultados.obtenerResultadosEquiposRecientes());
            lblRcampeonato1.Text = resultadosEquiposRecientes[0, 1];
            lblRcampeonato2.Text = resultadosEquiposRecientes[1, 1];
            lblRcampeonato3.Text = resultadosEquiposRecientes[2, 1];
            lblRdeporte1.Text = resultadosEquiposRecientes[0,0];
            lblRdeporte2.Text = resultadosEquiposRecientes[1,0];
            lblRdeporte3.Text = resultadosEquiposRecientes[2,0];
            lblRfecha1.Text = resultadosEquiposRecientes[0,2];
            lblRfecha2.Text = resultadosEquiposRecientes[1,2];
            lblRfecha3.Text = resultadosEquiposRecientes[2,2];
            lblRequipo11.Text = resultadosEquiposRecientes[0,3];
            lblRequipo12.Text = resultadosEquiposRecientes[1,3];
            lblRequipo13.Text = resultadosEquiposRecientes[2,3];
            lblRres11.Text = resultadosEquiposRecientes[0, 4];
            lblRres12.Text = resultadosEquiposRecientes[1, 4];
            lblRres13.Text = resultadosEquiposRecientes[2, 4];
            lblRres21.Text = resultadosEquiposRecientes[0, 5];
            lblRres22.Text = resultadosEquiposRecientes[1, 5];
            lblRres23.Text = resultadosEquiposRecientes[2, 5];
            lblRequipo21.Text = resultadosEquiposRecientes[0, 6];
            lblRequipo22.Text = resultadosEquiposRecientes[1, 6];
            lblRequipo23.Text = resultadosEquiposRecientes[2, 6];
        }

        private void actualizarInformacionUsuario()
        {
            if (CacheUsuarioPresentacion.existe == true)
            {
                lblUsuario.Click -= lblUsuario_Click;
                imagenPerfil.Click -= imagenPerfil_Click;
                string nombre = CacheUsuarioPresentacion.nombre;
                string apellido = CacheUsuarioPresentacion.apellido;
                lblUsuario.Text = char.ToUpper(nombre[0]) + nombre.Substring(1) + " " + char.ToUpper(apellido[0]) + apellido.Substring(1);
                if (CacheUsuarioPresentacion.rol=="Premium")
                {
                    clientePresentacion = new ClientePresentacion();
                    temporizadorPremium.Enabled = true;
                    imagenDesconectado.Visible = true;
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imagenPerfil_Click(object sender, EventArgs e)
        {
            logearse();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            logearse();
        }

        private void logearse()
        {
            this.Hide();
            login.modoFormulario = 2;
            login.ShowDialog();
            this.Show();
            actualizarInformacionUsuario();
        }
        private void cambiarEstadoImagenConectado()
        {
            if (clientePresentacion.conectar() == true)
            {
                imagenConectado.Visible = true;
                imagenDesconectado.Visible = false;
            }
            else
            {
                imagenConectado.Visible = false;
                imagenDesconectado.Visible = true;
            }
        }

        private void temporizadorPremium_Tick(object sender, EventArgs e)
        {
            cambiarEstadoImagenConectado();
        }
    }
}
