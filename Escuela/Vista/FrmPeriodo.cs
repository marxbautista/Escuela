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
 * AUTOR: SAIRA KAREN LUGO GARDUÑO
 * GABRIELA DURAN TREJO
 * ENRIQUE HERNADEZ IBARRA
 * FECHA:7 JULIO 2014
 * AUTOR DE DOCUMENTACION : ENRIQUE HERNANDEZ IBARRA
 */

 namespace Escuela.Vista
{
     /* EN ESTE METODO INICIALIZAMOS UNA VARIABLE LA CUAL 
      * OCUPAREMOS PARA FILTRAR LOS DATOS Y QUE SEA MAS FACIL NUESTRA BUSQUEDA
     */
    public partial class frmPeriodo2 : Form
    {
        Int16 indiceColumna = 0;
        DataTable filtro = new DataTable();
        public frmPeriodo2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPeriodo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /* CON ESTE METODO NOS AYUDA QUE NUESTRO dgvPeriodo2 CARGUE LOS DATOS Y LOS MUESTRE EN ESTE
        */
        private void frmPeriodo2_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
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

        /* ESTE METODO HACE LA ACCION DE QUE CUANDO LE DEMOS CLICK EN EL BOTON DE GUARDAR 
         * NOS GUARDE NUESTROS DATOS QUE INGRESAMOS EN LOS TEXT BOX
        */
        private void tmiGuardar_Click(object sender, EventArgs e)
        {
            MPeriodo nuevo = new MPeriodo();
        
                nuevo.MesInicio = txbmesInicio.Text.ToUpper();
                nuevo.MesFin = txbmesFin.Text.ToUpper();
                nuevo.Anio = txbAnio.Text.ToUpper();
                int resp = nuevo.guardar();
                if (resp != 0)
                    MessageBox.Show("EL PERIODO FUE INSERTADO ADECUADAMENTE");
                else
                    MessageBox.Show("EL PERIODO NO FUE INSERTADO ADECUADAMENTE");
          
            this.limpiar();
            this.cargarTabla();


            }
        /* ESTE METODO REALIZA LA ACCION DE LIMPIARNOS NUESTROS TEXT BOX 
         * CADA QUE REALICEMOS UNA ACCION ESTOS SE QUEDARAN LIMPIOS PARA REALIZAR NUEVOS DATOS
        */
             public void limpiar()
        {
            txbidPeriodo.Text = "";
            txbmesInicio.Text = "";
             txbmesFin.Text = "";
             txbAnio.Text = "";
       
        }
             /*EN ESTE METODO REALIZAMOS LA OPERACION EN LA CUAL VALLAMOS A 
              * MODIFICAR,ELIMINAR O CANCELAR EL BOTON DE GUARDAR ESTA INAVILITADO
             */
             private void dgvPeriodo2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
             {

                 txbidPeriodo.Text = dgvPeriodo2.CurrentRow.Cells[0].Value.ToString();
                 txbmesInicio.Text = dgvPeriodo2.CurrentRow.Cells[1].Value.ToString();
                 txbmesFin.Text = dgvPeriodo2.CurrentRow.Cells[2].Value.ToString();
                 txbAnio.Text = dgvPeriodo2.CurrentRow.Cells[3].Value.ToString();
                 txbidPeriodo.Enabled = false;
                 tmiGuardar.Enabled = false;
                 tmiModificar.Enabled = true;
                 tmiCancelar.Enabled = true;
                 tmiEliminar.Enabled = true;
             }
             /*ESTE METODO REALIZA LA OPERACION DE MODIFICAR ALGUN  DATO QUE YA TENGAMOS EN LA BASE DE DATOS 
              * EL CUAL MANDARA UN MENSAGE POSITIVO SI SE REALIZA LA OPERACION CORRECTAMENTE O
              *NEGATIVO SI NO SE REALIZO LA OPERACION CORRECTAMENTE, TODA ESTA ACCION SE
              *REALIZA DANDO CLICK EN EL BOTON DE MODIFICAR
              */
             private void tmiModificar_Click(object sender, EventArgs e)
             {
                 MPeriodo modificado = new MPeriodo();
                 modificado.IdPeriodo = Convert.ToInt16(txbidPeriodo.Text);
                 modificado.MesInicio = txbmesInicio.Text.ToUpper();
                 modificado.MesFin = txbmesFin.Text.ToUpper();
                 modificado.Anio = txbAnio.Text;
                 int resp = modificado.modificar();
                 if (resp != 0)
                     MessageBox.Show("ELEMENTO MODIFICADO");
                 else
                     MessageBox.Show("ELEMENTO NO MODIFICADO");
                 txbidPeriodo.Enabled = true;
                 tmiGuardar.Enabled = true;
                 tmiModificar.Enabled = false;
                 this.cargarTabla();
                 this.limpiar();
             }
                  /*EN ESTE METODO REALIZAMOS LA OPERACION EN LA CUAL ELIMINA ALGUN ELEMENTO QUE YA EXISTA EN LA 
                   * BASE DE DATOS, ESTA ACCION SE REALIZA DANDO CLICK EN EL BOTON DE ELIMINAR
                   * ESTE METODO TAMBIEN TE MANDA MENSAJES LOS CUALES SIRVEN PARA QUE EL USUARIO
                   * SE DE CUANTA SI SE REALIZO LA OPERACION
                  */
             private void tmiEliminar_Click(object sender, EventArgs e)
             {
                 MPeriodo eliminado=new MPeriodo();
                 eliminado.IdPeriodo = Convert.ToInt16(txbidPeriodo.Text);
                 eliminado.MesInicio = txbmesInicio.Text.ToUpper();
                 eliminado.MesFin = txbmesFin.Text.ToUpper();
                 eliminado.Anio = txbAnio.Text;
                 DialogResult respuesta = MessageBox.Show("Esta seguro de eliminar a"+eliminado.IdPeriodo,"Eliminado....",MessageBoxButtons.YesNo);
                 if(respuesta == DialogResult.Yes){
                     int r = eliminado.elimnar();
                     if (r != 0)
                     {
                         MessageBox.Show("Elemeto eliminado correctamente");
                     }
                     else
                         MessageBox.Show("Elemento eliminado");
                 }
                 this.tmiGuardar.Enabled = true;
                 this.tmiModificar.Enabled = false;
                 this.tmiEliminar.Enabled = true;
                 this.tmiCancelar.Enabled = false;
                 this.limpiar();
                 this.cargarTabla();
             }
             /*EN ESTE METODO REALIZAMOS LA OPERACION EN LA CUAL EL USUARIO TIENE LA OPCION
              *  DE CANCELAR ALGUNA OPERACION QUE ALLA REALIZADO MAL COMO POR EJEMPLO 
              *  QUE ELIMINARAS ALGUN PERIODO QUE NO ERA Y QUE EL USUARIO TENGA LA OPORTUNIDAD
              *   DE REGRESAR A SU FORMA ORIGINAL
             */
       
             private void tmiCancelar_Click(object sender, EventArgs e)
             {
                 this.tmiGuardar.Enabled = true;
                 this.tmiModificar.Enabled = false;
                 this.tmiEliminar.Enabled = false;
                 this.tmiCancelar.Enabled = false;
                 this.limpiar();
                 this.cargarTabla();
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
              * ALGUN DATO EN ESPECIFICO LA CUAL ES FILTRADA DEL dgvPeriodo2 NO DE LA BASE DE DATOS,
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

             private void txbidPeriodo_TextChanged(object sender, EventArgs e)
             {
                 
             }

             /*EN ESTE METODO REALIZAMOS LA OPERACION EN LA CUAL SE MUESTRA
              * OTRO FORM EL CUAL LE LLAMAMOS BUSQUEDA PERIODO EL CUAL  APARECE CUANDO SE LE DA CLICK EN 
              * EL BOTON DE BUSCAR DE NUESTRO FORM PERIODO
             */
             private void btnBusqueda_Click(object sender, EventArgs e)
             {
                 BuscaPeriodo cuadro = new BuscaPeriodo();
                 cuadro.ShowDialog(this);
                 MPeriodo leido = cuadro.Elegido;
                 if (leido != null)
                 {
                     txbidPeriodo.Text = leido.IdPeriodo.ToString();
                     txbmesInicio.Text = leido.MesInicio;
                     txbmesFin.Text = leido.MesFin;
                     txbAnio.Text = leido.Anio;
                 }
             }

    }
}
