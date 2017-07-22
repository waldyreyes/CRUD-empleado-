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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_empleado emp = new frm_empleado();
            DataGridViewRow rellenar = dgvEmpleado.Rows[e.RowIndex];
            emp.txtCodigo.Text = rellenar.Cells["cod_empleado"].Value.ToString();
            emp.txtCedula.Text = rellenar.Cells["cedula"].Value.ToString();
            emp.txtNombre.Text = rellenar.Cells["nombre"].Value.ToString();
            emp.txtApellido.Text = rellenar.Cells["apellido"].Value.ToString();
            emp.txtDireccion.Text = rellenar.Cells["direccion"].Value.ToString();
            emp.cmbSexo.Text = rellenar.Cells["sexo"].Value.ToString();
            emp.txtFechaNacimiento.Text = rellenar.Cells["fecha_nacimiento"].Value.ToString();
            emp.txtFechaIngreso.Text = rellenar.Cells["fecha_ingreso"].Value.ToString();
            emp.txtCodigoDelCargo.Text = rellenar.Cells["cod_cargo"].Value.ToString();
            emp.txtSalario.Text = rellenar.Cells["sueldo"].Value.ToString();
            emp.btnBorrar.Enabled = true;
            emp.btnGuardar.Enabled = true;
            emp.btnCrear.Enabled = false;
            emp.Show();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion();//haciendo una instancia de la clase
            
            if (rbtnCodEMp.Checked == true)
            {
                
                dgvEmpleado.DataSource = op.ConsultaConResultado("SELECT * FROM empleados WhERE cod_empleado = " + txtBuscar.Text );
            }
            
            else if(rbtnNombre.Checked == true)
            {
              
              
                dgvEmpleado.DataSource = op.ConsultaConResultado("SELECT * FROM  empleados WhERE nombre = " + txtBuscar.Text);
            }

            else if (rbtnApellido.Checked  == true)
            {

                dgvEmpleado.DataSource = op.ConsultaConResultado("SELECT * FROM empleados WhERE apellido = " + txtBuscar.Text );
            }

            else  if(rbtnCedula.Checked== true )
            {

                dgvEmpleado.DataSource = op.ConsultaConResultado("SELECT * FROM empleados WhERE cedula = " + txtBuscar.Text);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frm_empleado f = new frm_empleado();
            f.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Operacion op = new Operacion ();
            op.Conectar();
            dgvEmpleado.DataSource = op.ConsultaConResultado("  SELECT * FROM empleados "); 
            
            
        }
    }
}
