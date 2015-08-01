namespace Escuela.Vista
{
    partial class FrmHorario
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
            this.pnlDato = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFin2 = new System.Windows.Forms.ComboBox();
            this.cboFin1 = new System.Windows.Forms.ComboBox();
            this.cboDia = new System.Windows.Forms.ComboBox();
            this.lblDosP = new System.Windows.Forms.Label();
            this.cboInicio2 = new System.Windows.Forms.ComboBox();
            this.cboInicio1 = new System.Windows.Forms.ComboBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txbAula = new System.Windows.Forms.TextBox();
            this.txbHorario = new System.Windows.Forms.TextBox();
            this.lblAula = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblIdHorario = new System.Windows.Forms.Label();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.dgvHora = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tmiGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDato.SuspendLayout();
            this.pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHora)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDato
            // 
            this.pnlDato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDato.Controls.Add(this.label2);
            this.pnlDato.Controls.Add(this.cboFin2);
            this.pnlDato.Controls.Add(this.cboFin1);
            this.pnlDato.Controls.Add(this.cboDia);
            this.pnlDato.Controls.Add(this.lblDosP);
            this.pnlDato.Controls.Add(this.cboInicio2);
            this.pnlDato.Controls.Add(this.cboInicio1);
            this.pnlDato.Controls.Add(this.btnBusca);
            this.pnlDato.Controls.Add(this.txbAula);
            this.pnlDato.Controls.Add(this.txbHorario);
            this.pnlDato.Controls.Add(this.lblAula);
            this.pnlDato.Controls.Add(this.lblFin);
            this.pnlDato.Controls.Add(this.lblName);
            this.pnlDato.Controls.Add(this.lblDia);
            this.pnlDato.Controls.Add(this.lblIdHorario);
            this.pnlDato.Location = new System.Drawing.Point(30, 30);
            this.pnlDato.Name = "pnlDato";
            this.pnlDato.Size = new System.Drawing.Size(350, 400);
            this.pnlDato.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = ":";
            // 
            // cboFin2
            // 
            this.cboFin2.FormattingEnabled = true;
            this.cboFin2.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.cboFin2.Location = new System.Drawing.Point(222, 185);
            this.cboFin2.Name = "cboFin2";
            this.cboFin2.Size = new System.Drawing.Size(63, 21);
            this.cboFin2.TabIndex = 16;
            this.cboFin2.SelectedIndexChanged += new System.EventHandler(this.cboFin2_SelectedIndexChanged);
            // 
            // cboFin1
            // 
            this.cboFin1.FormattingEnabled = true;
            this.cboFin1.Items.AddRange(new object[] {
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "01",
            "02",
            "03",
            "04",
            "05"});
            this.cboFin1.Location = new System.Drawing.Point(123, 185);
            this.cboFin1.Name = "cboFin1";
            this.cboFin1.Size = new System.Drawing.Size(56, 21);
            this.cboFin1.TabIndex = 15;
            // 
            // cboDia
            // 
            this.cboDia.FormattingEnabled = true;
            this.cboDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.cboDia.Location = new System.Drawing.Point(123, 82);
            this.cboDia.Name = "cboDia";
            this.cboDia.Size = new System.Drawing.Size(121, 21);
            this.cboDia.TabIndex = 14;
            // 
            // lblDosP
            // 
            this.lblDosP.AutoSize = true;
            this.lblDosP.Location = new System.Drawing.Point(186, 137);
            this.lblDosP.Name = "lblDosP";
            this.lblDosP.Size = new System.Drawing.Size(10, 13);
            this.lblDosP.TabIndex = 13;
            this.lblDosP.Text = ":";
            // 
            // cboInicio2
            // 
            this.cboInicio2.FormattingEnabled = true;
            this.cboInicio2.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.cboInicio2.Location = new System.Drawing.Point(222, 137);
            this.cboInicio2.Name = "cboInicio2";
            this.cboInicio2.Size = new System.Drawing.Size(63, 21);
            this.cboInicio2.TabIndex = 12;
            this.cboInicio2.SelectedIndexChanged += new System.EventHandler(this.cboInicio2_SelectedIndexChanged);
            // 
            // cboInicio1
            // 
            this.cboInicio1.FormattingEnabled = true;
            this.cboInicio1.Items.AddRange(new object[] {
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "01",
            "02",
            "03",
            "04",
            "05"});
            this.cboInicio1.Location = new System.Drawing.Point(123, 137);
            this.cboInicio1.Name = "cboInicio1";
            this.cboInicio1.Size = new System.Drawing.Size(56, 21);
            this.cboInicio1.TabIndex = 11;
            this.cboInicio1.SelectedIndexChanged += new System.EventHandler(this.cboInicio1_SelectedIndexChanged);
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(123, 287);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 23);
            this.btnBusca.TabIndex = 10;
            this.btnBusca.Text = "...";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // txbAula
            // 
            this.txbAula.Location = new System.Drawing.Point(123, 231);
            this.txbAula.Name = "txbAula";
            this.txbAula.Size = new System.Drawing.Size(100, 20);
            this.txbAula.TabIndex = 9;
            // 
            // txbHorario
            // 
            this.txbHorario.Enabled = false;
            this.txbHorario.Location = new System.Drawing.Point(123, 28);
            this.txbHorario.Name = "txbHorario";
            this.txbHorario.Size = new System.Drawing.Size(100, 20);
            this.txbHorario.TabIndex = 5;
            this.txbHorario.TextChanged += new System.EventHandler(this.txbHorario_TextChanged);
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.Location = new System.Drawing.Point(27, 239);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(28, 13);
            this.lblAula.TabIndex = 4;
            this.lblAula.Text = "Aula";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(27, 185);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(21, 13);
            this.lblFin.TabIndex = 3;
            this.lblFin.Text = "Fin";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 137);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Inicio";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(27, 82);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(25, 13);
            this.lblDia.TabIndex = 1;
            this.lblDia.Text = "Día";
            // 
            // lblIdHorario
            // 
            this.lblIdHorario.AutoSize = true;
            this.lblIdHorario.Location = new System.Drawing.Point(24, 28);
            this.lblIdHorario.Name = "lblIdHorario";
            this.lblIdHorario.Size = new System.Drawing.Size(50, 13);
            this.lblIdHorario.TabIndex = 0;
            this.lblIdHorario.Text = "IdHorario";
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Controls.Add(this.txbBusqueda);
            this.pnlBuscar.Controls.Add(this.dgvHora);
            this.pnlBuscar.Location = new System.Drawing.Point(422, 30);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(350, 400);
            this.pnlBuscar.TabIndex = 1;
            this.pnlBuscar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBuscar_Paint);
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Location = new System.Drawing.Point(52, 30);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txbBusqueda.TabIndex = 1;
            this.txbBusqueda.TextChanged += new System.EventHandler(this.txbBusqueda_TextChanged);
            // 
            // dgvHora
            // 
            this.dgvHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHora.Location = new System.Drawing.Point(72, 76);
            this.dgvHora.Name = "dgvHora";
            this.dgvHora.Size = new System.Drawing.Size(240, 150);
            this.dgvHora.TabIndex = 0;
            this.dgvHora.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHora_ColumnHeaderMouseClick);
            this.dgvHora.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHora_RowHeaderMouseClick);
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
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tmiGuardar
            // 
            this.tmiGuardar.Name = "tmiGuardar";
            this.tmiGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.tmiGuardar.Size = new System.Drawing.Size(61, 20);
            this.tmiGuardar.Text = "Guardar";
            this.tmiGuardar.Click += new System.EventHandler(this.tmiGuardar_Click);
            // 
            // tmiModificar
            // 
            this.tmiModificar.Name = "tmiModificar";
            this.tmiModificar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.tmiModificar.Size = new System.Drawing.Size(70, 20);
            this.tmiModificar.Text = "Modificar";
            this.tmiModificar.Click += new System.EventHandler(this.tmiModificar_Click);
            // 
            // tmiEliminar
            // 
            this.tmiEliminar.Enabled = false;
            this.tmiEliminar.Name = "tmiEliminar";
            this.tmiEliminar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tmiEliminar.Size = new System.Drawing.Size(65, 20);
            this.tmiEliminar.Text = "&Eliminar ";
            this.tmiEliminar.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
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
            // FrmHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.pnlDato);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHorario";
            this.Text = "Horario";
            this.Load += new System.EventHandler(this.FrmHorario_Load);
            this.pnlDato.ResumeLayout(false);
            this.pnlDato.PerformLayout();
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHora)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDato;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Label lblIdHorario;
        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.TextBox txbAula;
        private System.Windows.Forms.TextBox txbHorario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmiGuardar;
        private System.Windows.Forms.ToolStripMenuItem tmiModificar;
        private System.Windows.Forms.DataGridView dgvHora;
        private System.Windows.Forms.ToolStripMenuItem tmiEliminar;
        private System.Windows.Forms.ToolStripMenuItem tmiCancelar;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Label lblDosP;
        private System.Windows.Forms.ComboBox cboInicio2;
        private System.Windows.Forms.ComboBox cboInicio1;
        private System.Windows.Forms.ComboBox cboDia;
        private System.Windows.Forms.ComboBox cboFin1;
        private System.Windows.Forms.ComboBox cboFin2;
        private System.Windows.Forms.Label label2;
    }
}