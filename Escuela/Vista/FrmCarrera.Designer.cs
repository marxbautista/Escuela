namespace Escuela.Vista
{
    partial class FrmCarrera
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
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dgvCarrera = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCodigoDeLaCarrera = new System.Windows.Forms.Label();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.lblNumCarrera = new System.Windows.Forms.Label();
            this.txtPlanes = new System.Windows.Forms.TextBox();
            this.lblPlanes = new System.Windows.Forms.Label();
            this.txtNumCarrera = new System.Windows.Forms.TextBox();
            this.lblNombreCarrera = new System.Windows.Forms.Label();
            this.txtCodigoDeLaCarrera = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tmiGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(351, 77);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(29, 23);
            this.btnBusqueda.TabIndex = 11;
            this.btnBusqueda.Text = "...";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtBusqueda);
            this.panel2.Controls.Add(this.dgvCarrera);
            this.panel2.Location = new System.Drawing.Point(400, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 400);
            this.panel2.TabIndex = 13;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(3, 14);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(300, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // dgvCarrera
            // 
            this.dgvCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrera.Location = new System.Drawing.Point(3, 82);
            this.dgvCarrera.Name = "dgvCarrera";
            this.dgvCarrera.Size = new System.Drawing.Size(380, 150);
            this.dgvCarrera.TabIndex = 0;
            this.dgvCarrera.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCarrera_ColumnHeaderMouseClick);
            this.dgvCarrera.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCarrera_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblCodigoDeLaCarrera);
            this.panel1.Controls.Add(this.txtNombreCarrera);
            this.panel1.Controls.Add(this.lblNumCarrera);
            this.panel1.Controls.Add(this.txtPlanes);
            this.panel1.Controls.Add(this.lblPlanes);
            this.panel1.Controls.Add(this.txtNumCarrera);
            this.panel1.Controls.Add(this.lblNombreCarrera);
            this.panel1.Controls.Add(this.txtCodigoDeLaCarrera);
            this.panel1.Location = new System.Drawing.Point(30, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 400);
            this.panel1.TabIndex = 12;
            // 
            // lblCodigoDeLaCarrera
            // 
            this.lblCodigoDeLaCarrera.AutoSize = true;
            this.lblCodigoDeLaCarrera.Location = new System.Drawing.Point(82, 32);
            this.lblCodigoDeLaCarrera.Name = "lblCodigoDeLaCarrera";
            this.lblCodigoDeLaCarrera.Size = new System.Drawing.Size(100, 13);
            this.lblCodigoDeLaCarrera.TabIndex = 0;
            this.lblCodigoDeLaCarrera.Text = "Codigo de la Carrea";
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.Location = new System.Drawing.Point(222, 122);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCarrera.TabIndex = 7;
            // 
            // lblNumCarrera
            // 
            this.lblNumCarrera.AutoSize = true;
            this.lblNumCarrera.Location = new System.Drawing.Point(85, 60);
            this.lblNumCarrera.Name = "lblNumCarrera";
            this.lblNumCarrera.Size = new System.Drawing.Size(107, 13);
            this.lblNumCarrera.TabIndex = 1;
            this.lblNumCarrera.Text = "Numero de la Carrera";
            // 
            // txtPlanes
            // 
            this.txtPlanes.Location = new System.Drawing.Point(222, 91);
            this.txtPlanes.Name = "txtPlanes";
            this.txtPlanes.Size = new System.Drawing.Size(100, 20);
            this.txtPlanes.TabIndex = 6;
            // 
            // lblPlanes
            // 
            this.lblPlanes.AutoSize = true;
            this.lblPlanes.Location = new System.Drawing.Point(85, 91);
            this.lblPlanes.Name = "lblPlanes";
            this.lblPlanes.Size = new System.Drawing.Size(39, 13);
            this.lblPlanes.TabIndex = 2;
            this.lblPlanes.Text = "Planes";
            // 
            // txtNumCarrera
            // 
            this.txtNumCarrera.Location = new System.Drawing.Point(222, 60);
            this.txtNumCarrera.Name = "txtNumCarrera";
            this.txtNumCarrera.Size = new System.Drawing.Size(100, 20);
            this.txtNumCarrera.TabIndex = 5;
            // 
            // lblNombreCarrera
            // 
            this.lblNombreCarrera.AutoSize = true;
            this.lblNombreCarrera.Location = new System.Drawing.Point(88, 122);
            this.lblNombreCarrera.Name = "lblNombreCarrera";
            this.lblNombreCarrera.Size = new System.Drawing.Size(107, 13);
            this.lblNombreCarrera.TabIndex = 3;
            this.lblNombreCarrera.Text = "Nombre de la Carrera";
            // 
            // txtCodigoDeLaCarrera
            // 
            this.txtCodigoDeLaCarrera.Location = new System.Drawing.Point(222, 32);
            this.txtCodigoDeLaCarrera.Name = "txtCodigoDeLaCarrera";
            this.txtCodigoDeLaCarrera.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDeLaCarrera.TabIndex = 4;
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
            this.menuStrip1.TabIndex = 14;
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
            // FrmCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmCarrera";
            this.Text = "frmCarrera";
            this.Load += new System.EventHandler(this.frmCarrera_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dgvCarrera;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCodigoDeLaCarrera;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.Label lblNumCarrera;
        private System.Windows.Forms.TextBox txtPlanes;
        private System.Windows.Forms.Label lblPlanes;
        private System.Windows.Forms.TextBox txtNumCarrera;
        private System.Windows.Forms.Label lblNombreCarrera;
        private System.Windows.Forms.TextBox txtCodigoDeLaCarrera;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmiGuardar;
        private System.Windows.Forms.ToolStripMenuItem tmiModificar;
        private System.Windows.Forms.ToolStripMenuItem tmiEliminar;
        private System.Windows.Forms.ToolStripMenuItem tmiCancelar;
    }
}