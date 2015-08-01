namespace Escuela.Vista
{
    partial class frmPeriodo2
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
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txbAnio = new System.Windows.Forms.TextBox();
            this.txbmesFin = new System.Windows.Forms.TextBox();
            this.txbmesInicio = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblMesFin = new System.Windows.Forms.Label();
            this.lblMesInicio = new System.Windows.Forms.Label();
            this.txbidPeriodo = new System.Windows.Forms.TextBox();
            this.lblIdPeriodo = new System.Windows.Forms.Label();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.dgvPeriodo2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tmiGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.pnlDatos.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.Aqua;
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDatos.Controls.Add(this.btnBusqueda);
            this.pnlDatos.Controls.Add(this.txbAnio);
            this.pnlDatos.Controls.Add(this.txbmesFin);
            this.pnlDatos.Controls.Add(this.txbmesInicio);
            this.pnlDatos.Controls.Add(this.lblAnio);
            this.pnlDatos.Controls.Add(this.lblMesFin);
            this.pnlDatos.Controls.Add(this.lblMesInicio);
            this.pnlDatos.Controls.Add(this.txbidPeriodo);
            this.pnlDatos.Controls.Add(this.lblIdPeriodo);
            this.pnlDatos.Location = new System.Drawing.Point(30, 30);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(350, 400);
            this.pnlDatos.TabIndex = 0;
            // 
            // txbAnio
            // 
            this.txbAnio.BackColor = System.Drawing.Color.Yellow;
            this.txbAnio.Location = new System.Drawing.Point(164, 209);
            this.txbAnio.Name = "txbAnio";
            this.txbAnio.Size = new System.Drawing.Size(100, 20);
            this.txbAnio.TabIndex = 7;
            // 
            // txbmesFin
            // 
            this.txbmesFin.BackColor = System.Drawing.Color.Yellow;
            this.txbmesFin.Location = new System.Drawing.Point(164, 159);
            this.txbmesFin.Name = "txbmesFin";
            this.txbmesFin.Size = new System.Drawing.Size(100, 20);
            this.txbmesFin.TabIndex = 6;
            // 
            // txbmesInicio
            // 
            this.txbmesInicio.BackColor = System.Drawing.Color.Yellow;
            this.txbmesInicio.Location = new System.Drawing.Point(164, 126);
            this.txbmesInicio.Name = "txbmesInicio";
            this.txbmesInicio.Size = new System.Drawing.Size(100, 20);
            this.txbmesInicio.TabIndex = 5;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(32, 209);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(31, 15);
            this.lblAnio.TabIndex = 4;
            this.lblAnio.Text = "Año";
            // 
            // lblMesFin
            // 
            this.lblMesFin.AutoSize = true;
            this.lblMesFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesFin.Location = new System.Drawing.Point(32, 159);
            this.lblMesFin.Name = "lblMesFin";
            this.lblMesFin.Size = new System.Drawing.Size(54, 15);
            this.lblMesFin.TabIndex = 3;
            this.lblMesFin.Text = "mes fin";
            // 
            // lblMesInicio
            // 
            this.lblMesInicio.AutoSize = true;
            this.lblMesInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesInicio.Location = new System.Drawing.Point(32, 126);
            this.lblMesInicio.Name = "lblMesInicio";
            this.lblMesInicio.Size = new System.Drawing.Size(73, 15);
            this.lblMesInicio.TabIndex = 2;
            this.lblMesInicio.Text = "mes inicio";
            // 
            // txbidPeriodo
            // 
            this.txbidPeriodo.BackColor = System.Drawing.Color.Yellow;
            this.txbidPeriodo.Enabled = false;
            this.txbidPeriodo.Location = new System.Drawing.Point(107, 76);
            this.txbidPeriodo.Name = "txbidPeriodo";
            this.txbidPeriodo.Size = new System.Drawing.Size(44, 20);
            this.txbidPeriodo.TabIndex = 1;
            this.txbidPeriodo.TextChanged += new System.EventHandler(this.txbidPeriodo_TextChanged);
            // 
            // lblIdPeriodo
            // 
            this.lblIdPeriodo.AutoSize = true;
            this.lblIdPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPeriodo.Location = new System.Drawing.Point(32, 76);
            this.lblIdPeriodo.Name = "lblIdPeriodo";
            this.lblIdPeriodo.Size = new System.Drawing.Size(69, 15);
            this.lblIdPeriodo.TabIndex = 0;
            this.lblIdPeriodo.Text = "idPeriodo";
            this.lblIdPeriodo.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.Color.Aqua;
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBusqueda.Controls.Add(this.txbBusqueda);
            this.pnlBusqueda.Controls.Add(this.dgvPeriodo2);
            this.pnlBusqueda.Location = new System.Drawing.Point(400, 30);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(350, 400);
            this.pnlBusqueda.TabIndex = 1;
            // 
            // dgvPeriodo2
            // 
            this.dgvPeriodo2.BackgroundColor = System.Drawing.Color.Magenta;
            this.dgvPeriodo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodo2.Location = new System.Drawing.Point(56, 140);
            this.dgvPeriodo2.Name = "dgvPeriodo2";
            this.dgvPeriodo2.Size = new System.Drawing.Size(259, 192);
            this.dgvPeriodo2.TabIndex = 0;
            this.dgvPeriodo2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeriodo_CellContentClick);
            this.dgvPeriodo2.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPeriodo2_ColumnHeaderMouseClick);
            this.dgvPeriodo2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPeriodo2_RowHeaderMouseClick);
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
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tmiGuardar
            // 
            this.tmiGuardar.Name = "tmiGuardar";
            this.tmiGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.tmiGuardar.Size = new System.Drawing.Size(60, 20);
            this.tmiGuardar.Text = "&guardar";
            this.tmiGuardar.Click += new System.EventHandler(this.tmiGuardar_Click);
            // 
            // tmiModificar
            // 
            this.tmiModificar.Enabled = false;
            this.tmiModificar.Name = "tmiModificar";
            this.tmiModificar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.tmiModificar.Size = new System.Drawing.Size(70, 20);
            this.tmiModificar.Text = "&modificar";
            this.tmiModificar.Click += new System.EventHandler(this.tmiModificar_Click);
            // 
            // tmiEliminar
            // 
            this.tmiEliminar.Enabled = false;
            this.tmiEliminar.Name = "tmiEliminar";
            this.tmiEliminar.Size = new System.Drawing.Size(62, 20);
            this.tmiEliminar.Text = "&Eliminar";
            this.tmiEliminar.Click += new System.EventHandler(this.tmiEliminar_Click);
            // 
            // tmiCancelar
            // 
            this.tmiCancelar.Enabled = false;
            this.tmiCancelar.Name = "tmiCancelar";
            this.tmiCancelar.Size = new System.Drawing.Size(65, 20);
            this.tmiCancelar.Text = "&Cancelar";
            this.tmiCancelar.Click += new System.EventHandler(this.tmiCancelar_Click);
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Location = new System.Drawing.Point(74, 52);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(217, 20);
            this.txbBusqueda.TabIndex = 1;
            this.txbBusqueda.TextChanged += new System.EventHandler(this.txbBusqueda_TextChanged);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(227, 74);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(37, 23);
            this.btnBusqueda.TabIndex = 8;
            this.btnBusqueda.Text = "...";
            this.btnBusqueda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // frmPeriodo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPeriodo2";
            this.Text = "Periodo2";
            this.Load += new System.EventHandler(this.frmPeriodo2_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.TextBox txbAnio;
        private System.Windows.Forms.TextBox txbmesFin;
        private System.Windows.Forms.TextBox txbmesInicio;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblMesFin;
        private System.Windows.Forms.Label lblMesInicio;
        private System.Windows.Forms.TextBox txbidPeriodo;
        private System.Windows.Forms.Label lblIdPeriodo;
        private System.Windows.Forms.DataGridView dgvPeriodo2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmiGuardar;
        private System.Windows.Forms.ToolStripMenuItem tmiModificar;
        private System.Windows.Forms.ToolStripMenuItem tmiEliminar;
        private System.Windows.Forms.ToolStripMenuItem tmiCancelar;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
    }
}