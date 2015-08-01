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

/*autor de documentacion:
 carlo ivan estrada romero
 * fecha: 07/07/14*/

namespace Escuela.Vista
{
    /* Este metodo  inicializa la nueva tabla de busqueda de horario
     * 
     */ 
    public partial class BuscaHorario : Form
    {
     /*Este metodo es un indicador de columna para comenzar el filtro de la tabla busqueda de horario
     * 
     */ 

        Int16 indiceColumna = 0;
        DataTable filtro = new DataTable();
        private MHorario elegido;

        public MHorario Elegido
        {
     /* Este metodo retorna las variables de elegido
     * 
     */ 
            get { return elegido; }
            //set { elegido = value; }
        }
        public BuscaHorario()
        {
            InitializeComponent();
        }
     /* En estas lineas de codigo se selecciona la columna y cambian el color, y  el numero de la columna
      *  
     */ 
        private void dgvHora_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
      
            dgvHora.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.White;
            indiceColumna = Convert.ToInt16(e.ColumnIndex);
            dgvHora.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.SteelBlue;

        }
    /*Este metodo es para poder hacer el filtro de la busqueda
     * 
     */ 
        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {
            String filtroPor = dgvHora.Columns[indiceColumna].Name;
            if (txbBusqueda.Text != string.Empty)
            {
                DataView view = CFiltroDatos.filtroDatos(filtro, filtroPor, txbBusqueda.Text);
                dgvHora.DataSource = view;

            }
            else
            {

                this.cargarTabla();
            }

            dgvHora.AutoResizeColumns();
        }
     /* Aqui se cargan los datos de nuestra nueva tabla
     * 
     */ 
        public void cargarTabla()
        {
            MHorario datos = new MHorario();
            dgvHora.DataSource = datos.listarTodos();
            dgvHora.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHora.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHora.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHora.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHora.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHora.Columns[0].Visible = false;

            filtro = CFiltroDatos.llenaTabla(this.dgvHora);
        }
     /*En este metodo se hace la convercion y el evento en el cual se selecciona el data grid de la tabla que se muestra 
     * y te regresa para que los modifiques 
     */ 
        private void dgvHora_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MHorario nuevo = new MHorario();
            nuevo.IdHorario = Convert.ToInt16 (dgvHora.CurrentRow.Cells[0].Value);
            nuevo.Dia1=dgvHora.CurrentRow.Cells[1].Value.ToString();
            nuevo.Inicio = TimeSpan.Parse (dgvHora.CurrentRow.Cells[2].Value.ToString());
            nuevo.Fin = TimeSpan.Parse(dgvHora.CurrentRow.Cells[3].Value.ToString() );
            nuevo.Aula = dgvHora.CurrentRow.Cells[4].Value.ToString();
            this.elegido = nuevo;
            this.Hide();
        }
        /*Este metodo te carga  la tabla en el formulario, busca horario
     * 
     */ 
        private void BuscaHorario_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }

        private void dgvHora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
