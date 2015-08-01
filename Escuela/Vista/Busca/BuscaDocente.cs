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
    Autor de Cometario: Gonzalo Aguilar Perez
   Fecha: 07/07/2014
*/

namespace Escuela.Vista
{
    public partial class BuscaDocente : Form
    {
        Int16 indiceColumna = 0;/// Representa un intero de bits con signo que es igualado a 0
        DataTable filtro = new DataTable();///Representa una tabla de datos
        private MDocente elegido;///para hacer el metodo MDocente elejido en privado

        public MDocente Elegido ///Se convierte en metodo en publico
        {
            get { return elegido; }///metodo de acceso a la propiedad para obtener y devolver las variables
            set { elegido = value; }
        }

        public BuscaDocente()
        {
            InitializeComponent();///carga la página compilada de un componente.
        }

        private void dgvDocente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)///se produce cuando se hace clic en el encabezado de la columna///se produce cuando se hace clic en el encabezado de la columna
        {
            dgvDocente.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.White;///se le asigna un color en especifico a la columna seleccionada
            indiceColumna = Convert.ToInt16(e.ColumnIndex);///convierte el dato decimal en entero 
            dgvDocente.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.SteelBlue;///se le asigna un color en especifico a la columna seleccionada
        }

        private void txbBusqueda_TextChanged(object sender, EventArgs e)///cuando el contenido del cuadro de texto entre los envios hacia el servidor
        {
            String filtroPor = dgvDocente.Columns[indiceColumna].Name;///filtra el dato en la columna especificada
            if (txbBusqueda.Text != String.Empty)///si hay algo en la caja de texto de busqueda entonces se iniciara la busqueda del dato sin importar que caracter este antes o despues 
            {
                DataView view = CFiltroDatos.filtroDatos(filtro, filtroPor,
                    txbBusqueda.Text);
                dgvDocente.DataSource = view;

            }
            else
            {
                this.cargarTabla();///carga nuevamente la tabla 
            }
            dgvDocente.AutoResizeColumns();///para ajustar el ancho de las columnas
        }
        public void cargarTabla()
        {
            MDocente datos = new MDocente();
            dgvDocente.DataSource = datos.listarTodos();
            dgvDocente.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;///para especificar los anchos de columnas se encapsulan.
            dgvDocente.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;///para especificar los anchos de columnas se encapsulan.

            filtro = CFiltroDatos.llenaTabla(this.dgvDocente);///filta los datos en la tabla docente


        }

        private void dgvDocente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)///Proporciona datos para los eventos cuando el mouse se mueve dentro de DataGridViewCell
        {
            MDocente nuevo = new MDocente();
            nuevo.IdDocente = Convert.ToDecimal(dgvDocente.CurrentRow.Cells[0].Value.ToString());///Obtiene la fila que contiene la celda actual.
            nuevo.Nombre = dgvDocente.CurrentRow.Cells[1].Value.ToString();///Obtiene la fila que contiene la celda actual.
            this.elegido = nuevo;
            this.Hide();///para esconder el control al usuario
        }

        private void BuscaDocente_Load(object sender, EventArgs e)///representa la clase base que contiene datos de los eventos y proporciona una valor para utilizar en los que se incluye los datos del evento
        {
            this.cargarTabla();///carga nuevamente la tabla
        }
    }
}
