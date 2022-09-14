using Proyecto._2__Logica.Dominio.Entidades;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Notificativo.Baja_Cuenta
{
    public partial class Rebocar_Cuenta : UserControl
    {
        public Rebocar_Cuenta()
        {
            InitializeComponent();
            cargarInformacion();
        }
        public void cargarInformacion()
        {
            cargarUsuariosPremium();
        }
        private void cargarUsuariosPremium()
        {
            dataGridUsuarios.DataSource = Controlador.UsuariosPremium();
            dataGridUsuarios.Columns[0].Visible = false;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridUsuarios.ClearSelection();
            txtBuscarUsuario.Text = "";
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int indexEncontrado = 0;
            foreach (DataGridViewRow row in dataGridUsuarios.Rows)
            {
                row.Selected = false;
            }
            try
            {
                string[] busqueda = txtBuscarUsuario.Text.Split(' ');
                bool encontrado = false;
                foreach (DataGridViewRow row in dataGridUsuarios.Rows)
                {
                    if (busqueda.Length == 1)
                    {
                        if (row.Cells[1].Value.ToString().ToUpper().Equals(busqueda[0].ToUpper()))
                        {
                            dataGridUsuarios.Rows[row.Index].Selected = true;
                            encontrado = true;
                        }
                    }
                    else
                    {
                        if (row.Cells[1].Value.ToString().ToUpper().Equals(busqueda[0].ToUpper()) && row.Cells[2].Value.ToString().ToUpper().Equals(busqueda[1].ToUpper()))
                        {
                            dataGridUsuarios.Rows[row.Index].Selected = true;

                            encontrado = true;
                            indexEncontrado = row.Index;
                        }
                    }

                }
                if (!encontrado)
                {
                    MessageBox.Show("No se encontró a: " + txtBuscarUsuario.Text);
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }       

        private void btnRebocar_Click(object sender, EventArgs e)
        {
            if (Controlador.RebocarCuenta(Int16.Parse(dataGridUsuarios.CurrentCell.OwningRow.Cells[0].Value.ToString())) == true)
            {
                cargarInformacion();
                MessageBox.Show("Cuenta rebocada exitosamente");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
