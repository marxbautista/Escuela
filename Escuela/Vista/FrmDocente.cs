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
Autor: Bibiano Mota Perez, deyanira jimenez hernandez, Gonzalo Aguilar Perez
 
   Fecha: 03/07/2014
*/
namespace Escuela.Vista
{
    public partial class FrmDocente : Form  /*clase principal frmDocente*/
    {
        /* Filtra los datos de la columna a la tabla */
        Int16 indiceColumna = 0;
        DataTable filtro = new DataTable();
        public FrmDocente()
        {
            InitializeComponent();
        }

        /* Guarda los objetos del docente el cual se puede insertar uno o ya tener uno existente*/
        private void tmiGuardar_Click(object sender, EventArgs e)
        {
            MDocente nuevo = new MDocente();
            if (txbNombreDocente.Text != "")
            {
                nuevo.IdDocente = Convert.ToDecimal(txbClaveDocente.Text);
                nuevo.Nombre = txbNombreDocente.Text.ToUpper();
                int resp = nuevo.guardar();
                if (resp != 0)
                    MessageBox.Show("Docente Insertado");
                else
                    MessageBox.Show("Docente ya Existente ");
            }
            this.limpiar();
            this.cargarTabla();
        }

        /* limpia los  campos de los  textbox al ingresar datos */
        public void limpiar()
        {
            txbClaveDocente.Text = "";
            txbNombreDocente.Text = "";
        }
        /* Manda a cargar los valores de la tabla*/
        private void FrmDocente_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }

        /* Carga la tabla con los datos enlistados*/

        public void cargarTabla()
        {
            MDocente datos = new MDocente();
            dgvDocente.DataSource = datos.listarTodos();
            dgvDocente.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDocente.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            filtro = CFiltroDatos.llenaTabla(this.dgvDocente);


        }



        private void lblNombre_Click(object sender, EventArgs e)
        {

        }


        /*Se produce cuando el usuario hace clic dentro de los limites de un encabezado de la fila la cual se manda a llamar*/
        private void dgvDocente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txbClaveDocente.Text = dgvDocente.CurrentRow.Cells[0].Value.ToString();
            txbNombreDocente.Text = dgvDocente.CurrentRow.Cells[1].Value.ToString();


            txbClaveDocente.Enabled = false;
            tmiGuardar.Enabled = false;
            tmiModificar.Enabled = true;
            tmiEliminar.Enabled = true;
            tmiCancelar.Enabled = true;
        }

        /*Este método modifica los valores del docente si los valores están ingresados correcta mente manda un mensaje  de  "Modificado Adecuadamente"  o si no lo están manda el mensaje de "Error de Modificacion "*/
        private void tmiModificar_Click(object sender, EventArgs e)
        {
            MDocente modificado = new MDocente();
            modificado.IdDocente = Convert.ToInt16(txbClaveDocente.Text);
            modificado.Nombre = txbNombreDocente.Text;
            int resp = modificado.modificar();

            if (resp != 0)
                MessageBox.Show("Modificado Adecuadamente ");
            else
                MessageBox.Show("Error de Modificacion ");
            txbClaveDocente.Enabled = true;
            tmiGuardar.Enabled = true;
            tmiModificar.Enabled = true;
            this.cargarTabla();
        }


        /*Este método elimina los valores del docente si ingresa el nombre aparece q si "Esta seguro de Eliminar a" cualquier docente si la respuesta es yes el mensaje será "Elemento eliminado Correctamente "  si la respuesta es no el mensaje será "Elemento No Eliminado"
         * 
         */

                private void tmiEliminar_Click(object sender, EventArgs e)
                {
                    MDocente eliminado = new MDocente();
                    eliminado.Nombre = txbNombreDocente.Text;
                    eliminado.IdDocente = Convert.ToDecimal(txbClaveDocente.Text);
                    DialogResult respuesta = MessageBox.Show("Esta seguro de Eliminar a " + eliminado.Nombre,
                        "Eliminando...", MessageBoxButtons.YesNo);
            
                    if (respuesta == DialogResult.Yes){
                        int r=eliminado.eliminar();
                        if (r != 0)
                        {
                            MessageBox.Show("Elemento eliminado Correctamente");
                            eliminado.eliminar();
                        }
                        else MessageBox.Show("Elemento No Eliminado");

                    }
                    this.tmiGuardar.Enabled = true;
                    this.tmiModificar.Enabled = false;
                    this.tmiCancelar.Enabled = false;
                    this.tmiEliminar.Enabled = false;
                    this.limpiar();
                    this.cargarTabla();
           
                }


        /*Este método cancela  los valores y se manda a llamar los métodos*/

        private void tmiCancelar_Click(object sender, EventArgs e)
        {
            this.tmiGuardar.Enabled = true;
            this.tmiModificar.Enabled = false;
            this.tmiCancelar.Enabled = false;
            this.tmiEliminar.Enabled = false;
            this.limpiar();
            this.cargarTabla();
        }





        /* se  muestra el color de la columna especificada al cuadro*/
        private void dgvDocente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvDocente.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.White;
            indiceColumna = Convert.ToInt16(e.ColumnIndex);
            dgvDocente.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.SteelBlue;



        }

        /*se crea la busqueda de objetos la cual carga la tabla para buscar al nombre adquirido en el textbox */
        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {
            String filtroPor = dgvDocente.Columns[indiceColumna].Name;
            if (txbBusqueda.Text != String.Empty)
            {
                DataView view = CFiltroDatos.filtroDatos(filtro, filtroPor,
                    txbBusqueda.Text);
                dgvDocente.DataSource = view;

            }
            else
            {
                this.cargarTabla();
            }
            dgvDocente.AutoResizeColumns();
        }

        /*se crea un botón de  busqueda de objetos  al dar clic manda a buscar en el cuadro  cual se lee  */

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            BuscaDocente cuadro = new BuscaDocente();
            cuadro.ShowDialog(this);
            MDocente leido = cuadro.Elegido;
            if (leido != null)
            {
                txbClaveDocente.Text = leido.IdDocente.ToString();
                txbNombreDocente.Text = leido.Nombre;
            }

        }


    }

}


