using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frmReporteCargo : Form
    {
        private string v;

        public frmReporteCargo(string nombre_reporte)
        {
            InitializeComponent();
            try
            {
                InitializeComponent();
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(nombre_reporte);
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void frmReporteCargo_Load(object sender, EventArgs e)
        {

        }
    }
}
