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
 * FECHA: 03/07/2014  MODIFICACION: 07/07/2014
 * Autor de comentario: Antonio Quintanar Viveros
 */
namespace Escuela.Vista
{
    /* 
     */
    public partial class FrmIndicador : Form
    {
        /* En este mandamos a declarar las columnas que nos deven de mostrar en la filtracion la cual inicializa
        * una nueva instancia en la clase
        */
        Int16 indiceColumna = 0;
        DataTable filtro = new DataTable();
        public FrmIndicador()
        {
            InitializeComponent();
        }
          /* En este metodo nos muestra en color las columnas seleccionada para indicar la busqueda en la cual queremos 
         * que nos muetre los resultados de la busqueda
         */
        private void dgvIndicador_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txbIdindicador.Text = dgvIndicador.CurrentRow.Cells[0].Value.ToString();
            txbNombre.Text = dgvIndicador.CurrentRow.Cells[1].Value.ToString();
            txbIdindicador.Enabled = false;
            tmiGuardar.Enabled = false;
            tmiModificar.Enabled = true;
            tmiEliminar.Enabled = true;
            tmiCancelar.Enabled = true;
        }
          
           /*
            * En este metodo se crean los metodos en la cual el boton de guardar tiene que aser sus funciones que en este cas es
            * el de guardar y al mismo tiempo devera de arrogar un cierto dialogo sobre si se iso bien la funcion o no
            */
        private void tmiGuardar_Click(object sender, EventArgs e)
        {
            MIdindicador nuevo = new MIdindicador();
            if (txbIdindicador.Text != "")
            {
                nuevo.Idindicador =Convert.ToUInt16 (txbIdindicador.Text);
                nuevo.Nombre = txbNombre.Text.ToUpper();
                int resp = nuevo.guardar();
                if (resp != 0)
                    MessageBox.Show("Indicador Insertado adecuadamente");
                else
                    MessageBox.Show("El indicador no se guardo adecuadamente");

            }
            this.limpiar();
            this.cargaTabla();

        }
        /* En esta funcion de limpiar se hace que al consultar la dgv se tendran que vaciar todos los txb y estos quedaran en blanco y a la vez 
         * se guardaran los datos a la vez y se pondran en blanco los txb
         */
        public void limpiar()
        {
            txbIdindicador.Text = "";
            txbNombre.Text = "";
        }
        /* Carga los datos en la tabla de la Frm de la cual se insertaron o ya estan insertados
         */
        private void FrmIndicador_Load(object sender, EventArgs e)
        {
            this.cargaTabla();
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
         * Modific los datos de la tabla los cuales ya estan insertados y estos a la vez arroga un cierto de mensajes los cuales
         * se refencian a los que se esta haciendo y se bloquean ciertos botones
         */
        private void tmiModificar_Click(object sender, EventArgs e)
        {
            MIdindicador modificado = new MIdindicador();
            modificado.Idindicador = Convert.ToUInt16(txbIdindicador.Text);
            modificado.Nombre = txbNombre.Text;
            int resp = modificado.modificar();
            if (resp != 0)
                MessageBox.Show("Elemento modificado adecuadamente");
            else
                MessageBox.Show("Fallo la modificacion");
            txbIdindicador.Enabled = true;
            this.tmiGuardar.Enabled = true;
            this.tmiModificar.Enabled = false;
            this.tmiEliminar.Enabled = false;
            this.tmiCancelar.Enabled = false;
            this.limpiar();
            this.cargaTabla();

        }
        /*
         * En este metodo se eliminan los datos seleccionados en la tabla y a su vez arrogan un cierto mensaje de si se realizo la funcion 
         * o no en esta tambien se desabilitan las funciones de las demas botones
         */
        private void tmiEliminar_Click(object sender, EventArgs e)
        {
            MIdindicador eliminado = new MIdindicador();
            eliminado.Idindicador = Convert.ToDecimal(txbIdindicador.Text);
            eliminado.Nombre = txbNombre.Text;
            DialogResult respuesta = MessageBox.Show("Esta seguro de eliminar a " + eliminado.Nombre, "Eliminado.......", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                int r = eliminado.eliminar();
                if (r != 0)
                {
                    MessageBox.Show("Elemento eliminado correctamente");
                }
                else
                    MessageBox.Show("Elemento no eliminado");
            }
            this.tmiGuardar.Enabled = true;
            this.tmiModificar.Enabled = false;
            this.tmiEliminar.Enabled = false;
            this.tmiCancelar.Enabled = false;
            this.limpiar();
            this.cargaTabla();

        }
        /* Cancelan las acciones sobre lo que se quieren hacer en los siguentes botones los cuales eston pueden ser de los que se pueden
         * cancelar todas las acciones de lo que se quiere realizar
         */
        private void tmiCancelar_Click(object sender, EventArgs e)
        {
            this.tmiGuardar.Enabled = true;
            this.tmiModificar.Enabled = false;
            this.tmiEliminar.Enabled = false;
            this.tmiCancelar.Enabled = false;
            this.limpiar();
            this.cargaTabla();
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
        /* En este metodo se muestran los datos de la tabla en la cual se estan filtrando en los txb de la busqueda y esta a su vez se vuelve
         * a cargar la tabla mostrando los nuevos resultados en la dgv
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
        /* En este metodo se hace la instancia en los que en el btn al darle click en el se mostrara el nuevo resusltado de los datos 
         * mostrando el resultado seleccionado o igresado en la txb 
         */
        private void btnBusca_Click(object sender, EventArgs e)
        {
            BuscaIndicador cuadro = new BuscaIndicador();
            cuadro.ShowDialog(this);
            MIdindicador leido = cuadro.Elegido;
            if (leido != null)
            {
                txbIdindicador.Text = leido.Idindicador.ToString();
                txbNombre.Text = leido.Nombre;
            }
        }
    }
}
