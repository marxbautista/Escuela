namespace Escuela.Vista
{
    partial class FrmDocente
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
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txbNombreDocente = new System.Windows.Forms.TextBox();
            this.txbClaveDocente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.dgvDocente = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tmiGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDatos.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDatos.Controls.Add(this.btnBusqueda);
            this.pnlDatos.Controls.Add(this.txbNombreDocente);
            this.pnlDatos.Controls.Add(this.txbClaveDocente);
            this.pnlDatos.Controls.Add(this.lblNombre);
            this.pnlDatos.Controls.Add(this.lblMatricula);
            this.pnlDatos.Location = new System.Drawing.Point(30, 30);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(350, 400);
            this.pnlDatos.TabIndex = 0;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(259, 38);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(24, 23);
            this.btnBusqueda.TabIndex = 4;
            this.btnBusqueda.Text = "...";
            this.btnBusqueda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // txbNombreDocente
            // 
            this.txbNombreDocente.Location = new System.Drawing.Point(127, 155);
            this.txbNombreDocente.Name = "txbNombreDocente";
            this.txbNombreDocente.Size = new System.Drawing.Size(202, 20);
            this.txbNombreDocente.TabIndex = 3;
            // 
            // txbClaveDocente
            // 
            this.txbClaveDocente.Location = new System.Drawing.Point(140, 42);
            this.txbClaveDocente.Name = "txbClaveDocente";
            this.txbClaveDocente.Size = new System.Drawing.Size(100, 20);
            this.txbClaveDocente.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 158);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(88, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Docente";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(13, 42);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(78, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Clave Docente";
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBusqueda.Controls.Add(this.txbBusqueda);
            this.pnlBusqueda.Controls.Add(this.dgvDocente);
            this.pnlBusqueda.Location = new System.Drawing.Point(400, 30);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(350, 400);
            this.pnlBusqueda.TabIndex = 1;
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Location = new System.Drawing.Point(23, 20);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(294, 20);
            this.txbBusqueda.TabIndex = 1;
            this.txbBusqueda.TextChanged += new System.EventHandler(this.txbBusqueda_TextChanged);
            // 
            // dgvDocente
            // 
            this.dgvDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocente.Location = new System.Drawing.Point(3, 211);
            this.dgvDocente.Name = "dgvDocente";
            this.dgvDocente.Size = new System.Drawing.Size(340, 161);
            this.dgvDocente.TabIndex = 0;
            this.dgvDocente.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDocente_ColumnHeaderMouseClick);
            this.dgvDocente.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDocente_RowHeaderMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.AllowMerge = false;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiGuardar,
            this.tmiModificar,
            this.tmiEliminar,
            this.tmiCancelar});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(784, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
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
            this.tmiEliminar.Click += new System.EventHandler(this.tmiEliminar_Click);
            // 
            // tmiCancelar
            // 
            this.tmiCancelar.Enabled = false;
            this.tmiCancelar.Name = "tmiCancelar";
            this.tmiCancelar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tmiCancelar.Size = new System.Drawing.Size(65, 20);
            this.tmiCancelar.Text = "&Cancelar";
            this.tmiCancelar.Click += new System.EventHandler(this.tmiCancelar_Click);
            // 
            // FrmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDocente";
            this.Text = "Docente";
            this.Load += new System.EventHandler(this.FrmDocente_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.TextBox txbNombreDocente;
        private System.Windows.Forms.TextBox txbClaveDocente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tmiGuardar;
        private System.Windows.Forms.DataGridView dgvDocente;
        private System.Windows.Forms.ToolStripMenuItem tmiModificar;
        private System.Windows.Forms.ToolStripMenuItem tmiEliminar;
        private System.Windows.Forms.ToolStripMenuItem tmiCancelar;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
    }
}