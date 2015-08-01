namespace Escuela.Vista
{
    partial class FrmTipoReporte
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
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.dgvTipoReporte = new System.Windows.Forms.DataGridView();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.btnBusca = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tmiGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoReporte)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBusqueda.Controls.Add(this.dgvTipoReporte);
            this.pnlBusqueda.Controls.Add(this.txbBusqueda);
            this.pnlBusqueda.Location = new System.Drawing.Point(397, 50);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(371, 400);
            this.pnlBusqueda.TabIndex = 7;
            // 
            // dgvTipoReporte
            // 
            this.dgvTipoReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoReporte.Location = new System.Drawing.Point(8, 134);
            this.dgvTipoReporte.Name = "dgvTipoReporte";
            this.dgvTipoReporte.Size = new System.Drawing.Size(353, 251);
            this.dgvTipoReporte.TabIndex = 2;
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Location = new System.Drawing.Point(53, 47);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(270, 20);
            this.txbBusqueda.TabIndex = 1;
            // 
            // pnlDatos
            // 
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDatos.Controls.Add(this.btnBusca);
            this.pnlDatos.Controls.Add(this.dtpFechaFin);
            this.pnlDatos.Controls.Add(this.dtpFechaInicio);
            this.pnlDatos.Controls.Add(this.label4);
            this.pnlDatos.Controls.Add(this.txbID);
            this.pnlDatos.Controls.Add(this.label3);
            this.pnlDatos.Controls.Add(this.label2);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Controls.Add(this.txbNombre);
            this.pnlDatos.Location = new System.Drawing.Point(0, 50);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(380, 400);
            this.pnlDatos.TabIndex = 6;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(228, 43);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(28, 23);
            this.btnBusca.TabIndex = 10;
            this.btnBusca.Text = "...";
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(108, 195);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 9;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(108, 149);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(94, 20);
            this.dtpFechaInicio.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(108, 46);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(66, 20);
            this.txbID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(108, 98);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(215, 20);
            this.txbNombre.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiGuardar,
            this.tmiModificar,
            this.tmiEliminar,
            this.tmiCancelar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tmiGuardar
            // 
            this.tmiGuardar.Name = "tmiGuardar";
            this.tmiGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.tmiGuardar.Size = new System.Drawing.Size(61, 20);
            this.tmiGuardar.Text = "&Guardar";
            this.tmiGuardar.Click += new System.EventHandler(this.tmiGuardar_Click);
            // 
            // tmiModificar
            // 
            this.tmiModificar.Enabled = false;
            this.tmiModificar.Name = "tmiModificar";
            this.tmiModificar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.tmiModificar.Size = new System.Drawing.Size(70, 20);
            this.tmiModificar.Text = "&Modificar";
            this.tmiModificar.Click += new System.EventHandler(this.tmiModificar_Click);
            // 
            // tmiEliminar
            // 
            this.tmiEliminar.Enabled = false;
            this.tmiEliminar.Name = "tmiEliminar";
            this.tmiEliminar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tmiEliminar.Size = new System.Drawing.Size(62, 20);
            this.tmiEliminar.Text = "&Eliminar";
            // 
            // tmiCancelar
            // 
            this.tmiCancelar.Enabled = false;
            this.tmiCancelar.Name = "tmiCancelar";
            this.tmiCancelar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tmiCancelar.Size = new System.Drawing.Size(65, 20);
            this.tmiCancelar.Text = "&Cancelar";
            // 
            // FrmTipoReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmTipoReporte";
            this.Text = "FrmTipoReporte";
            this.Load += new System.EventHandler(this.FrmTipoReporte_Load);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoReporte)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmiGuardar;
        private System.Windows.Forms.ToolStripMenuItem tmiModificar;
        private System.Windows.Forms.ToolStripMenuItem tmiEliminar;
        private System.Windows.Forms.ToolStripMenuItem tmiCancelar;
        private System.Windows.Forms.DataGridView dgvTipoReporte;
    }
}