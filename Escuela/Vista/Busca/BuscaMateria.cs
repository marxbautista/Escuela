using Escuela.Control;
using Escuela.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela.Vista
{
    public partial class BuscaMAteria : Form
    {
        Int16 indiceColumna = 0;
        DataTable filtro = new DataTable();
        private MMateria elegida;

        public MMateria Elegida
        {
            get { return elegida; }
            //set { elegida = value; }
        }
        public BuscaMAteria()
        {
            InitializeComponent();
        }

        private void dgvVista_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvVista.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.SpringGreen;
            indiceColumna = Convert.ToInt16(e.ColumnIndex);
            dgvVista.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.SteelBlue;
        }

        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {
            String filtroPor = dgvVista.Columns[indiceColumna].Name;
            if (txbBusqueda.Text != string.Empty)
            {
                DataView view = CFiltroDatos.filtroDatos(filtro, filtroPor, txbBusqueda.Text);
                dgvVista.DataSource = view;
            }
            else
            {
                this.cargarTabla();
            }
            dgvVista.AutoResizeColumns();
        }
        public void cargarTabla()
        {
            MMateria datos = new MMateria();
            dgvVista.DataSource = datos.listarTodos();
            dgvVista.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvVista.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            filtro = CFiltroDatos.llenaTabla(this.dgvVista);
        }

        private void dgvVista_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MMateria nuevo = new MMateria();
            nuevo.Clave = dgvVista.CurrentRow.Cells[0].Value.ToString();
            nuevo.NombreMateria = dgvVista.CurrentRow.Cells[1].Value.ToString();
            this.elegida = nuevo;
            this.Hide();
        }

        private void BuscaMAteria_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }
    }
}
