using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Superusuario.Usuarios
{
    public partial class Agregar_Editar_Usuarios : Form
    {
        protected string modo_formulario;
        public Agregar_Editar_Usuarios()
        {
            InitializeComponent();
            gboInformacion.Enabled = false;
            modo_formulario = "Agregar usuario";    
        }
        public bool estado_txtContraseña
        {
            set
            {
                txtPassword.Enabled = value;
                lblContraseña.Enabled = value;
            }
        }
        public bool estado_chkContrasela
        {
            set
            {
                chkContraseña.Enabled = value;
            }
        }
        public string modo_del_formulario
        {
            set
            {
                modo_formulario = value;
            }
        }
        public string textoBotonAccionUsuario
        {
            set
            {
                this.btnAccionUsuario.Text = value;
            }
        }
        public string textoNombreUsuario
        {
            set
            {
                this.txtUser.Text = value;
            }
        }

        public bool estadoGboComprobarUsuario
        {
            set
            {
                this.gboComprobar.Enabled = value;
            }
        }
        public bool estadoGboInformaciono
        {
            set
            {
                this.gboInformacion.Enabled = value;
            }
        }
        public string rol
        {
            set
            {
                for (int x = 0; x < chkListBoxRol.Items.Count; x++)
                {
                    if (chkListBoxRol.Items[x].ToString()== value)
                    {
                        chkListBoxRol.SetItemCheckState(x, CheckState.Checked);
                    }
                }
            }
        }

        private void btnAccionUsuario_Click(object sender, EventArgs e)
        {
            string selected = "";
            if (chkListBoxRol.CheckedItems.Count != 0)
            {
                for (int x = 0; x < chkListBoxRol.CheckedItems.Count; x++)
                {
                    selected = selected + chkListBoxRol.CheckedItems[x];
                }
            }
            switch (modo_formulario)
            {
                case "Agregar usuario":
                    if (Controlador.agregarUsuario(txtUser.Text, txtName.Text, txtLastName.Text, selected, txtPassword.Text, txtEmail.Text) == true)
                    {
                        MessageBox.Show("Usuario ingresado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }
                    break;
                case "Editar informacion":
                    if (Controlador.editarUsuario(txtUser.Text, txtName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text,
                        selected,chkContraseña.Checked) == true)
                    {
                        MessageBox.Show("Datos actualizados correctamente");

                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al actualizar la informacion, intente nuevamente");
                    }
                    break;
            }
            limpiarDatos();
            this.Hide();
        }


        private void chkListBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iSelectedIndex = chkListBoxRol.SelectedIndex;
            if (iSelectedIndex == -1)
                return;
            for (int iIndex = 0; iIndex < chkListBoxRol.Items.Count; iIndex++)
                chkListBoxRol.SetItemCheckState(iIndex, CheckState.Unchecked);
            chkListBoxRol.SetItemCheckState(iSelectedIndex, CheckState.Checked);           
            
        }
        private void limpiarDatos()
        {
            txtPassword.Enabled = true;
            lblContraseña.Enabled = true;
            txtUser.Text = "";
            txtName.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            modo_formulario = "Agregar usuario";
            btnAccionUsuario.Text = "Crear usuario";
            chkContraseña.Checked = false;
            chkContraseña.Enabled = false;
            for (int x = 0; x < chkListBoxRol.Items.Count; x++)
            {
              chkListBoxRol.SetItemCheckState(x, CheckState.Unchecked);                
            }
            gboInformacion.Enabled = false;
            gboComprobar.Enabled = true;
        }

        public void actualizarDatosUsuarioExistente(string nombre_usuario)
        {
            var datosUsuario = Controlador.obtenerDatosUsuario(nombre_usuario);
            txtName.Text = datosUsuario[2];
            txtLastName.Text = datosUsuario[3];
            txtEmail.Text = datosUsuario[4];
            for (int x = 0; x < chkListBoxRol.Items.Count; x++)
            {
                if (chkListBoxRol.Items[x].ToString() == datosUsuario[6])
                {
                    chkListBoxRol.SetItemCheckState(x, CheckState.Checked);
                }
            }

        }
        private void btnEliminarTexto_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            if (Controlador.comprobarExisteUsuario(txtUser.Text) == false)
            {
                MessageBox.Show("Nombre de usuario disponible, ingrese a continuación la información");
                gboInformacion.Enabled = true;
                gboComprobar.Enabled = false;
                chkContraseña.Enabled = false;
                txtPassword.Enabled = true;
                lblContraseña.Enabled = true;
            }
            else
            {
                MessageBoxButtons opciones = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Nombre de usuario en uso." + Environment.NewLine + "¿Desea actualizar su informacion?", "Usuario en uso", opciones);
                if (result == DialogResult.Yes)
                {
                    gboInformacion.Enabled = true;
                    gboComprobar.Enabled = false;
                    modo_formulario = "Editar informacion";
                    btnAccionUsuario.Text = "Guardar";
                    chkContraseña.Enabled = true;
                    txtPassword.Enabled = false;
                    lblContraseña.Enabled = false;
                actualizarDatosUsuarioExistente(txtUser.Text);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
            this.Hide();
        }

        private void chkContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContraseña.Checked == true)
            {
                txtPassword.Enabled = true;
                lblContraseña.Enabled = true;
            } else
            {
                lblContraseña.Enabled = false;
                txtPassword.Enabled = false;
            }
        }
    }
}
