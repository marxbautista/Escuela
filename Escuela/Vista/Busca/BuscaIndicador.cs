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
AUTOR: ANTONIO QUINTANAR VIVEROS
 * FECHA : 07/07/2014
 * Autor de comentario: Antonio Quintanar Viveros
 */
namespace Escuela.Vista
{

    public partial class BuscaIndicador : Form
    {
        /* En este mandamos a declarar las columnas que nos deven de mostrar en la filtracion la cual inicializa
         * una nueva instancia en la clase
         */
        Int16 indiceColumna = 0;
        DataTable filtro = new DataTable();

        /*
         * Indicamos el elegido ya que aqui lo mandamos a declara para que este nos lo muestre en el siguiente codigo
         * y se le asignan su get para que este lo pudos llamar cuando lo necesitemos ya que es una nueva clase
         */
        private MIdindicador elegido;
        
        public MIdindicador Elegido
        {
            get { return elegido; }
           // set { elegido = value; }
        } 
        public BuscaIndicador()
        {
            InitializeComponent();
        }
        /*
         * En este metodo nos muestra en color las columnas seleccionada para indicar la busqueda en la cual queremos 
         * que nos muetre los resultados de la busqueda
         */
        private void dgvIndicador_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvIndicador.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.White;
            indiceColumna = Convert.ToInt16(e.ColumnIndex);
            dgvIndicador.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.SteelBlue;
        }
        /*
         * En este metodo nos muestra la filtracion en los datos desde ponerle un nombre en el txb y este 
         * nos lo mostrara en el gvd lo que deseamos buscar
         */
        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {
             String filtroPor = dgvIndicador.Columns[indiceColumna].Name;
            if (txbBusqueda.Text != string.Empty)
            {
                DataView view = CFiltroDatos.filtroDatos(filtro, filtroPor, txbBusqueda.Text);
                dgvIndicador.DataSource = view;
                }
            else
            {
                this.cargaTabla();
            }
            dgvIndicador.AutoResizeColumns();
        }
        /*
         * En este metodo nos muestra los dato en forma de tabla en la cual se cargan los datos modificados 
         * o eliminados y guardados y en la cual se muestra los datos en la cual se puedan ajustar ala columna
         */
        public void cargaTabla()
        {
            MIdindicador datos = new MIdindicador();
            dgvIndicador.DataSource = datos.listaTodos();
            dgvIndicador.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvIndicador.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            filtro = CFiltroDatos.llenaTabla(this.dgvIndicador);
        }
        /*
         * En este metodo lo que hace es mostrar los resultados en los txb y muestra el dato elegido en el
         * cuadro de los txb y el hide nos oculta el formulario
         */
        private void dgvIndicador_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MIdindicador nuevo = new MIdindicador();
            nuevo.Idindicador = Convert.ToInt16(dgvIndicador.CurrentRow.Cells[0].Value.ToString());
            nuevo.Nombre = dgvIndicador.CurrentRow.Cells[1].Value.ToString();
            this.elegido = nuevo;
            this.Hide();
        }
        /*
         * Este metodo lo creamos para que carge la tabla nuevamente en el otro dgvBuscarIndicador
         * es una copia del anterior ya que en este nos lo muestra de nuevo
         */
        private void BuscaIndicador_Load(object sender, EventArgs e)
        {
            this.cargaTabla();
        }
    }
}
