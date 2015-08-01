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
 *   AUTOR: MARIO PEREZ BAUTISTA
 *  FECHA: 02/07/2014
 *  Autor de docmentción: Mario Pérez Bautista
 */
namespace Escuela.Vista
{
    public partial class FrmAlumno : Form
    {
        Int16 indiceColumna = 0;
        DataTable filtro = new DataTable();
        public FrmAlumno()
        {
            InitializeComponent();
        }
        /*
         * Este metod recibe de  las cajas de texto toda la información  de un alumno para
         * posteriomente guardar en la base de datos
         */         
        private void tmiGuardar_Click(object sender, EventArgs e)
        {
            MAlumno nuevo = new MAlumno();
            if (txbMatricula.Text != "")//para evitar ingresar matriculas vacías
            {
                nuevo.Matricula = txbMatricula.Text.Trim();
                nuevo.Nombre = txbNombre.Text.ToUpper().Trim();
                int resp = nuevo.guardar();
                if (resp != 0)
                    MessageBox.Show("Alumno Insertado adecuadamente");
                else
                    MessageBox.Show("El alumno no se guardo adecuadamente");
            }
            this.limpiar();
            this.cargarTabla();
        }
        public void limpiar() {
            txbMatricula.Text = "";
            txbNombre.Text = "";
        }

        private void FrmAlumno_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }
        public void cargarTabla() {
            MAlumno datos=new MAlumno();
            dgvAlumno.DataSource = datos.listarTodos();
            dgvAlumno.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAlumno.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            filtro = CFiltroDatos.llenaTabla(this.dgvAlumno);
        }

        private void dgvAlumno_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txbMatricula.Text = dgvAlumno.CurrentRow.Cells[0].Value.ToString();
            txbNombre.Text = dgvAlumno.CurrentRow.Cells[1].Value.ToString();
            
            txbMatricula.Enabled = false;
            tmiGuardar.Enabled = false;
            tmiModificar.Enabled = true;
            tmiEliminar.Enabled = true;
            tmiCancelar.Enabled = true;
        }

        private void tmiModificar_Click(object sender, EventArgs e)
        {
            MAlumno modificado = new MAlumno();
            modificado.Matricula = txbMatricula.Text.Trim();
            modificado.Nombre = txbNombre.Text.ToUpper().Trim();
            int resp=modificado.modificar();
            if (resp != 0)
                MessageBox.Show("Elemento Modificado adecuadamente");
            else
                MessageBox.Show("Falló la modificación");
            txbMatricula.Enabled = true;
            tmiGuardar.Enabled = true;
            tmiModificar.Enabled = false;
            tmiEliminar.Enabled = false;
            tmiCancelar.Enabled = false;
            this.cargarTabla();
            this.limpiar();
        }

        private void tmiEliminar_Click(object sender, EventArgs e)
        {
            MAlumno eliminado = new MAlumno();
            eliminado.Matricula = txbMatricula.Text.Trim();
            eliminado.Nombre = txbNombre.Text.Trim();
            if (eliminado.consultaExistencia()) {
                DialogResult  resp = MessageBox.Show(this, "Estas seguro de eliminar a " + eliminado.Nombre, "Eliminando...", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes) {
                    int resp2 = eliminado.eliminar();
                    if (resp2 != 0)
                        MessageBox.Show("Elemento eliminado correctamente");
                    else
                        MessageBox.Show("Falló La eliminación");                    
                }
            }
            txbMatricula.Enabled = true;
            tmiGuardar.Enabled = true;
            tmiModificar.Enabled = false;
            tmiEliminar.Enabled = false;
            tmiCancelar.Enabled = false;
            this.cargarTabla();
            this.limpiar();


        }

        private void dgvAlumno_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvAlumno.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.White;
            indiceColumna = Convert.ToInt16(e.ColumnIndex);
            dgvAlumno.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.SteelBlue;
        }
        private void txbBusca_TextChanged(object sender, EventArgs e)
        {
            String filtroPor = dgvAlumno.Columns[indiceColumna].Name;
            if (txbBusca.Text != string.Empty)
            {
                DataView view = CFiltroDatos.filtroDatos(filtro, filtroPor, txbBusca.Text);
                dgvAlumno.DataSource = view;
            }
            else
            {
                this.cargarTabla();
            }
            dgvAlumno.AutoResizeColumns();
        }

        private void tmiCancelar_Click(object sender, EventArgs e)
        {
            txbMatricula.Enabled = true;
            tmiGuardar.Enabled = true;
            tmiModificar.Enabled = false;
            tmiEliminar.Enabled = false;
            tmiCancelar.Enabled = false;
            this.cargarTabla();
            this.limpiar();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            BuscaAlumno cuadro = new BuscaAlumno();
            cuadro.ShowDialog(this);
            MAlumno leido = cuadro.Escogido;
            if (leido != null)
            {
                txbMatricula.Text = leido.Matricula;
                txbNombre.Text = leido.Nombre;
            }
        }

    }
}
