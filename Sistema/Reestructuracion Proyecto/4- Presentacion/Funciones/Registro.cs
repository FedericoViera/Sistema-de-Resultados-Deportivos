using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto._4__Presentacion
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

       private void btnRegister_Click(object sender, EventArgs e)
         {
            /* if(Controlador.agregarUsuario(txtUser.Text, txtName.Text, txtLastName.Text,
               "Estandar", txtCorreo.Text, txtContrasena.Text)) {
               MessageBox.Show("Te has registrado correctamente.");
           } else {
               MessageBox.Show("Ha ocurrido un error. Revisa tus datos.");
           }*/
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Nombre")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.LightGray;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Nombre";
                txtName.ForeColor = Color.DimGray;
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Apellido")
            {
                txtLastName.Text = "";
                txtLastName.ForeColor = Color.LightGray;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Text = "Apellido";
                txtLastName.ForeColor = Color.DimGray;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.LightGray;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
                txtCorreo.ForeColor = Color.DimGray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.UseSystemPasswordChar = true;
                txtContrasena.ForeColor = Color.LightGray;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.UseSystemPasswordChar = false;
                txtContrasena.ForeColor = Color.DimGray;
            }
        }
    }
}
