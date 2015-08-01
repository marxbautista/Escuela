namespace Escuela.Vista
{
    partial class BuscaDocente
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
            this.dgvDocente = new System.Windows.Forms.DataGridView();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBusqueda.Controls.Add(this.txbBusqueda);
            this.pnlBusqueda.Controls.Add(this.dgvDocente);
            this.pnlBusqueda.Location = new System.Drawing.Point(17, 30);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(350, 400);
            this.pnlBusqueda.TabIndex = 2;
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
            // BuscaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.pnlBusqueda);
            this.Name = "BuscaDocente";
            this.Text = "Busca Docente";
            this.Load += new System.EventHandler(this.BuscaDocente_Load);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.DataGridView dgvDocente;
    }
}