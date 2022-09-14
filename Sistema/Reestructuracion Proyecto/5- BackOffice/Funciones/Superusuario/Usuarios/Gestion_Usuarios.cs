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
    public partial class Gestion_Usuarios : UserControl
    {
        private Agregar_Editar_Usuarios agregarEditarUsuario;
        private DataTable tabla = new DataTable();

        public Gestion_Usuarios()
        {
            InitializeComponent();
            dataUsuarios.AutoResizeColumns(DataGridViewAutoSizeColumnsMo‌​de.Fill);
        }

        public void cargarInformacion()
        {
            actualizarTabla();
            agregarEditarUsuario = new Agregar_Editar_Usuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregarEditarUsuario.modo_del_formulario = "Agregar usuario";
            agregarEditarUsuario.textoBotonAccionUsuario = "Crear usuario";
            agregarEditarUsuario.estado_chkContrasela = false;
            agregarEditarUsuario.ShowDialog();
            actualizarTabla();
            this.Show();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregarEditarUsuario.rol = dataUsuarios.CurrentCell.OwningRow.Cells[5].Value.ToString();
            agregarEditarUsuario.modo_del_formulario = "Editar informacion";
            agregarEditarUsuario.textoNombreUsuario = dataUsuarios.CurrentCell.OwningRow.Cells[1].Value.ToString();
            agregarEditarUsuario.textoBotonAccionUsuario = "Guardar";
            agregarEditarUsuario.estadoGboComprobarUsuario = false;
            agregarEditarUsuario.estadoGboInformaciono = true;
            agregarEditarUsuario.estado_chkContrasela = true;
            agregarEditarUsuario.estado_txtContraseña = false;
            agregarEditarUsuario.actualizarDatosUsuarioExistente(dataUsuarios.CurrentCell.OwningRow.Cells[1].Value.ToString());
            agregarEditarUsuario.ShowDialog();
            this.Show();
            actualizarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Controlador.eliminarUsuario(dataUsuarios.CurrentCell.OwningRow.Cells[0].Value.ToString());
            actualizarTabla();
        }


        private void actualizarTabla()
        {
            dataUsuarios.DataSource = Controlador.ListaUsuarios();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!(txtBuscarUsuario.Text==""))
            {
                dataUsuarios.DataSource = Controlador.ListaUsuariosPorAproximacion(txtBuscarUsuario.Text);
                dataUsuarios.Columns.RemoveAt(5);
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
    }
}
