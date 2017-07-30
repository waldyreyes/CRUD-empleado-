namespace crud_empleado_o_modificar_etc
{
    partial class CRUDDetalleNomina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGenerarNomina = new System.Windows.Forms.Button();
            this.dgvEmpleado = new System.Windows.Forms.Button();
            this.btnModificarNomina = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dgvNomina = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbEstatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtNumeroNomina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalNomina = new System.Windows.Forms.TextBox();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomina)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGenerarNomina);
            this.groupBox4.Controls.Add(this.dgvEmpleado);
            this.groupBox4.Controls.Add(this.btnModificarNomina);
            this.groupBox4.Controls.Add(this.btnBorrar);
            this.groupBox4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(856, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 438);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Botones de Control";
            // 
            // btnGenerarNomina
            // 
            this.btnGenerarNomina.Location = new System.Drawing.Point(18, 52);
            this.btnGenerarNomina.Name = "btnGenerarNomina";
            this.btnGenerarNomina.Size = new System.Drawing.Size(140, 29);
            this.btnGenerarNomina.TabIndex = 18;
            this.btnGenerarNomina.Text = "Generar Nomina";
            this.btnGenerarNomina.UseVisualStyleBackColor = true;
            //this.btnGenerarNomina.Click += new System.EventHandler(this.btnGenerarNomina_Click);
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmpleado.Location = new System.Drawing.Point(18, 336);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.Size = new System.Drawing.Size(140, 36);
            this.dgvEmpleado.TabIndex = 21;
            this.dgvEmpleado.Text = "Imprimir";
            this.dgvEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnModificarNomina
            // 
            this.btnModificarNomina.Enabled = false;
            this.btnModificarNomina.Location = new System.Drawing.Point(18, 129);
            this.btnModificarNomina.Name = "btnModificarNomina";
            this.btnModificarNomina.Size = new System.Drawing.Size(140, 33);
            this.btnModificarNomina.TabIndex = 19;
            this.btnModificarNomina.Text = "Modificar ";
            this.btnModificarNomina.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(18, 223);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(140, 37);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // dgvNomina
            // 
            this.dgvNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNomina.Location = new System.Drawing.Point(6, 22);
            this.dgvNomina.Name = "dgvNomina";
            this.dgvNomina.Size = new System.Drawing.Size(825, 190);
            this.dgvNomina.TabIndex = 24;
            this.dgvNomina.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNomina_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNomina);
            this.groupBox2.Location = new System.Drawing.Point(13, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 219);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.Items.AddRange(new object[] {
            "Nuevo",
            "En Proceso"});
            this.cmbEstatus.Location = new System.Drawing.Point(73, 27);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(121, 21);
            this.cmbEstatus.TabIndex = 26;
            this.cmbEstatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbEstatus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Estatus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEstatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(59, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 77);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estatus";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(280, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 77);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fecha";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(321, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desde";
            // 
            // txtNumeroNomina
            // 
            this.txtNumeroNomina.Location = new System.Drawing.Point(133, 127);
            this.txtNumeroNomina.Name = "txtNumeroNomina";
            this.txtNumeroNomina.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroNomina.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Numero de Nomina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Total de la Nomina";
            // 
            // txtTotalNomina
            // 
            this.txtTotalNomina.Location = new System.Drawing.Point(575, 386);
            this.txtTotalNomina.Name = "txtTotalNomina";
            this.txtTotalNomina.Size = new System.Drawing.Size(100, 20);
            this.txtTotalNomina.TabIndex = 32;
            // 
            // txtSS
            // 
            this.txtSS.Location = new System.Drawing.Point(353, 126);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(100, 20);
            this.txtSS.TabIndex = 34;
            // 
            // CRUDDetalleNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 556);
            this.Controls.Add(this.txtSS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalNomina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumeroNomina);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "CRUDDetalleNomina";
            this.Text = "Crud Detalle Nomina";
            this.Load += new System.EventHandler(this.CRUDDetalleNomina_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomina)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Button btnGenerarNomina;
        public System.Windows.Forms.Button dgvEmpleado;
        public System.Windows.Forms.Button btnModificarNomina;
        public System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbEstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNumeroNomina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalNomina;
        private System.Windows.Forms.TextBox txtSS;
        public System.Windows.Forms.DataGridView dgvNomina;
    }
}