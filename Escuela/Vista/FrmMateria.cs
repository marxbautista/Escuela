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
 * AUTOR:MITZEL,RANDY,BRENDA
 * FECHA:03-07-14
 * FECHA 10-07-14 ACTUALIZACION 
 * AUTOR DE COMENTARIOS: BRENDA GACHUZ SANTIAGO
 */

namespace Escuela.Vista
{
    public partial class frmMateria : Form
    {
        //declaracion de atributos globales utilizados en metodos de busqueda 
        Int16 indiceColumna = 0; 
        DataTable filtro = new DataTable();
        //constructor de la clase 
        public frmMateria()
        {
            InitializeComponent();
        }

       /*
        * metodo que invoca al metodo cargar tabla 
        */
        private void FrmMateria_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }
        /*metodo cargarTabla: metodo que carga la tabla en dgvVista se toma de la consulta en la base de datos, 
         indicalndole el numero del indice de la columna, ajustando el tamaño */
        public void cargarTabla()
        {
            MMateria datos = new MMateria();
            dgvVista.DataSource = datos.listarTodos();
            dgvVista.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvVista.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            filtro = CFiltroDatos.llenaTabla(this.dgvVista);
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*
         * metodo guardar: metodo que guarda el contenido extraido de las cajas de texto txbClave y txbNombre  haciendo 
         * validaciones 
         * 
         */
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
             MMateria nuevo = new MMateria();
             nuevo.Clave = txbClave.Text.Trim();   
             if (txbClave.Text != "") //evitar insertar claves de materia   vacias  
            {
                if (nuevo.Clave.Length > 6)
                nuevo.Clave = txbClave.Text.Substring(0, 5);
                 nuevo.NombreMateria = txbNombreMateria.Text.ToUpper();
                 int resp = nuevo.guardar();
                 if (resp != 0)
                     MessageBox.Show("materia insertada adecuadamente");
                 else
                     MessageBox.Show("La materia  no se guardo adecuadamente");
             }
                   this.limpiar();// metodo para limpiar los textbox despues de guardar
                   this.cargarTabla();//metodo que muestra la actualizacion de la tabla Materia  despues de guardar
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /*
         * metodo que limpia los text box de clave y NombreMateria simple mente enviando cadenas vacías 
         */
        public void limpiar()
        {
            txbClave.Text = "";
            txbNombreMateria.Text = "";
        }
        /*
         * metodo dgvVista_RowHeaderMouseClick: hace referencia al evento RowHeaderMouseClick  que al hacer click al 
         * encabezado de la tabla  nos lanza las opciones de modificar, eliminar  o cancelar operacion sin poder modificar
         * la clave que es llave primaria 
         */
        private void dgvVista_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txbClave.Text = dgvVista.CurrentRow.Cells[0].Value.ToString();
            txbNombreMateria.Text = dgvVista.CurrentRow.Cells[1].Value.ToString();
            txbClave.Enabled = false;
            tmiGuardar.Enabled = false;
            tmiModificar.Enabled = true;
            tmiEliminar.Enabled = true;
            tmiCancelar.Enabled = true;
        }

        /*
         * metodo en el cual al hacer click sobre el menú item permite moificar unicamente el nombre de 
         * la materia, la clave no se puede modificar por su caracteristica de ser llave primaria 
         *  creando una variable entera resp en caso de que ésta sea diferente de 0 de modifica el elemento 
         *  en caso contrario no realiza la operacion, habilitando guardar y modificar una vez mas, posteriormente 
         *  cargando la tabla con los cambios realizados y limpiando las cajas de texto
         */
        private void tmiModificar_Click(object sender, EventArgs e)
        {
            MMateria modificado = new MMateria();
            modificado.Clave = txbClave.Text;
                modificado.NombreMateria = txbNombreMateria.Text.ToUpper();
            int resp = modificado.modificar();
            if (resp != 0)
                MessageBox.Show("Elemento modificado adecuadamente");
            else
                MessageBox.Show("falló modificacion ");
            txbClave.Enabled = true;
            tmiGuardar.Enabled = true;
            tmiModificar.Enabled = true;
            tmiEliminar.Enabled = true;
            tmiCancelar.Enabled = true;
            this.cargarTabla();
            this.limpiar();
        }
        /*
         * Metodo tmiEliminar, al hacer click en el tool menu item eliminar cualquiera de los elementos de la tabla
         * se envia un mensaje en el cual se pregunta si se quiere eliminar el elemento, identificandolo mediante la clave de 
         * materia. se invoca al metodo eliminar y en caso de ser afirmativa se elimina la materia en caso contrario no procede a la
         * eliminacion de el elemento, se inhabilitan y habilitan opciones asi como limpiar y cargar los datos actualizados en la BD
         */
        private void tmiEliminar_Click(object sender, EventArgs e)
        {
            MMateria eliminado = new MMateria();
            eliminado.Clave = txbClave.Text;
            eliminado.NombreMateria = txbNombreMateria.Text;
            DialogResult respuesta = MessageBox.Show("Estás seguro de eliminar a "+ eliminado.NombreMateria,"eliminando...",MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                int r = eliminado.eliminar();
                if (r != 0)
                {
                    MessageBox.Show("Materia eliminada");
                }
                else {
                    MessageBox.Show("Materia no eliminda");
                }
                
            }
            this.tmiGuardar.Enabled = true;
            this.tmiModificar.Enabled = false;
            this.tmiEliminar.Enabled = false;
            this.tmiCancelar.Enabled = false;
            this.txbClave.Enabled = true;
            this.limpiar();
            this.cargarTabla();            
        }
        /*
         * metodo  cancelar : este metodo solo cancela cualquier operacion por ejecutar y regresa cualquier campo a su 
         * estado anterior 
         */
        private void tmiCancelar_Click(object sender, EventArgs e)
        {
            this.tmiGuardar.Enabled = true;
            this.tmiModificar.Enabled = false;
            this.tmiEliminar.Enabled = false;
            this.tmiCancelar.Enabled = false;
            this.txbClave.Enabled = true;
            this.limpiar();
            this.cargarTabla();  
        }


        /*
         * Éste metodo se refiere al evento ColumnHeaderMouseClick en el cual al hacer click en el 
         * encabezado de la columna la cambia de color 
         */
        private void dgvVista_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            dgvVista.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.White;
            indiceColumna = Convert.ToInt16(e.ColumnIndex);
            dgvVista.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.SteelBlue;
        }
        /*
         * metodo en el cual se hace la busqueda de acuerdo a la columna seleccionada en el cual no se permite buscar numero si la 
         * columna es unicamente de nombres y viseversa, mediante una consulta unicamente en el CRUD  ya que hacer la consulta en BD 
         * resultaría mas tardado en el se filtra la informacion usando unicamente los caracteres  introducidos en  en el text box
         * busqueda, actualizando la tabla y dando tamaño automatico a las columnas 
         */
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

        /*
         * metodo que hace referencia al evento click  en el cual desplega la ventana de busqueda de elementos en otro frame al cual 
         * llamamos y una vez seleccionado el elemento deseado regresa al  frame original para realizar cualquier operacion, ya sea
         * modificar, eliminar o si se desea cancelar la operacion 
         */

        private void button1_Click(object sender, EventArgs e)
        {
            BuscaMAteria cuadro = new BuscaMAteria();
            cuadro.ShowDialog(this);
            MMateria leido = cuadro.Elegida;
            if (leido != null)
            {
                txbClave.Text = leido.Clave;
                txbNombreMateria.Text = leido.NombreMateria;
            }
           
        }

        private void txbClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (txbClave.Text.Length < 6)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;*/
        }
    }
}
