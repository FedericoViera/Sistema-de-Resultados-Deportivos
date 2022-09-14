using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Seleccion_Aplicacion : Form
    {
        private Menu_Publico_Principal estandar;
        private Login backoffice;
        public Seleccion_Aplicacion()
        {
            InitializeComponent();
        }

        private void btnBackoffice_Click(object sender, EventArgs e)
        {
            backoffice = new Login();
            this.Hide();
            backoffice.modoFormulario=1;
            backoffice.ShowDialog();
            this.Show();
        }

        private void btnAppEstandar_Click(object sender, EventArgs e)
        {
            estandar = new Menu_Publico_Principal();
            this.Hide();
            estandar.ShowDialog();
            this.Show();
        }
    }
}
