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
    public partial class CRUDDetalleNomina : Form
    {
        public CRUDDetalleNomina()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CRUDDetalleNomina_Load(object sender, EventArgs e)
        {
            
            Operacion oper = new Operacion();

             dgvNomina.DataSource=   oper.ConsultaConResultado("select * from empleados");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
