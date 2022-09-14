using Proyecto._2__Logica.Datos;
using Proyecto._5__BackOffice.Funciones.Superusuario.Deportes;
using Proyecto._5__BackOffice.Menu_Backoffice_Controles;
using Proyecto._5__BackOffice.Funciones.Superusuario.Paises;
using Proyecto._5__BackOffice.Funciones.Superusuario.Usuarios;
using Proyecto._5__BackOffice.Funciones.Publicitario.Publicidad;
using Proyecto._5__BackOffice.Funciones.Publicitario.Eventos;
using System;
using System.Windows.Forms;
using Reestructuracion_Proyecto._5__BackOffice.Funciones.Notificativo;
using Proyecto._5__BackOffice.Funciones.Notificativo.Baja_Cuenta;
using Proyecto._5__BackOffice.Funciones.Notificativo.Resultados.Gestion_Eventos_Resultado;

namespace Proyecto._5__BackOffice.Superusuario
{
    public partial class Menu_Backoffice_Principal : Form
    {
        //Controles de gestion
        //superusuario
        Gestion_Usuarios gestion_usuario;
        Gestion_Equipos gestion_equipo;
        Gestion_Deportistas gestion_deportistas;
        Gestion_Deportes gestion_deportes;
        Gestion_Integrantes gestion_integrantes;
        Gestion_Otros gestion_otros;
        //publicitario
        Gestion_Imagenes anadir_Imagen;
        Gestion_Eventos gestion_eventos;
        Gestion_Banners gestion_banners;
        Gestion_Asignaciones gestion_asignaciones;
        //notificativo
        Activar_Cuenta activacion_cuenta;
        Rebocar_Cuenta rebocar_cuenta;
        Gestion_Eventos_Resultados gestion_eventos_resultados;
        //Controles de navegacion
        Navegacion_superusuario navegacion_Superusuario;
        Navegacion_Publicitario navegacion_Publicitario;
        Navegacion_Notificativo navegacion_Notificativo;
        public Menu_Backoffice_Principal()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            //Controles de gestion

            //superusuario
            gestion_usuario = new Gestion_Usuarios();
            gestion_equipo = new Gestion_Equipos();
            gestion_deportistas = new Gestion_Deportistas();
            gestion_deportes = new Gestion_Deportes();
            gestion_integrantes = new Gestion_Integrantes();
            gestion_otros = new Gestion_Otros();
            //publicitario
            anadir_Imagen = new Gestion_Imagenes();
            gestion_eventos = new Gestion_Eventos();
            gestion_banners = new Gestion_Banners();
            gestion_asignaciones = new Gestion_Asignaciones();
            //notificativo
            activacion_cuenta = new Activar_Cuenta();
            rebocar_cuenta = new Rebocar_Cuenta();
            gestion_eventos_resultados = new Gestion_Eventos_Resultados();
            //Controles de navegacion
            navegacion_Superusuario = new Navegacion_superusuario();
            navegacion_Superusuario.CambiarControl += CambiarControl;

            navegacion_Publicitario = new Navegacion_Publicitario();
            navegacion_Publicitario.CambiarControl += CambiarControl;

            navegacion_Notificativo = new Navegacion_Notificativo();
            navegacion_Notificativo.CambiarControl += CambiarControl;
        }

        private void CambiarControl(string control)
        {

            panelContenedor.Controls.Clear();
            switch (control)
            {
                //controles superusuario
                case "usuario":
                    gestion_usuario.cargarInformacion();
                    gestion_usuario.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(gestion_usuario);
                    break;
                case "equipo":
                    gestion_equipo.cargarInformacion();
                    gestion_equipo.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(gestion_equipo);
                    break;
                case "deportistas":
                    gestion_deportistas.cargarInformacion();
                    gestion_deportistas.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(gestion_deportistas);
                    break;
                case "deportes":
                    gestion_deportes.cargarInformacion();
                    gestion_deportes.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(gestion_deportes);
                    break;
                case "integrantes":
                    gestion_deportistas.cargarInformacion();
                    gestion_integrantes.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(gestion_integrantes);
                    break;
                case "otros":
                    gestion_otros.cargarInformacion();
                    gestion_otros.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(gestion_otros);
                    break;
                //controles publicitario
                case "imagenes":
                    anadir_Imagen.cargarInformacion();
                    anadir_Imagen.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(anadir_Imagen);
                    break;
                case "eventos":
                    gestion_eventos.cargarInformacion();
                    gestion_eventos.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(gestion_eventos);
                    break;
                case "asignaciones":
                    gestion_asignaciones.cargarInformacion();
                    gestion_asignaciones.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(gestion_asignaciones);
                    break;
                case "banners":
                    gestion_banners.cargarInformacion();
                    gestion_banners.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(gestion_banners);
                    break;
                //controles notificativo
                case "activacion":
                    activacion_cuenta.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(activacion_cuenta);
                    break;
                case "culminar":
                    //ctivacion_cuenta.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(activacion_cuenta);
                    break;
                case "rebocar":
                    rebocar_cuenta.cargarInformacion();
                    rebocar_cuenta.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(rebocar_cuenta);
                    break;
                case "resultados":
                    gestion_eventos_resultados.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(gestion_eventos_resultados);
                    break;
                default:
                    break;
            }
        }
        public void ActualizarInformacionUsuario(string rol)
        {
            switch (rol)
            {
                case "Superusuario":
                    navegacion_Superusuario.Dock = DockStyle.Fill;
                    panelNavegacion.Controls.Add(navegacion_Superusuario);
                    break;
                case "Publicitario":
                    navegacion_Publicitario.Dock = DockStyle.Fill;
                    panelNavegacion.Controls.Add(navegacion_Publicitario);
                    break;
                case "Notificativo":
                    navegacion_Notificativo.Dock = DockStyle.Fill;
                    panelNavegacion.Controls.Add(navegacion_Notificativo);
                    Controlador.crearConexionClienteNotificativo();
                    cambiarEstadoImagenConectado();
                    temporizadorNotificativo.Enabled = true;
                    break;
                default:
                    break;
            }
            string nombre = CacheUsuario.nombre;
            string apellido = CacheUsuario.apellido;
            lblNombreApellido.Text = char.ToUpper(nombre[0]) + nombre.Substring(1) + " " + char.ToUpper(apellido[0]) + apellido.Substring(1);
        }

        private void temporizadorNotificativo_Tick(object sender, EventArgs e)
        {
            cambiarEstadoImagenConectado();
        }

        private void cambiarEstadoImagenConectado()
        {
            if (Controlador.verificarConexionNotificativo() == true)
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

        private void imagenUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controlador.mandarData();
        }
    }
}
