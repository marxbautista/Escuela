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

/*
 Autor: Jennifer Serrano Santiago
 * Brayan Uriel Hernandez Gonzalez
 * 09/07/14
 */

namespace Escuela.Vista
{
    public partial class FrmCarrera : Form
    {
        Int16 indiceColumna = 0;
        DataTable filtro = new DataTable();
        public FrmCarrera()
        {
            InitializeComponent();
            txtCodigoDeLaCarrera.Enabled = false;
            tmiModificar.Enabled = false;
        }


        /*
        Descripcion: Este metodo nos ayuda a quitar los datos de los textbox y los dejara limpios
        */
        public void limpiar()
        {
            txtCodigoDeLaCarrera.Text = "";
            txtNumCarrera.Text = "";
            txtNombreCarrera.Text = "";
            txtPlanes.Text = "";
        }


        /*
     Descripcion: Este metodo se encargara de mostrar las columnas y las filas de la tabla en el datagridview
     */

        public void cargarTabla()
        {
            MCarrera Datos = new MCarrera();
            dgvCarrera.DataSource = Datos.listartodos();
            dgvCarrera.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCarrera.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCarrera.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCarrera.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCarrera.Columns[0].Visible = false;
            filtro = CFiltroDatos.llenaTabla(this.dgvCarrera);
        }

        /*
         Descripcion: este evento sirve para que a la hora de ejecutar el programa ejecute el metodo de cargar tabla
         */
        private void frmCarrera_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
            
        }

        /*
     Descripcion: Este metodo lleva a la clase Mcarrera lo que tenemos en los textbox y ademas verifica si se llevo acabo el metodo de guardar en CCarrera con la condicion de si resp 
      ademas de utilizar el metodo de cargar tablqa y limpiar los textbox 
     */

        private void tmiGuardar_Click(object sender, EventArgs e)
        {
            MCarrera nuevo = new MCarrera();
            nuevo.Numero = Convert.ToInt32(txtNumCarrera.Text);
            nuevo.Nombre = txtNombreCarrera.Text.ToUpper();
            nuevo.Planes = txtPlanes.Text.ToUpper();
            int resp = nuevo.guardar();


            if (resp != 0)

                MessageBox.Show("Carrera insertada adecuadamente");
            else
                MessageBox.Show("La Carrera no se guardo");

            this.limpiar();
            this.cargarTabla();
        }

        /*
        Descripcion: aqui al igual que en el metodo de guardar se mandaran los datos que tenemos en los textbox a la clase MCArrera
        y solicitaremos una respuesta para ver si el metodo de modidificar en la clase CCarrera modifico los datos que le pedimos que modificara
        ademas de habilitar el boton de guardar y deshabilitar los demas e invocar los metodos de tabla  para actualizar los datos y el de limpiar para limpiar los textbox
        */
        private void tmiModificar_Click(object sender, EventArgs e)
        {
            MCarrera modificado = new MCarrera();
            modificado.Codigo = Convert.ToInt32(txtCodigoDeLaCarrera.Text);
            modificado.Numero = Convert.ToInt32(txtNumCarrera.Text);
            modificado.Planes = txtPlanes.Text.ToUpper();
            modificado.Nombre = txtNombreCarrera.Text.ToUpper();
            int resp = modificado.modificar();
            if (resp != 0)
                MessageBox.Show("El elemento modificado correctamente");
            else MessageBox.Show("El elemeneto no se a modificado");
            tmiGuardar.Enabled = true;
            tmiModificar.Enabled = false;
            tmiEliminar.Enabled = false;
            tmiCancelar.Enabled = false;
            this.cargarTabla();
            this.limpiar();
        }

        /*
       Descripcion: Aqui al igualque en los otros tmi se pasa lo de los textbox a las variabloes correspondientes en la clase MCarrera
        auqneu solo utilizaremos la varibale codigo ya que es el id de nuestra tabla y para poder eliminar un dato solo es necesario saber su id 
        aqui solo hay una pequeña modificacion la cual es al dar nosotros click en el tmi eliminar se nos mostrara una ventana de confirmacion si realmente queremos
        eliminar los dats o no y pues nos dira si en la clase CCarrera se llevo acabo bien el metodo de eliminar con a leyenda de se elimino
        * correctamente o de lo contrario no se elimino ademas de deshabilitar y habilitar unos tmi y de cargar la tabla modificada y de limpiar los textbox
        */
        private void tmiEliminar_Click(object sender, EventArgs e)
        {
            MCarrera eliminar = new MCarrera();
            eliminar.Codigo = int.Parse(txtCodigoDeLaCarrera.Text);
            eliminar.Numero = int.Parse(txtNumCarrera.Text);
            eliminar.Planes = txtPlanes.Text;
            eliminar.Nombre = txtNombreCarrera.Text;
            DialogResult respuesta = MessageBox.Show("Estas seguro de eliminar a" + eliminar.Nombre, "Eliminando...", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                eliminar.eliminar();
                if (respuesta != 0)
                {
                    MessageBox.Show("Se a eliminado correctamente");
                }
                else
                {

                    MessageBox.Show("No se a eliminado");
                }
            }
            this.tmiGuardar.Enabled = true;
            this.tmiModificar.Enabled = false;
            this.tmiEliminar.Enabled = false;
            this.tmiCancelar.Enabled = false;
            this.limpiar();
            this.cargarTabla();
        }

        /*
       Descripcion: el tmi cancelar solo limpiara los textbox de la informacion que contengan y cargara nuevamente la tabla esta opcion solo estara
      habilitada cuando se haga click en el datagridview y habilitara el tmi de guardar y deshabilitara los demas
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

        /*
        aquie en el boton busqueda se invoca el form busca Carrera ademas de obtener los valores que se seleccionaron el otro formulario
        */
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            BuscaCarrera cuadro = new BuscaCarrera();
            cuadro.ShowDialog(this);
            MCarrera leido = cuadro.Elegido;
            if (leido != null)
            {
                txtCodigoDeLaCarrera.Text = leido.Codigo.ToString();
                txtNumCarrera.Text = leido.Numero.ToString();
                txtPlanes.Text = leido.Planes;
                txtNombreCarrera.Text = leido.Nombre;
                tmiEliminar.Enabled = true;
                tmiModificar.Enabled = true;
                tmiCancelar.Enabled = true;
                tmiGuardar.Enabled = false;
            }
        }

        /*
     Descripcion: aqui se filtran los datos de la columna seleccionada y se compararan con lo que contiene el txtBusqueda  para poder mostrar
     el dato en si si se mete un nombre completo que este en la tabla o los datos de las coincidencias de las letras
     */

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            String filtroPor = dgvCarrera.Columns[indiceColumna].Name;
            if (txtBusqueda.Text != string.Empty)
            {
                DataView view = CFiltroDatos.filtroDatos(filtro, filtroPor, txtBusqueda.Text);
                dgvCarrera.DataSource = view;


            }
            else
            {
                this.cargarTabla();
            }
            dgvCarrera.AutoResizeColumns();
        }

        /*
         Descripcion: aqui a la hora de hacer click en una de las filas del datagridview  nos enviara lo de esa fila a los textbox que tenemos en el formulario
         ademas de habilitar los tmi de modificar, elimininar y cancelar y deshabilitar los demas
         */
        private void dgvCarrera_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCodigoDeLaCarrera.Text = dgvCarrera.CurrentRow.Cells[0].Value.ToString();
            txtNumCarrera.Text = dgvCarrera.CurrentRow.Cells[1].Value.ToString();
            txtPlanes.Text = dgvCarrera.CurrentRow.Cells[2].Value.ToString();
            txtNombreCarrera.Text = dgvCarrera.CurrentRow.Cells[3].Value.ToString();
            txtCodigoDeLaCarrera.Enabled = false;
            tmiGuardar.Enabled = false;
            tmiModificar.Enabled = true;
            tmiEliminar.Enabled = true;
            tmiCancelar.Enabled = true;
        }


        /*
         Descripcion: aqui nos permitira seleccionar una columna en el datagridview ademas de cambiar elo color de la columna es este
          caso un azul y si se selecciona otra columna se cambiara de azul a blanco ademas de almacenar el numero de la columna en una variable
         */
        private void dgvCarrera_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCarrera.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.White;
            indiceColumna = Convert.ToInt16(e.ColumnIndex);
            dgvCarrera.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.SteelBlue;
        }
    }
}
