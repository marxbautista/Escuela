namespace Escuela.Vista
{
    partial class frmGrupo
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
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.dgvGrupo = new System.Windows.Forms.DataGridView();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.cboHorario = new System.Windows.Forms.ComboBox();
            this.cboIdClaveMateria = new System.Windows.Forms.ComboBox();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.cboDocente = new System.Windows.Forms.ComboBox();
            this.cboIdPeriodo = new System.Windows.Forms.ComboBox();
            this.lblIdHorario = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblClaveMateria = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txbClaveGrupo = new System.Windows.Forms.TextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblClaveGrupo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tmiGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBusqueda.Controls.Add(this.txbBuscar);
            this.pnlBusqueda.Controls.Add(this.dgvGrupo);
            this.pnlBusqueda.Location = new System.Drawing.Point(404, 30);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(350, 400);
            this.pnlBusqueda.TabIndex = 4;
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(21, 22);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(307, 20);
            this.txbBuscar.TabIndex = 1;
            // 
            // dgvGrupo
            // 
            this.dgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupo.Location = new System.Drawing.Point(21, 67);
            this.dgvGrupo.Name = "dgvGrupo";
            this.dgvGrupo.Size = new System.Drawing.Size(307, 315);
            this.dgvGrupo.TabIndex = 0;
            this.dgvGrupo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupo_CellContentClick);
            this.dgvGrupo.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGrupo_RowHeaderMouseClick);
            // 
            // pnlDatos
            // 
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDatos.Controls.Add(this.cboHorario);
            this.pnlDatos.Controls.Add(this.cboIdClaveMateria);
            this.pnlDatos.Controls.Add(this.cboCarrera);
            this.pnlDatos.Controls.Add(this.cboDocente);
            this.pnlDatos.Controls.Add(this.cboIdPeriodo);
            this.pnlDatos.Controls.Add(this.lblIdHorario);
            this.pnlDatos.Controls.Add(this.lblCarrera);
            this.pnlDatos.Controls.Add(this.lblClaveMateria);
            this.pnlDatos.Controls.Add(this.lblDocente);
            this.pnlDatos.Controls.Add(this.btnBusca);
            this.pnlDatos.Controls.Add(this.txbClaveGrupo);
            this.pnlDatos.Controls.Add(this.lblPeriodo);
            this.pnlDatos.Controls.Add(this.lblClaveGrupo);
            this.pnlDatos.Location = new System.Drawing.Point(31, 30);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(350, 400);
            this.pnlDatos.TabIndex = 5;
            // 
            // cboHorario
            // 
            this.cboHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHorario.FormattingEnabled = true;
            this.cboHorario.Location = new System.Drawing.Point(116, 311);
            this.cboHorario.Name = "cboHorario";
            this.cboHorario.Size = new System.Drawing.Size(121, 21);
            this.cboHorario.TabIndex = 20;
            // 
            // cboIdClaveMateria
            // 
            this.cboIdClaveMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdClaveMateria.FormattingEnabled = true;
            this.cboIdClaveMateria.Location = new System.Drawing.Point(116, 173);
            this.cboIdClaveMateria.Name = "cboIdClaveMateria";
            this.cboIdClaveMateria.Size = new System.Drawing.Size(121, 21);
            this.cboIdClaveMateria.TabIndex = 19;
            // 
            // cboCarrera
            // 
            this.cboCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Location = new System.Drawing.Point(116, 235);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(121, 21);
            this.cboCarrera.TabIndex = 18;
            // 
            // cboDocente
            // 
            this.cboDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocente.FormattingEnabled = true;
            this.cboDocente.Location = new System.Drawing.Point(116, 129);
            this.cboDocente.Name = "cboDocente";
            this.cboDocente.Size = new System.Drawing.Size(121, 21);
            this.cboDocente.TabIndex = 17;
            // 
            // cboIdPeriodo
            // 
            this.cboIdPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdPeriodo.FormattingEnabled = true;
            this.cboIdPeriodo.Location = new System.Drawing.Point(116, 81);
            this.cboIdPeriodo.Name = "cboIdPeriodo";
            this.cboIdPeriodo.Size = new System.Drawing.Size(121, 21);
            this.cboIdPeriodo.TabIndex = 16;
            // 
            // lblIdHorario
            // 
            this.lblIdHorario.AutoSize = true;
            this.lblIdHorario.Location = new System.Drawing.Point(23, 319);
            this.lblIdHorario.Name = "lblIdHorario";
            this.lblIdHorario.Size = new System.Drawing.Size(41, 13);
            this.lblIdHorario.TabIndex = 13;
            this.lblIdHorario.Text = "Horario";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(25, 243);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(41, 13);
            this.lblCarrera.TabIndex = 11;
            this.lblCarrera.Text = "Carrera";
            // 
            // lblClaveMateria
            // 
            this.lblClaveMateria.AutoSize = true;
            this.lblClaveMateria.Location = new System.Drawing.Point(17, 181);
            this.lblClaveMateria.Name = "lblClaveMateria";
            this.lblClaveMateria.Size = new System.Drawing.Size(72, 13);
            this.lblClaveMateria.TabIndex = 6;
            this.lblClaveMateria.Text = "Clave Materia";
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(17, 137);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(48, 13);
            this.lblDocente.TabIndex = 5;
            this.lblDocente.Text = "Docente";
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(240, 31);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(25, 23);
            this.btnBusca.TabIndex = 4;
            this.btnBusca.Text = "...";
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // txbClaveGrupo
            // 
            this.txbClaveGrupo.Location = new System.Drawing.Point(116, 34);
            this.txbClaveGrupo.Name = "txbClaveGrupo";
            this.txbClaveGrupo.Size = new System.Drawing.Size(100, 20);
            this.txbClaveGrupo.TabIndex = 2;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(17, 89);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(43, 13);
            this.lblPeriodo.TabIndex = 1;
            this.lblPeriodo.Text = "Periodo";
            // 
            // lblClaveGrupo
            // 
            this.lblClaveGrupo.AutoSize = true;
            this.lblClaveGrupo.Location = new System.Drawing.Point(17, 41);
            this.lblClaveGrupo.Name = "lblClaveGrupo";
            this.lblClaveGrupo.Size = new System.Drawing.Size(66, 13);
            this.lblClaveGrupo.TabIndex = 0;
            this.lblClaveGrupo.Text = "Clave Grupo";
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
            this.menuStrip1.TabIndex = 6;
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
            // frmGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.pnlDatos);
            this.Name = "frmGrupo";
            this.Text = "Grupo";
            this.Load += new System.EventHandler(this.frmGrupo_Load);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.DataGridView dgvGrupo;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblClaveMateria;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txbClaveGrupo;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblClaveGrupo;
        private System.Windows.Forms.Label lblIdHorario;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.ComboBox cboIdPeriodo;
        private System.Windows.Forms.ComboBox cboDocente;
        private System.Windows.Forms.ComboBox cboCarrera;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmiGuardar;
        private System.Windows.Forms.ToolStripMenuItem tmiModificar;
        private System.Windows.Forms.ToolStripMenuItem tmiEliminar;
        private System.Windows.Forms.ToolStripMenuItem tmiCancelar;
        private System.Windows.Forms.ComboBox cboIdClaveMateria;
        private System.Windows.Forms.ComboBox cboHorario;
    }
}