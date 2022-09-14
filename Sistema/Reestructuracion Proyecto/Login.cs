using Newtonsoft.Json;
using Proyecto._2__Logica.Datos;
using Proyecto._5__BackOffice.Superusuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        protected APILogin apiLogin;
        protected Menu_Backoffice_Principal menu_backoffice;
        protected int modo;
        protected List<string> datosUsuario;
        public Login()
        {
            InitializeComponent();
            modo =0;
            apiLogin = new APILogin();
            datosUsuario = new List<string>();
            CacheUsuarioPresentacion.existe = false;
        }
        public int modoFormulario
        {
            set
            {
                modo = value;
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            acceder();          
           
        }
        private void btnAcceder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                acceder();
            }
        }
        private void acceder()
        {
                switch (modo)
                {
                    case 1:
                        datosUsuario = Controlador.loginUsuario(txtNombre.Text, txtContraseña.Text);

                        if (datosUsuario[0] == "false")
                        {
                            MessageBox.Show("Credenciales incorrectas");
                            CacheUsuario.existe = false;
                        }
                        else
                        {
                            string rol = CacheUsuario.rol;
                            if (rol.Equals("Superusuario") || rol.Equals("Publicitario") || rol.Equals("Notificativo"))
                            {
                                menu_backoffice = new Menu_Backoffice_Principal();
                                menu_backoffice.ActualizarInformacionUsuario(rol);
                                this.Hide();
                                txtContraseña.Text = "";
                                txtNombre.Text = "";
                                txtNombre.Select();
                                menu_backoffice.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("Credenciales incorrectas");
                            }

                        }
                        break;

                    case 2:
                        CacheUsuarioPresentacion.existe = false;
                        datosUsuario = JsonConvert.DeserializeObject<List<String>>(apiLogin.loginUsuario(txtNombre.Text, txtContraseña.Text));
                        if (datosUsuario[0] == "false")
                        {
                            MessageBox.Show("Credenciales incorrectas");
                        }
                        else
                        {
                            CacheUsuarioPresentacion.existe = true;
                            CacheUsuarioPresentacion.id_usuario = datosUsuario[0];
                            CacheUsuarioPresentacion.nombre_u = datosUsuario[1];
                            CacheUsuarioPresentacion.nombre = datosUsuario[2];
                            CacheUsuarioPresentacion.apellido = datosUsuario[3];
                            CacheUsuarioPresentacion.email = datosUsuario[4];
                            CacheUsuarioPresentacion.rol = datosUsuario[6];
                            txtNombre.Text = "";
                            txtContraseña.Text = "";
                            txtNombre.Select();
                            this.Close();
                        }
                        break;

                    default:
                        break;
                }            
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            CacheUsuarioPresentacion.existe = false;
            this.Close();
        }
    }
}
