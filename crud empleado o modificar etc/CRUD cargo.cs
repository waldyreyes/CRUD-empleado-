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
    public partial class frmCargo : Form
    {
        public frmCargo()
        {
            InitializeComponent();
        }

        private void frmCargo_Load(object sender, EventArgs e)
        {
            
            Operacion op = new Operacion();
            dgvCargo.DataSource = op.ConsultaConResultado("select * from cargo");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion();//haciendo una instancia de la clase

            if (rbtnCodigo.Checked == true)
            {

                dgvCargo.DataSource = op.ConsultaConResultado("SELECT * FROM cargo WhERE cod_cargo  LIKE '%" + txtBuscar.Text.Trim() + "%'");
            }

            else if(rbtnNombre.Checked==true)
            {
                dgvCargo.DataSource = op.ConsultaConResultado("select * from cargo where nombre_cargo like '%"+txtBuscar.Text.Trim()+"%'");
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion();

            if (txtCodCargo.Text == "")
            {
                if (txtNombreCargo.Text != "")
                {

                    op.ConsultasSinResultados("INSERT INTO cargo(nombre_cargo) values('" + txtNombreCargo.Text + "')");
                    MessageBox.Show(txtNombreCargo.Text + " GUARDADO", "DATOS GUARDADOS ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("FALTA NOMBRE DEL CARGAO", "ENTRE NOMBRE DEL CARGO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombreCargo.Focus();
                }
            }
            else if(txtCodCargo.Text !="")
            {
                if (MessageBox.Show("REALMENTE DECEA MODIFICAR ESTE CAMPO ", "UPDATE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    op.ConsultasSinResultados("UPDATE cargo SET cod_cargo = '" + txtCodCargo.Text + "', nombre_cargo = '" + txtNombreCargo.Text + "' WHERE cod_cargo LIKE '%" + txtCodCargo.Text + "%'");//todo funciona correctamente
                    MessageBox.Show(txtCodCargo.Text +" GUARDADO CORRECTAMENTE", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtCodCargo.Text  = "";
            txtNombreCargo.Text = "";
        }

        private void dgvCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("REALMENTE DECEA ELIMINAR A " + txtNombreCargo.Text, "ELIMINAR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Operacion op = new Operacion();
                op.ConsultasSinResultados("DELETE FROM cargo WHERE cod_cargo = '" + txtCodCargo.Text + "'");
                MessageBox.Show("REGISTRO BORRADO");
            }
            
        }

        private void dgvCargo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            btnBorrar.Enabled = true;
            DataGridViewRow rellenar = dgvCargo.Rows[e.RowIndex];
            txtCodCargo.Text = rellenar.Cells["cod_cargo"].Value.ToString();
            txtNombreCargo.Text = rellenar.Cells["nombre_cargo"].Value.ToString();
        }
    }
}
