namespace Escuela.Vista
{
    partial class FrmAlumno
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
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbMatricula = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.txbBusca = new System.Windows.Forms.TextBox();
            this.dgvAlumno = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tmiGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBusca = new System.Windows.Forms.Button();
            this.pnlDatos.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDatos.Controls.Add(this.btnBusca);
            this.pnlDatos.Controls.Add(this.txbNombre);
            this.pnlDatos.Controls.Add(this.txbMatricula);
            this.pnlDatos.Controls.Add(this.lblNombre);
            this.pnlDatos.Controls.Add(this.lblMatricula);
            this.pnlDatos.Location = new System.Drawing.Point(30, 30);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(350, 400);
            this.pnlDatos.TabIndex = 0;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(88, 132);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(238, 20);
            this.txbNombre.TabIndex = 3;
            // 
            // txbMatricula
            // 
            this.txbMatricula.Location = new System.Drawing.Point(88, 67);
            this.txbMatricula.Name = "txbMatricula";
            this.txbMatricula.Size = new System.Drawing.Size(100, 20);
            this.txbMatricula.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 132);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(23, 67);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(52, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBusqueda.Controls.Add(this.txbBusca);
            this.pnlBusqueda.Controls.Add(this.dgvAlumno);
            this.pnlBusqueda.Location = new System.Drawing.Point(400, 30);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(350, 400);
            this.pnlBusqueda.TabIndex = 1;
            // 
            // txbBusca
            // 
            this.txbBusca.Location = new System.Drawing.Point(21, 22);
            this.txbBusca.Name = "txbBusca";
            this.txbBusca.Size = new System.Drawing.Size(307, 20);
            this.txbBusca.TabIndex = 1;
            this.txbBusca.TextChanged += new System.EventHandler(this.txbBusca_TextChanged);
            // 
            // dgvAlumno
            // 
            this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumno.Location = new System.Drawing.Point(21, 67);
            this.dgvAlumno.Name = "dgvAlumno";
            this.dgvAlumno.Size = new System.Drawing.Size(307, 315);
            this.dgvAlumno.TabIndex = 0;
            this.dgvAlumno.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAlumno_ColumnHeaderMouseClick);
            this.dgvAlumno.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAlumno_RowHeaderMouseClick);
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
            this.tmiEliminar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
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
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(214, 63);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(25, 23);
            this.btnBusca.TabIndex = 4;
            this.btnBusca.Text = "...";
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // FrmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAlumno";
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.FrmAlumno_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmiGuardar;
        private System.Windows.Forms.DataGridView dgvAlumno;
        private System.Windows.Forms.ToolStripMenuItem tmiModificar;
        private System.Windows.Forms.ToolStripMenuItem tmiEliminar;
        private System.Windows.Forms.TextBox txbBusca;
        private System.Windows.Forms.ToolStripMenuItem tmiCancelar;
        private System.Windows.Forms.Button btnBusca;
    }
}