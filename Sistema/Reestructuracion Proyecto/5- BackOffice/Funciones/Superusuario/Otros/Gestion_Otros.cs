using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Superusuario.Paises
{
    public partial class Gestion_Otros : UserControl
    {
        public Gestion_Otros()
        {
            InitializeComponent();
            cargarInformacion();
        }

        public void cargarInformacion()
        {
            cargarPaises();
            cargarEmpresas();
            cargarServidores();
        }
        private void cargarPaises()
        {
            tablaPaises.Rows.Clear();
            var manejador = Controlador.getDominio().paises;
            for (int i = 0; i < manejador.Count; i++)
            {
                tablaPaises.Rows.Add(manejador.ElementAt(i).nombre);
            }

        }
        private void cargarServidores()
        {
            tablaServidores.Rows.Clear();
            var manejador = Controlador.getDominio().servidores;
            for (int i = 0; i < manejador.Count; i++)
            {
                tablaServidores.Rows.Add(manejador.ElementAt(i).nombre);
            }

        }
        private void cargarEmpresas()
        {
            tablaEmpresas.Rows.Clear();
            var manejador = Controlador.getDominio().empresas;
            for (int i = 0; i < manejador.Count; i++)
            {
                tablaEmpresas.Rows.Add(manejador.ElementAt(i).nombre);
            }

        }

        private void btnCrearPais_Click(object sender, EventArgs e)
        {
            if (txtAgregarPais.Text=="")
            {
                MessageBox.Show("Debe ingresar un nombre primero");
            } else { 
            bool existe = true;
            int contador = tablaPaises.Rows.Count - 1;
            for (int i = 0; i < contador; i++)
            {
                if (Controlador.guardarPais(txtAgregarPais.Text) == false)
                {
                    existe = false;
                    tablaPaises.Rows.Add(txtAgregarPais.Text);
                    tablaPaises.Sort(tablaPaises.Columns[0], ListSortDirection.Ascending);
                    txtAgregarPais.Text = "";
                }
            }
            if (existe == true)
            {
                MessageBox.Show("Nombre de pais ya existe");
            }
            else
            {
                MessageBox.Show("Creado correctamente");
            }
            }
        }


        private void btnEliminarPais_Click(object sender, EventArgs e)
        {
            if (Controlador.eliminarPais(tablaPaises.CurrentCell.OwningRow.Cells[0].Value.ToString()) == true)
            {
                tablaPaises.Rows.RemoveAt(tablaPaises.CurrentCell.RowIndex);
            }
        }

        private void btnCrearEmpresa_Click(object sender, EventArgs e)
        {
            if (txtEmpresa.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre primero");
            }
            else
            {      
            bool existe = true;
            int contador = tablaEmpresas.Rows.Count - 1;
            for (int i = 0; i < contador; i++)
            {
                if (Controlador.guardarEmpresa(txtEmpresa.Text) == false)
                {
                    existe = false;
                    tablaEmpresas.Rows.Add(txtEmpresa.Text);
                    txtEmpresa.Text = "";
                    tablaEmpresas.Sort(tablaEmpresas.Columns[0], ListSortDirection.Ascending);
                }
            }
            if (existe == true)
            {
                MessageBox.Show("Nombre de pais ya existe");
            }
            else
            {
                MessageBox.Show("Creado correctamente");
            }
            }
        }

        private void btnEliminarEmpresa_Click(object sender, EventArgs e)
        {
            if (Controlador.eliminarEmpresa(tablaEmpresas.CurrentCell.OwningRow.Cells[0].Value.ToString()) == true)
            {
                tablaEmpresas.Rows.RemoveAt(tablaEmpresas.CurrentCell.RowIndex);
            }
        }

        private void tablaServidores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIpServidor.Text = Controlador.IpServidor(tablaServidores.CurrentCell.OwningRow.Cells[0].Value.ToString());
        }

        private void btnActualizarIP_Click(object sender, EventArgs e)
        {
            if (!(txtIpServidor.Text != ""))
            {
                MessageBox.Show("Debe ingresar una IP, no puede dejarse en banco");
            } else { 
            if (Controlador.actualizarIpServidor(txtIpServidor.Text, tablaServidores.CurrentCell.OwningRow.Cells[0].Value.ToString()))
            {
                txtIpServidor.Text = "";
                MessageBox.Show("Actualizado correctamente");
            } else
            {
                MessageBox.Show("Hubo un error");
                }
            }
        }
    }
}
