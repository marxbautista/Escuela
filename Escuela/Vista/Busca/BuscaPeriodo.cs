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
/*
 * AUTOR:ENRIQUE HERNANDEZ IBARRA
 * SAIRA KAREN LUGO GARDUÑO
 * GABRIELA DURAN TREJO
 * FECHA:7/07/2014
 * AUTOR DE DOCUMENTACION:
  */

namespace Escuela.Vista
{
    /*EN ESTE METODO SE INICIALIZA LA VARIABLE PARA EL METODO BUSCAR PERIODO 
     * Y OTRA LLAMADA ELEGIDO QUE SE ENCUENTRA EN LA CLASE MPERIODO
    */


    public partial class BuscaPeriodo : Form
    {
        Int16 indiceColumna = 0;
        DataTable filtro = new DataTable();
        private MPeriodo elegido;

        public MPeriodo Elegido
        {
            get { return elegido; }
           // set { elegido = value; }
        }
        public BuscaPeriodo()
        {
            InitializeComponent();
        }

        /*EN ESTE METODO REALIZAMOS LA OPERACION EN LA CUAL PODEMOS ELEGIR EL ENCABEZADO DE LA TABLA QUE DESEAS CONSULTAR 
              * MARCANDOTELO CON UN COLOR AZUL SEÑALANDO QUE ESA ES LA COLUMNA
             */
        private void dgvPeriodo2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvPeriodo2.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.White;
            indiceColumna = Convert.ToInt16(e.ColumnIndex);
            dgvPeriodo2.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.SteelBlue;
        }

        /*EN ESTE METODO REALIZAMOS LA OPERACION EN LA CUAL SE REALIZA LA BUSQUEDA DE 
             * ALGUN DATO EN ESPECIFICO LA CUAL ES FILTRADA DEL dgvPeriodo2 QUE ES LA VISTA, NO DE LA BASE DE DATOS,
             */

        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {

            String filtroPor = dgvPeriodo2.Columns[indiceColumna].Name;
            if (txbBusqueda.Text != string.Empty)
            {
                DataView view = CFiltroDatos.filtroDatos(filtro, filtroPor, txbBusqueda.Text);
                dgvPeriodo2.DataSource = view;
            }
            else
            {
                this.cargarTabla();
            }
            dgvPeriodo2.AutoResizeColumns();
        }
        /* EN ESTE METODO HACE QUE LAS TABLAS OBTENGAN UN TAMAÑO AUTOMATICO
         * DEPENDIENDO EL TAMAÑO QUE TENGAN LOS DATOS
        */
        private void cargarTabla()
        {
            MPeriodo datos = new MPeriodo();
            dgvPeriodo2.DataSource = datos.listarTodos();
            dgvPeriodo2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPeriodo2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPeriodo2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPeriodo2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            filtro = CFiltroDatos.llenaTabla(this.dgvPeriodo2);

        }
        /*EN ESTE METODO REALIZAMOS LA OPERACION DE OCULTAR EL FORM PERIODO YA QUE SE ABRE 
         * EL FORM BUSCAR PERIODO E INAVILITA FORM PERIODO
            */
        private void dgvPeriodo2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MPeriodo nuevo = new MPeriodo();
            nuevo.IdPeriodo =Convert.ToInt16 (dgvPeriodo2.CurrentRow.Cells[0].Value.ToString());
            nuevo.MesInicio = dgvPeriodo2.CurrentRow.Cells[1].Value.ToString();
            nuevo.MesFin = dgvPeriodo2.CurrentRow.Cells[2].Value.ToString();
            nuevo.Anio = dgvPeriodo2.CurrentRow.Cells[3].Value.ToString();
            this.elegido = nuevo;
            this.Hide();
        }
        /* CON ESTE METODO NOS AYUDA QUE NUESTRO dgvPeriodo2 CARGUE LOS DATOS Y LOS MUESTRE EN ESTE
       */
        private void BuscaPeriodo_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }
    }
}
