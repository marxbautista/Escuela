namespace Escuela.Vista
{
    partial class BuscaPeriodo
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
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.dgvPeriodo2 = new System.Windows.Forms.DataGridView();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.Color.Aqua;
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBusqueda.Controls.Add(this.txbBusqueda);
            this.pnlBusqueda.Controls.Add(this.dgvPeriodo2);
            this.pnlBusqueda.Location = new System.Drawing.Point(17, 30);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(350, 400);
            this.pnlBusqueda.TabIndex = 2;
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Location = new System.Drawing.Point(74, 52);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(217, 20);
            this.txbBusqueda.TabIndex = 1;
            this.txbBusqueda.TextChanged += new System.EventHandler(this.txbBusqueda_TextChanged);
            // 
            // dgvPeriodo2
            // 
            this.dgvPeriodo2.BackgroundColor = System.Drawing.Color.Magenta;
            this.dgvPeriodo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodo2.Location = new System.Drawing.Point(56, 140);
            this.dgvPeriodo2.Name = "dgvPeriodo2";
            this.dgvPeriodo2.Size = new System.Drawing.Size(259, 192);
            this.dgvPeriodo2.TabIndex = 0;
            this.dgvPeriodo2.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPeriodo2_ColumnHeaderMouseClick);
            this.dgvPeriodo2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPeriodo2_RowHeaderMouseClick);
            // 
            // BuscaPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.pnlBusqueda);
            this.Name = "BuscaPeriodo";
            this.Text = "BuscaPeriodo";
            this.Load += new System.EventHandler(this.BuscaPeriodo_Load);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.DataGridView dgvPeriodo2;

    }
}