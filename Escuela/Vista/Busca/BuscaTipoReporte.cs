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
/*Autor: Hilda Mireya Calva Chavarria
Mónica Yesenia Viveros Bautista
Juan Manuel Dorantes Peréz
 * Autor Documentación: Hilda Mireya Calva Chavarria
Fecha: 07/07/2014
 */
namespace Escuela.Vista.Busca
{

    public partial class BuscaTipoReporte : Form
    {
        Int16 indiceColumna = 0;
        DataTable filtro = new DataTable();
        private MTipoReporte elegido;
        /*Este es un encapsulamiento que nos devolvera el valor de la variable 
       */
        internal MTipoReporte Elegido
        {
            get { return elegido; }
            //set { elegido = value; }
        }
        /*Es un constructor 
         */
        public BuscaTipoReporte()
        {
            InitializeComponent();
        }
        /*Este es el método del evento para cuando queramos hacer un filtro este nos lo marque de diferente color a los demás 
         */
        private void pnlBusqueda_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dgvTipoReporte_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvTipoReporte.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.White;
            indiceColumna = Convert.ToInt16(e.ColumnIndex);
            dgvTipoReporte.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.SteelBlue;
        }
        /*Este método nos ayuda a que cuando hagamos cambios usando la busqueda lo muestre y ademas nos permita modificar dichos datos existentes en la tabla de la base de datos 
         */
        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {
            String filtroPor = dgvTipoReporte.Columns[indiceColumna].Name;
            if (txbBusqueda.Text != string.Empty)
            {
                DataView view = CFiltroDatos.filtroDatos(filtro, filtroPor, txbBusqueda.Text);
                dgvTipoReporte.DataSource = view;

            }
            else
            {
                this.cargarTabla();
            }
            dgvTipoReporte.AutoResizeColumns();
        }

        /*El método de cargar tabla hace que nos muestre en la tabla los datos existes además de que llena la tabla con los filtros al querer hacer una busqueda con las consultas de la base de datos
         */
        public void cargarTabla()
        {
            MTipoReporte nuevo = new MTipoReporte();
            dgvTipoReporte.DataSource = nuevo.listarTodo2();
            dgvTipoReporte.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTipoReporte.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTipoReporte.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTipoReporte.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            filtro = CFiltroDatos.llenaTabla(this.dgvTipoReporte);
        }
        /*Este método nos ayuda a sacar los datos que hay en las cajas de texto para poder pasarlos a la tabla de las consultas donde nos aparecerá todos los datos existentes 
         */
        private void dgvTipoReporte_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MTipoReporte nuevo = new MTipoReporte();
            nuevo.IdTipo = Convert.ToInt16(dgvTipoReporte.CurrentRow.Cells[0].Value.ToString());
            nuevo.Nombre = dgvTipoReporte.CurrentRow.Cells[1].Value.ToString();
            nuevo.FechaInicio = DateTime.Parse(dgvTipoReporte.CurrentRow.Cells[2].Value.ToString());
            nuevo.FechaFin = DateTime.Parse(dgvTipoReporte.CurrentRow.Cells[3].Value.ToString());

            this.elegido = nuevo;
            this.Hide();
        }

        /*Este carga la tabla donde se encuentran los datos de nuestra tabla tipo reporte y así poder hacer una busqueda sobre datos existentes
         */
        private void BuscaTipoReporte_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }

    }
}
