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
 * Autores: Bibiano, Deyanira, Gonzalo
 * Fecha: lunes 14 de julio 2014
 */
namespace Escuela.Vista
{
    public partial class frmGrupo : Form
    {
        //cuando se filtrados los datos de la tabla
        Int16 indiceColumna = 0;
        DataTable filtro = new DataTable();
        public frmGrupo()
        {
            InitializeComponent();
            
        }

        //se mandan a llamar los atributos de las llaves foraneas en cada combo
        private void cargarCombo()
        {

            cboIdPeriodo.DataSource = new MPeriodo().listarTodos();
            cboIdPeriodo.ValueMember = "idPeriodo";
            cboIdPeriodo.DisplayMember = "periodoCorto";

            cboDocente.DataSource = new MDocente().listarTodos();
            cboDocente.ValueMember = "idDocente";
            cboDocente.DisplayMember = "nombre";

            cboCarrera.DataSource = new MCarrera().listartodos();
            cboCarrera.ValueMember = "codigo";
            cboCarrera.DisplayMember = "Nombre";

            cboIdClaveMateria.DataSource= new MMateria().listarTodos();
            cboIdClaveMateria.ValueMember= "clave";
            cboIdClaveMateria.DisplayMember="NombreMateria";

            cboHorario.DataSource = new MHorario().listarTodos();
            cboHorario.ValueMember = "IdHorario";
            cboHorario.DisplayMember = "HorarioGrupo";
            

            
        }
        private void frmGrupo_Load(object sender, EventArgs e)
        {
            //carga todos los combos y nuevamente la tabla
            this.cargarCombo();
            this.cargarTabla();
        }
        private void limpiar()
        {
            //para limpiar el formulario e ingresar datos nuevamente
           txbClaveGrupo.Text = "";
            cboIdPeriodo.Text = "";
            cboDocente.Text = "";
            cboIdClaveMateria.Text = "";
            cboCarrera.Text = "";
            cboHorario.Text = "";
        }

        

        private void tmiGuardar_Click(object sender, EventArgs e)
        {
            //cuando se guardan todos los datos de las llaves foraneas
            //despues para completar manda que si se guardo correctamente los datos o fue un error
            //limpia la tabla
            //cargar nuevamente la tabla
            //y los combos nuevamente
            MGrupo nuevo = new MGrupo();
            nuevo.ClaveGrupo = txbClaveGrupo.Text.Trim();
    

            nuevo.FkIdPeriodo = Convert.ToInt32(cboIdPeriodo.SelectedValue);
       
            nuevo.FkIdDocente = Convert.ToInt32(cboDocente.SelectedValue.ToString());
            nuevo.FkClaveMateria = cboIdClaveMateria.SelectedValue.ToString();
            nuevo.FkIdCarrera = Convert.ToInt32(cboCarrera.SelectedValue.ToString());
            nuevo.FkIdHorario = Convert.ToInt32(cboHorario.SelectedValue.ToString());
            int resp = nuevo.guardar();
            if (resp != 0)
                MessageBox.Show("Grupo Guardado Adecuadamente");
            else
                MessageBox.Show("Error Al Guardar");

            this.limpiar();
            this.cargarTabla();
            this.cargarCombo();
        }

       

        private void tmiModificar_Click(object sender, EventArgs e)
        {
            //para modifacar cada datos del usuio si se decea hacer de las llaves foraneas
            //manda un mensaje si se modifico adecuadamente o fue un error
            //se habilita el campo clave grupo y los botones guardar y modificar
            //carga nuevamente la tabla

            MGrupo modificado = new MGrupo();
            modificado.ClaveGrupo = txbClaveGrupo.Text.Trim();


            modificado.FkIdPeriodo = Convert.ToInt32(cboIdPeriodo.SelectedValue);

            modificado.FkIdDocente = Convert.ToInt32(cboDocente.SelectedValue.ToString());
            modificado.FkClaveMateria = cboIdClaveMateria.SelectedValue.ToString();
            modificado.FkIdCarrera = Convert.ToInt32(cboCarrera.SelectedValue.ToString());
            modificado.FkIdHorario = Convert.ToInt32(cboHorario.SelectedValue.ToString());
            int resp = modificado.modificar();

            if (resp != 0)
                MessageBox.Show("Modificado Adecuadamente ");
            else
                MessageBox.Show("Error de Modificacion ");
            txbClaveGrupo.Enabled = true;
            tmiGuardar.Enabled = true;
            tmiModificar.Enabled = true;
            this.cargarTabla();
            
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            //muestra el formulario como un cuadro de dialogo modal con el propietario especificado
             BuscaGrupo cuadro = new BuscaGrupo();
            cuadro.ShowDialog(this);
            MGrupo leido = cuadro.Elegido;
            if (leido != null)
            {
                 MHorario datos = new MHorario();
                txbClaveGrupo.Text = leido.ClaveGrupo.ToString();
                cboIdPeriodo.Text = leido.FkIdPeriodo.ToString();
                cboDocente.Text= leido.FkIdDocente.ToString();
                cboIdClaveMateria.Text = leido.FkClaveMateria.ToString();
                cboCarrera.Text= leido.FkIdCarrera.ToString();
                cboHorario.Text = leido.FkIdHorario.ToString();

            }

        }

        private void tmiEliminar_Click(object sender, EventArgs e)
        {
            //este metodo es para eliminar un grupo 
            //manda el mensaje si realmente lo quiere eliminar
            //y si si dice que el elemento fue eliminado correctamente
            MGrupo eliminado = new MGrupo();
            eliminado.ClaveGrupo = txbClaveGrupo.Text.Trim();


            eliminado.FkIdPeriodo = Convert.ToInt32(cboIdPeriodo.SelectedValue);

            eliminado.FkIdDocente = Convert.ToInt32(cboDocente.SelectedValue.ToString());
            eliminado.FkClaveMateria = cboIdClaveMateria.SelectedValue.ToString();
            eliminado.FkIdCarrera = Convert.ToInt32(cboCarrera.SelectedValue.ToString());
            eliminado.FkIdHorario = Convert.ToInt32(cboHorario.SelectedValue.ToString());
            
            
            DialogResult respuesta = MessageBox.Show("Esta seguro de Eliminar a " + eliminado.ClaveGrupo,
                "Eliminando...", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                int r = eliminado.eliminar();
                if (r != 0)
                {
                    MessageBox.Show("Elemento eliminado Correctamente");
                    eliminado.eliminar();
                }
                else MessageBox.Show("Elemento No Eliminado");

            }
            // se abilita del menu el boton guardar
            // se hinabilitan del munu los botones modificar cancelar y eliminar
            // se limpia la tabla sin dejar ningun dato
            //carga nuevamente la tabla
            this.tmiGuardar.Enabled = true;
            this.tmiModificar.Enabled = false;
            this.tmiCancelar.Enabled = false;
            this.tmiEliminar.Enabled = false;
            this.limpiar();
            this.cargarTabla();

        }
        public void cargarTabla()
        {
            //se cargan los datos en las columnas en el datagridview

            MGrupo dato = new MGrupo();
          


            dgvGrupo.DataSource = dato.listarTodos();
            dgvGrupo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGrupo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGrupo.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGrupo.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGrupo.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
          
          //para mostrar todos los datos en cada columna correspondiente
            dgvGrupo.Columns[1].Visible = true;
            dgvGrupo.Columns[2].Visible = true;
            dgvGrupo.Columns[3].Visible = true;
            dgvGrupo.Columns[4].Visible = true;
            dgvGrupo.Columns[5].Visible = true;
        }

        private void tmiCancelar_Click(object sender, EventArgs e)
        {
            //se habilita el boton guardar en el menu
            // se hinabilitan los botones modificar, eliminar, cancelar en el menu
            //se limpia la tabla nuevamente 
            //carga la tabla nuevamente
            //y los combos se cargan nuevamente
                this.tmiGuardar.Enabled = true;
                this.tmiModificar.Enabled = false;
                this.tmiEliminar.Enabled = false;
                this.tmiCancelar.Enabled = false;
                this.limpiar();
                this.cargarTabla();
                this.cargarCombo();
            
        }

        private void dgvGrupo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cuando se selecciona un fila y se le asigna un color en especifico 
            dgvGrupo.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.White;
            indiceColumna = Convert.ToInt16(e.ColumnIndex);
            dgvGrupo.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.SteelBlue;
        }

        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {
            // para buscar un dato y sea filtrado para modificarce o eliminar
            String filtroPor = dgvGrupo.Columns[indiceColumna].Name;
            if (txbBuscar.Text != string.Empty)
            {
                DataView view = CFiltroDatos.filtroDatos(filtro, filtroPor, txbBuscar.Text);
                dgvGrupo.DataSource = view;


            }
            else
            {
                this.cargarTabla();
                //carga nuevamente la tabla
            }
            dgvGrupo.AutoResizeColumns();
        }

        private void dgvGrupo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //para que se cargen las filas en los combos 
            txbClaveGrupo.Text = dgvGrupo.CurrentRow.Cells[0].Value.ToString();


            string llavePeriodo = dgvGrupo.CurrentRow.Cells[1].Value.ToString();
            MPeriodo periodo = new MPeriodo();
            string periodo2 = periodo.checarPeriodo(llavePeriodo);
            cboIdPeriodo.Text = periodo2;

            string keyDocente = dgvGrupo.CurrentRow.Cells[2].Value.ToString();
            MDocente Docente = new MDocente();
            string docente2 = Docente.checaDocente(keyDocente);
            cboDocente.Text = docente2;

            string keyMateria = dgvGrupo.CurrentRow.Cells[3].Value.ToString();
           string idMateria = keyMateria;
            MMateria Materia = new MMateria();

            cboIdClaveMateria.Text = Materia.checaMateria(keyMateria);

            string keyCarrera = dgvGrupo.CurrentRow.Cells[4].Value.ToString();
            MCarrera Carrera = new MCarrera();
            cboCarrera.Text = Carrera.checaCarrera(keyCarrera);


            string keyHora = dgvGrupo.CurrentRow.Cells[5].Value.ToString();
            MHorario horario = new MHorario();
            string idHorario = horario.checaHorario(keyHora);
            cboHorario.Text =idHorario;

            //se hinabilita el campo de texto clave grupo
            //se hinabilita el boton guardar en la barra de menus
            //se ahabilitan los botones modificar, eliminar y cancelar en la barra de menus
            txbClaveGrupo.Enabled = false;
            tmiGuardar.Enabled = false;
            tmiModificar.Enabled = true;
            tmiEliminar.Enabled = true;
            tmiCancelar.Enabled = true;
        }
       }
     }

   


    

