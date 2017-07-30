﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
            Operacion op = new Operacion();
            int numero_nomina=0;
           
            Operacion oper = new Operacion();
            txtNumeroNomina.Text = Convert.ToString( numero_nomina + 1); 

            dgvNomina.DataSource=   oper.ConsultaConResultado("select a.nombre, a.apellido, a.cedula, b.nombre_cargo, a.sueldo,  (a.sueldo*0.12) isr, (a.sueldo *0.04) ss, (a.sueldo * 0.02) otros, ((a.sueldo*0.12) + (a.sueldo *0.04) + (a.sueldo * 0.02)) total_deducciones, (a.sueldo-(a.sueldo*0.12) - (a.sueldo *0.04) - (a.sueldo * 0.02)) sueldo_neto from empleados a  inner join cargo b where a.cod_cargo=b.cod_cargo");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(cmbEstatus.Text == "Nuevo")
            {
                btnGenerarNomina.Enabled = true;
            }
            else
            {
                btnGenerarNomina.Enabled = false;
            }
        }

        private void btnGenerarNomina_Click(object sender, DataGridView e)
        {
            Operacion op = new Operacion();
            
            DataGridViewRow rellenar = dgvNomina.Rows[e.NewRowIndex];
            float sueldo_bruto = 0;

            float Isr = float.Parse(rellenar.Cells["isr"].Value.ToString());
            float Ss = float.Parse(rellenar.Cells["ss"].Value.ToString());
            float Otros = float.Parse(rellenar.Cells["otros"].Value.ToString());
            float Total_deducciones = float.Parse(rellenar.Cells["total_deducciones"].Value.ToString());
            float Sueldo_neto = float.Parse(rellenar.Cells["sueldo_neto"].Value.ToString());
            sueldo_bruto = float.Parse(rellenar.Cells["sueldo"].Value.ToString());

            float total_nomina = +sueldo_bruto;
            txtTotalNomina.Text = Convert.ToString(total_nomina);


            op.ConsultasSinResultados("insert into detalle_nomina(isr, ss, otros, total_deducciones, sueldo_neto, total_nomina, num_nomina) values('" + Isr + "', '" + Ss + "', '" + Otros + "', '" + Total_deducciones + "', '" + Sueldo_neto + "', '" + txtTotalNomina.Text + "', '" + txtNumeroNomina.Text + "')");


            // DataGridViewRow rellenar = dgvNomina.Rows[e.RowIndex];


            /*Operacion op = new Operacion();
            SQLiteConnection conexion  = new SQLiteConnection("Data Source=C:\\SISTEMAS\\nomina.s3db; Version=3;");

            SQLiteCommand agregar = new SQLiteCommand("insert into detalle_nomina (@isr, @ss, @otros, @total_deducciones)", conexion);
            conexion.Open();

            

            try
            {
                foreach (DataGridViewRow row in dgvNomina.Rows)
                {
                    op.ConsultasSinResultados("insert into detalle_nomina (isr, ss, otros, total_deducciones, sueldo_neto, num_nomina, total_nomina) value('"+ row.Cells ["Column1"].Value+"', '"+ row.Cells ["Column2"].Value +"', '" +row.Cells ["Column3"].Value+ "', '"+row.Cells["Column4"].Value+"', '"+row.Cells["Column5"]+"', '"+txtNumeroNomina.Text+"', '' )");
                    agregar.Parameters.Clear();

                    agregar.Parameters.AddWithValue("@isr", row.Cells[1].Value);
                    agregar.Parameters.AddWithValue("@ss", row.Cells[2].Value);
                    agregar.Parameters.AddWithValue("@otros", row.Cells[3].Value);
                    agregar.Parameters.AddWithValue("@total_deducciones",row.Cells[4].Value);
                   // agregar.Parameters.AddWithValue("@sueldo_neto", row.Cells["Column5"].Value);
                    // agregar.Parameters.AddWithValue("@num_nomina", txtNumeroNomina.Text;
                    // agregar.Parameters.AddWithValue("@total_nomina", );

                    agregar.ExecuteNonQuery();


                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("error al agregar ");
            }
            finally
            {
                conexion.Close();
            }
            */
        }

        public void dgvNomina_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Operacion op = new Operacion();
            DataGridViewRow rellenar = dgvNomina.Rows[e.RowIndex];
            float sueldo_bruto=0;
            
            
                foreach (DataGridViewRow row in dgvNomina.Rows)
                {

                    float Isr = float.Parse(rellenar.Cells["isr"].Value.ToString());
                    float Ss = float.Parse(rellenar.Cells["ss"].Value.ToString());
                    float Otros = float.Parse(rellenar.Cells["otros"].Value.ToString());
                    float Total_deducciones = float.Parse(rellenar.Cells["total_deducciones"].Value.ToString());
                    float Sueldo_neto = float.Parse(rellenar.Cells["sueldo_neto"].Value.ToString());
                    sueldo_bruto = float.Parse(rellenar.Cells["sueldo"].Value.ToString());

                    float total_nomina = +sueldo_bruto;
                    txtTotalNomina.Text = Convert.ToString(total_nomina);


                    op.ConsultasSinResultados("insert into detalle_nomina(isr, ss, otros, total_deducciones, sueldo_neto, total_nomina, num_nomina) values('" + Isr + "', '" + Ss + "', '" + Otros + "', '" + Total_deducciones + "', '" + Sueldo_neto + "', '" + txtTotalNomina.Text + "', '" + txtNumeroNomina.Text + "')");

                
            }
            
        }
    }
}
