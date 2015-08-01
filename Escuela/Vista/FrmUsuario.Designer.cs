namespace Escuela.Vista
{
    partial class FrmUsuario
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
            this.txbBusca = new System.Windows.Forms.TextBox();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.txbcUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbocDocente = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txbcRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbcContrasenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.cboDocente = new System.Windows.Forms.ComboBox();
            this.txbContrasenia = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txbIdusuario = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tmiGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBusqueda.Controls.Add(this.txbBusca);
            this.pnlBusqueda.Controls.Add(this.dgvUsuario);
            this.pnlBusqueda.Location = new System.Drawing.Point(402, 31);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(350, 400);
            this.pnlBusqueda.TabIndex = 3;
            // 
            // txbBusca
            // 
            this.txbBusca.Location = new System.Drawing.Point(21, 22);
            this.txbBusca.Name = "txbBusca";
            this.txbBusca.Size = new System.Drawing.Size(307, 20);
            this.txbBusca.TabIndex = 1;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txbcUsuario,
            this.cbocDocente,
            this.txbcRol,
            this.txbcContrasenia});
            this.dgvUsuario.Location = new System.Drawing.Point(21, 67);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(307, 315);
            this.dgvUsuario.TabIndex = 0;
            this.dgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellContentClick);
            // 
            // txbcUsuario
            // 
            this.txbcUsuario.HeaderText = "Usuario";
            this.txbcUsuario.Name = "txbcUsuario";
            // 
            // cbocDocente
            // 
            this.cbocDocente.HeaderText = "Docente";
            this.cbocDocente.Name = "cbocDocente";
            // 
            // txbcRol
            // 
            this.txbcRol.HeaderText = "Tipo";
            this.txbcRol.Name = "txbcRol";
            // 
            // txbcContrasenia
            // 
            this.txbcContrasenia.HeaderText = "Contraseña";
            this.txbcContrasenia.Name = "txbcContrasenia";
            // 
            // pnlDatos
            // 
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDatos.Controls.Add(this.cboRol);
            this.pnlDatos.Controls.Add(this.cboDocente);
            this.pnlDatos.Controls.Add(this.txbContrasenia);
            this.pnlDatos.Controls.Add(this.lblTipo);
            this.pnlDatos.Controls.Add(this.lblDocente);
            this.pnlDatos.Controls.Add(this.btnBusca);
            this.pnlDatos.Controls.Add(this.txbIdusuario);
            this.pnlDatos.Controls.Add(this.lblContrasenia);
            this.pnlDatos.Controls.Add(this.lblIdUsuario);
            this.pnlDatos.Location = new System.Drawing.Point(32, 31);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(350, 400);
            this.pnlDatos.TabIndex = 2;
            // 
            // cboRol
            // 
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Items.AddRange(new object[] {
            "Adminstrador",
            "Docente",
            "Tutor",
            "Jefe De Carrera"});
            this.cboRol.Location = new System.Drawing.Point(89, 194);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(134, 21);
            this.cboRol.TabIndex = 9;
            // 
            // cboDocente
            // 
            this.cboDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocente.FormattingEnabled = true;
            this.cboDocente.Location = new System.Drawing.Point(88, 148);
            this.cboDocente.Name = "cboDocente";
            this.cboDocente.Size = new System.Drawing.Size(239, 21);
            this.cboDocente.TabIndex = 8;
            // 
            // txbContrasenia
            // 
            this.txbContrasenia.Location = new System.Drawing.Point(88, 105);
            this.txbContrasenia.Name = "txbContrasenia";
            this.txbContrasenia.PasswordChar = '*';
            this.txbContrasenia.Size = new System.Drawing.Size(100, 20);
            this.txbContrasenia.TabIndex = 7;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(11, 194);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo";
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(11, 148);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(48, 13);
            this.lblDocente.TabIndex = 5;
            this.lblDocente.Text = "Docente";
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
            // 
            // txbIdusuario
            // 
            this.txbIdusuario.Location = new System.Drawing.Point(88, 67);
            this.txbIdusuario.Name = "txbIdusuario";
            this.txbIdusuario.Size = new System.Drawing.Size(100, 20);
            this.txbIdusuario.TabIndex = 2;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(11, 105);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(61, 13);
            this.lblContrasenia.TabIndex = 1;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(11, 67);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblIdUsuario.TabIndex = 0;
            this.lblIdUsuario.Text = "Usuario";
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
            this.menuStrip1.TabIndex = 4;
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
            // 
            // tmiCancelar
            // 
            this.tmiCancelar.Enabled = false;
            this.tmiCancelar.Name = "tmiCancelar";
            this.tmiCancelar.Size = new System.Drawing.Size(65, 20);
            this.tmiCancelar.Text = "&Cancelar";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.pnlDatos);
            this.Name = "FrmUsuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.TextBox txbBusca;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txbIdusuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmiGuardar;
        private System.Windows.Forms.ToolStripMenuItem tmiModificar;
        private System.Windows.Forms.ToolStripMenuItem tmiEliminar;
        private System.Windows.Forms.ToolStripMenuItem tmiCancelar;
        private System.Windows.Forms.TextBox txbContrasenia;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.ComboBox cboDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbcUsuario;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbocDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbcRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn txbcContrasenia;
    }
}