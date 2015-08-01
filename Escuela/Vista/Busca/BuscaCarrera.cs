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

/* *   Autor : Brayan Uriel Hernandez Gonzalez 
 *             Jennifer Serrano Santiago
 *             Leidy Laura Baltazar Angeles
 *    Autor de la descripcion: Brayan Uriel Hernandez Gonzalez
 *   Fecha : 07/07/ 2014 
 */

namespace Escuela.Vista.Busca
{
    public partial class BuscaCarrera : Form
    {
        Int16 indiceColumna = 0;
        DataTable filtro = new DataTable();
        private MCarrera elegido = new MCarrera();

        /*
         Descripcion: 
         */
        public MCarrera Elegido
        {
            get { return elegido; }
            //set { elegido = value; }
        }

        public BuscaCarrera()
        {
            InitializeComponent();
        }


        /*
        Descripcion: este evento sirve para que a la hora se invoque este formulario se mande llamar el metodo de cargar tabla  y asi se muestre en el datagridview
        */
        private void BuscaCarrera_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
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
         Descripcion: aqui nos permitira seleccionar una columna en el datagridview ademas de cambiar elo color de la columna es este
          caso un azul y si se selecciona otra columna se cambiara de azul a blanco ademas de almacenar el numero de la columna en una variable
         */
        private void dgvCarrera_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCarrera.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.White;
            indiceColumna = Convert.ToInt16(e.ColumnIndex);
            dgvCarrera.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.SteelBlue;
        }

        /*
   Descripcion: aqui a la hora de hacer click en una de las filas del datagridview  nos enviara lo de esa fila a los textbox que tenemos en el formulario
    ademas de ocultar el formulario con el this.hide
        
   */
        private void dgvCarrera_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MCarrera nuevo = new MCarrera();

            nuevo.Codigo = Convert.ToInt32(dgvCarrera.CurrentRow.Cells[0].Value.ToString());
            nuevo.Numero = Convert.ToInt32(dgvCarrera.CurrentRow.Cells[1].Value.ToString());
            nuevo.Planes = dgvCarrera.CurrentRow.Cells[2].Value.ToString();
            nuevo.Nombre = dgvCarrera.CurrentRow.Cells[3].Value.ToString();

            this.elegido = nuevo;
            this.Hide();
        }

    }
}
