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
 * Autores: Deyanira, Bibiano, Gonzalo
 * fecha: 14/07/14
 * 
 */
namespace Escuela.Vista.Busca
{
 /*
  * se declara la clase que filtra la tabla de grupo
  */
    public partial class BuscaGrupo : Form
    {
        Int16 indiceColumna = 0;
        DataTable filtro = new DataTable();
        private MGrupo elegido;

        /*
         * se crea el metodo get y set de Elegido 
         *  
         */
        public MGrupo Elegido 
        {
            get { return elegido; }
            set { elegido = value; }
        }

        public BuscaGrupo()
        {
            InitializeComponent();
        }
     //este metodo se encarga de cargar las columnas de la tabla

        public void cargarTabla()
        {

            MGrupo dato = new MGrupo();
            dgvGrupo.DataSource = dato.listarTodos();
            dgvGrupo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGrupo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGrupo.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGrupo.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGrupo.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            dgvGrupo.Columns[1].Visible = true;
            dgvGrupo.Columns[2].Visible = true;
            dgvGrupo.Columns[3].Visible = true;
            dgvGrupo.Columns[4].Visible = true;
            dgvGrupo.Columns[5].Visible = true;
        }
        //este es el evento se encarga de cargar la tabla nuevamente
        private void BuscaGrupo_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
          
        }
        //en este metodo declaramos la dvg para que pueda buscar en las columnas
        //se ponga de en el color indicado
        private void dgvGrupo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvGrupo.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.White;
            indiceColumna = Convert.ToInt16(e.ColumnIndex);
            dgvGrupo.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.SteelBlue;
        }

        //este metodo se produce cuando el usuario haga clic dentro de los límites de un encabezado de fila.Y se estan 
        //convirtiendo los datos en String
        private void dgvGrupo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MGrupo nuevo = new MGrupo();
            nuevo.ClaveGrupo = dgvGrupo.CurrentRow.Cells[0].Value.ToString();
            nuevo.FkIdPeriodo =Convert.ToInt32( dgvGrupo.CurrentRow.Cells[1].Value.ToString());
            nuevo.FkIdDocente =Convert.ToInt32( dgvGrupo.CurrentRow.Cells[2].Value.ToString());
            nuevo.FkClaveMateria = dgvGrupo.CurrentRow.Cells[3].Value.ToString();
            nuevo.FkIdCarrera = Convert.ToInt32(dgvGrupo.CurrentRow.Cells[2].Value.ToString());
            nuevo.FkIdHorario = Convert.ToInt32(dgvGrupo.CurrentRow.Cells[2].Value.ToString());
            this.elegido = nuevo;
            this.Hide();

        }

        private void dgvGrupo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
