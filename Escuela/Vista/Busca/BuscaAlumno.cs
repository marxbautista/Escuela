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
    public partial class BuscaAlumno : Form
    {
        Int16 indiceColumna = 0;
        DataTable filtro = new DataTable();
        private MAlumno escogido;

        public MAlumno Escogido
        {
            get { return escogido; }
            //set { escogido = value; }
        }
        public BuscaAlumno()
        {
            InitializeComponent();
        }

        private void BuscaAlumno_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }
        public void cargarTabla()
        {
            MAlumno datos = new MAlumno();
            dgvAlumno.DataSource = datos.listarTodos();
            dgvAlumno.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAlumno.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            filtro = CFiltroDatos.llenaTabla(this.dgvAlumno);
        }

        private void dgvAlumno_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvAlumno.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.White;
            indiceColumna = Convert.ToInt16(e.ColumnIndex);
            dgvAlumno.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.SteelBlue;
        }

        private void txbBusca_TextChanged(object sender, EventArgs e)
        {
            String filtroPor = dgvAlumno.Columns[indiceColumna].Name;
            if (txbBusca.Text != string.Empty)
            {
                DataView view = CFiltroDatos.filtroDatos(filtro, filtroPor, txbBusca.Text);
                dgvAlumno.DataSource = view;
            }
            else
            {
                this.cargarTabla();
            }
            dgvAlumno.AutoResizeColumns();
        }

        private void dgvAlumno_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MAlumno nuevo = new MAlumno();
            nuevo.Matricula = dgvAlumno.CurrentRow.Cells[0].Value.ToString();
            nuevo.Nombre = dgvAlumno.CurrentRow.Cells[1].Value.ToString();
            this.escogido = nuevo;
            this.Hide();

        }
    }
}
