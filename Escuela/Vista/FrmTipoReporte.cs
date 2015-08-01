using Escuela.Control;
using Escuela.Modelo;
using Escuela.Vista.Busca;
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
 * Autor Documentación: Mónica Yesenia Viveros Bautista
Fecha: 07/07/2014
 */
namespace Escuela.Vista
{
    public partial class FrmTipoReporte : Form
    {
        Int16 indiceColumna = 0;
        DataTable filtro = new DataTable();
        public FrmTipoReporte()
        {
            InitializeComponent();
        }
        /*En este método recibe de las cajas de texto los datos de un tipo de
       * reporte para qeu porsteriormente sean guardados en la base de datos
       * y despues de ello limpia las cajas para poder guardar otro registro
       */
        private void FrmTipoReporte_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }

        private void tmiGuardar_Click(object sender, EventArgs e)
        {
            MTipoReporte nuevo = new MTipoReporte();

            //nuevo.IdTipo = int.Parse(txbID.Text);
            nuevo.Nombre = txbNombre.Text;
            //FechaInicio = DateTime.Parse(txbFInicio.Text);
            nuevo.FechaInicio = dtpFechaInicio.Value;
            nuevo.FechaFin = dtpFechaFin.Value;
            //nuevo.FechaInicio = DateTime.Parse(txbFFin.Text);
            int resp = nuevo.guardar();

            if (resp != 0)
                MessageBox.Show("Tipo Reporte insertado correctamente");
            else
                MessageBox.Show("Fallo al Insertar");

            this.limpíar();
            this.cargarTabla();
        }
        /*Limpia las cajas para que se puedan realizar
        * nuevos registros
        */
        public void limpíar()
        {
            txbID.Text = "";
            txbNombre.Text = "";
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            //txbFInicio.Text = "";
            //txbFFin.Text = "";
        }
        /*Nos permite cargar la tabla en la que se
         * guardaran los registros
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
        /*Podemos modificar los datos introducidos del
        * registro en caso de haber algún error
        */
        private void tmiModificar_Click(object sender, EventArgs e)
        {
            MTipoReporte modificado = new MTipoReporte();
            modificado.IdTipo = int.Parse(txbID.Text);
            modificado.Nombre = txbNombre.Text;
            modificado.FechaInicio = dtpFechaInicio.Value;
            modificado.FechaFin = dtpFechaFin.Value;
            //modificado.FechaInicio = DateTime.Parse(txbFInicio.Text);
            //modificado.FechaFin = DateTime.Parse(txbFFin.Text);
            int resp = modificado.modificar();
            if (resp != 0)
                MessageBox.Show("El registro se modifico correctamente");
            else
                MessageBox.Show("No se modifico el registro");

            txbID.Enabled = true;
            tmiGuardar.Enabled = true;
            tmiModificar.Enabled = true;
            this.cargarTabla();
        }
        private void dgvTipoReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /*Al presionar en el extremo derecho se muestran los datos del registro
        * elegido para poder modificar, eliminar o en su caso cancelar
        * la operación
        */
        private void dgvTipoReporte_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            txbID.Text = dgvTipoReporte.CurrentRow.Cells[0].Value.ToString();
            txbNombre.Text = dgvTipoReporte.CurrentRow.Cells[1].Value.ToString();
            dtpFechaInicio.Value = DateTime.Parse(dgvTipoReporte.CurrentRow.Cells[2].Value.ToString());
            dtpFechaFin.Value = DateTime.Parse(dgvTipoReporte.CurrentRow.Cells[3].Value.ToString());
            txbID.Enabled = false;
            tmiGuardar.Enabled = false;
            tmiModificar.Enabled = true;
            tmiEliminar.Enabled = true;
            tmiCancelar.Enabled = true;

        }
        private void txbNombre_TextChanged(object sender, EventArgs e)
        {

        }
        /*Cancela alguna petición que se halla hecho y
         * devuelve los registros a su estado original
         */
        private void tmiCancelar_Click(object sender, EventArgs e)
        {
            this.tmiGuardar.Enabled = true;
            this.tmiModificar.Enabled = false;
            this.tmiEliminar.Enabled = false;
            this.tmiCancelar.Enabled = false;
            this.limpíar();
            this.cargarTabla();
        }

        /*Elimina el registro seleccionado, mediante un cuadro de dialogo
         * donde segun la respuesta se eliminara o cancelara 
         * la peticion
         */
        private void tmiEliminar_Click(object sender, EventArgs e)
        {
            MTipoReporte eliminado = new MTipoReporte();
            eliminado.IdTipo = Convert.ToInt32(txbID.Text);
            eliminado.Nombre = txbNombre.Text;
            eliminado.FechaInicio = DateTime.Parse(dtpFechaInicio.Value.ToString());
            eliminado.FechaFin = DateTime.Parse(dtpFechaFin.Value.ToString());

            DialogResult respuesta = MessageBox.Show("Estas seguro de eliminar a " + eliminado.Nombre, "Eliminando....", MessageBoxButtons.YesNo);
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
            this.limpíar();
            this.cargarTabla();

        }

        private void pnlBusqueda_Paint(object sender, PaintEventArgs e)
        {

        }
        /*Nos permite  hacer qeu una columna seleccionada 
         * se le ponga color para resaltarla
         */
        private void dgvTipoReporte_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvTipoReporte.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.White;
            indiceColumna = Convert.ToInt16(e.ColumnIndex);
            dgvTipoReporte.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.SteelBlue;
        }

        /*Podemos buscar y filtrar algunos registros poniendo algunas letras
         * que contengan los datos
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
        /*Nos dirige a un panel para ahí poder buscar algún dato que
         * deseamos y no conoscamos por ejemplo un id ´para despues regresarnos
         * formulario inicial donde nos muestra ya todos los datos del
         * registro
         */
        private void btnBusca_Click(object sender, EventArgs e)
        {
            BuscaTipoReporte cuadro = new BuscaTipoReporte();
            cuadro.ShowDialog(this);
            MTipoReporte leido = cuadro.Elegido;
            if (leido != null)
            {
                txbID.Text = leido.IdTipo.ToString();
                txbNombre.Text = leido.Nombre;
                dtpFechaInicio.Value = leido.FechaInicio;
                dtpFechaFin.Value = leido.FechaFin;
            }
        }

       
    }
}
