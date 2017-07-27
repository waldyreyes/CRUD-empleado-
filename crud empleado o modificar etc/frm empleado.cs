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
    public partial class frm_empleado : Form
    {
        public frm_empleado()
        {
            InitializeComponent();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)// problemas con el update 
        {
            if (MessageBox.Show("SEGURO QUE DECEA MODIFICAR ESTE REGISTRO?", "ACTUALIZAR EMPLEADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Operacion op = new Operacion();
                // txtCodigo.ReadOnly = false;
                op.ConsultasSinResultados ("UPDATE empleados SET cedula = '" + txtCedula.Text + "', nombre = '" + txtNombre.Text + "', apellido = '" + txtApellido.Text + "', direccion = '" + txtDireccion.Text + "' sexo = '" + cmbSexo.Text + "' sueldo = '" + txtSalario.Text + "' fecha_nacimiento = '" + txtFechaNacimiento.Text + "' fecha_ingreso = '" + txtFechaIngreso.Text + "' cod_cargo = '" + txtCodigoDelCargo.Text + "' WHERE cod_empleado LIKE '%" + txtCodigo.ToString() + "%' ");
               // op.ConsultasSinResultados("UPDATE empleados SET (cedula, nombre, apellido, direccion, sexo, sueldo, fecha_nacimiento, fecha_ingreso, cod_cargo) VALUES('" + txtCedula.Text + "', '" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtDireccion.Text + "', '" + cmbSexo.Text + "', '" + txtSalario.Text + "', '" + txtFechaNacimiento.Text + "','" + txtFechaIngreso.Text + "', '" + txtCodigoDelCargo.Text + "'WHERE cod_empleado LIKE '%"+ txtCodigo.Text +"%')");
            }
            else
            {

            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                
                Operacion op = new Operacion();// INSTANCIA DE LA CLASE OPERACION 
                //op.ConsultaConResultado("SELECT cedula INTO EMPLEADOS");
                op.ConsultasSinResultados("INSERT INTO empleados(cedula, nombre, apellido, direccion, sexo, sueldo, fecha_nacimiento, fecha_ingreso, cod_cargo) VALUES('" + txtCedula.Text + "', '" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtDireccion.Text + "', '" + cmbSexo.Text + "', '" + txtSalario.Text + "', '" + txtFechaNacimiento.Text + "','" + txtFechaIngreso.Text + "', '" + txtCodigoDelCargo.Text + "')");
                borrar();//para borrar los textbox
                MessageBox.Show("DATOS GUARDADOS");
            }
        }

        private Boolean  validarCampos()//metodo para validar los campos 
        {
            if (txtCedula.Text == "   -       -")
            {
                MessageBox.Show("POR FAVOR ESCRIBA LA CEDULA","ESCRIBIR CEDULA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCedula.Focus();
                return false;
            }

            if(txtNombre.Text=="")
            {
                MessageBox.Show("POR FAVOR ESCRIBA EL NOMBRE ");
                txtNombre.Focus();
                return false;
            }

            if(txtApellido.Text=="")
            {
                MessageBox.Show("POR FAVOR ESCRIBA EL APELLIDO");
                txtApellido.Focus();
                return false;
            }

            if(txtDireccion.Text =="")
            {
                MessageBox.Show("POR FAVOR ESCRIBA LA DIRECCION");
                txtDireccion.Focus();
                return false;
            }
            if(txtFechaNacimiento.Text =="")
            {
                MessageBox.Show("POR FAVOR ESCRIBA LA FECHA DE NACIMIENTO");
                txtFechaNacimiento.Focus();
                return false;
            }

            if(txtFechaIngreso.Text=="")
            {
                MessageBox.Show ("POR FAVOR ESCRINA LA FECHA DE INGRESO");
                txtFechaIngreso.Focus();
                return false;
            }
            if(txtCodigoDelCargo.Text =="")
            {
                MessageBox.Show("POR FAVOR ESCRIBA EL CODIGO DEL CARGO");
                txtCodigoDelCargo.Focus();
                return false;

            }

            if(txtSalario.Text =="")
            {
                MessageBox.Show("POR FAVOR ESCRIBA EL SALARIO");
                txtSalario.Focus();
                return false;
            }
        
            else return true;
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void borrar()//metodo para borrar los txbox
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCedula.Text = "";
            txtDireccion.Text = "";
            txtCodigoDelCargo.Text = "";
            txtSalario.Text = "";
            txtFechaIngreso.Text = "";
            txtFechaNacimiento.Text  = "";
            txtSalario.Text = "";

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            
            Operacion op = new Operacion();
            frmBusquedaEmpleado emp = new frmBusquedaEmpleado();

            if (MessageBox.Show("SEGURO QUE DESEA ELIMINAR ESTE REGISTRO?", "ELIMINAR ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                op.ConsultasSinResultados("DELETE FROM empleados WHERE cod_empleado = '" + txtCodigo.Text + "'");//elimina bien 
                borrar();// METODO OPARA BORRAR LOS CAMPOS 
                MessageBox.Show("REGISTRO BORRADO");
                btnBorrar.Enabled = false;
                btnGuardar.Enabled = false;
                btnCrear.Enabled = true;
            }
            else
            {
                //this.Close();
            }
        }

        private void btnCalcularEdad_Click(object sender, EventArgs e)//calcula bien 
        {
            if (txtFechaNacimiento.Text == "  /  /")
            {
                MessageBox.Show("ENTRE UNA FECHA DE NACIMIENTO PARA PODER CALCULAR LA EDAD","SIN FECHA DE NACIMIENTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nac = txtFechaNacimiento.Text;
                DateTime a = Convert.ToDateTime(nac);
                int edad = DateTime.Today.AddTicks(-a.Ticks).Year - 1;
                txtEdad.Text = Convert.ToString(edad + " AÑOS DE EDAD");
            }
        }
         
        
        private void btnCalcularAntiguedad_Click(object sender, EventArgs e)//calcula bien 
        {
            if (txtFechaIngreso.Text == "  /  /")
            {
                MessageBox.Show("ENTRE UNA FECHA DE INGRESO PARA PODER CALCULAR LA ANTIGUEDAD","SIN FECHA DE INGRESO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string anti = txtFechaIngreso.Text;
                DateTime a = Convert.ToDateTime(anti);
                int antiguedad = DateTime.Today.AddTicks(-a.Ticks).Year - 1;
                txtAntiguedad.Text = Convert.ToString(antiguedad + " AÑOS DE ANTIGUEDAD");
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar v = new Validar();
            v.soloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar v = new Validar();
            v.soloLetras(e);
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar v = new Validar();
            v.soloNumeros(e);
        }

        private void frm_empleado_Load(object sender, EventArgs e)
        {
            /*if(txtCodigo.Text=="")
            {
                btnBorrar.Enabled = false;
            }
            else
            {
                btnBorrar.Enabled = true;
            }*/
        }
    }
}
