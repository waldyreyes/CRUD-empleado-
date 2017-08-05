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
    public partial class frmBusqueda_Nomina : Form
    {
        public frmBusqueda_Nomina()
        {
            InitializeComponent();
        }

        private void g_Enter(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CRUDDetalleNomina cdn = new CRUDDetalleNomina();
            cdn.Show();
        }

        private void frmBusqueda_Nomina_Load(object sender, EventArgs e)
        {
            Operacion op = new Operacion();
           dgvBusquedaNomina.DataSource = op.ConsultaConResultado(" select cabecera_nomina.num_nomina, cabecera_nomina.fecha_inicio , cabecera_nomina.fecha_final, detalle_nomina.total_deducciones, detalle_nomina.total_nomina, cabecera_nomina.estatus from cabecera_nomina inner join detalle_nomina where cabecera_nomina.num_nomina  = detalle_nomina.num_nomina");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
