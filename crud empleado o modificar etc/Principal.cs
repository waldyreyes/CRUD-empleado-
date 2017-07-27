using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_empleado_o_modificar_etc
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaEmpleado be = new frmBusquedaEmpleado();
            be.Show();
        }

        private void detalleNominaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBusqueda_Nomina bn = new frmBusqueda_Nomina();
            bn.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargo ca = new frmCargo();
            ca.Show();
        }
    }
}
