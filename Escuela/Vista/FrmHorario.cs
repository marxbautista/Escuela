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

/* autor: Azhenet Sanchez Oviedo
 * fecha: 03/07/14
 * autor de documentacion:
 * shanary de jesus martinez chacon... 
  * fecha: 07/07/14

 */

namespace Escuela.Vista
{
    /* En este metodo creamos las tabla
     *  
     */
    public partial class FrmHorario : Form
    {


        Int16 indiceColumna = 0;
        DataTable filtro = new DataTable();
        string datos;
        string datos2;
        public FrmHorario()
        {
            InitializeComponent();
            tmiModificar.Enabled = false;
        }




        /* En este metodo guardamos nuestros datos ingresados en nuestra tabla y manadamos las exepciones
         *  
         */
        private void tmiGuardar_Click(object sender, EventArgs e)
        {

            MHorario nuevo = new MHorario();
            if (cboDia.Text == "Lunes")
            {
                nuevo.Dia1 = "LU";
            }
            if (cboDia.Text == "Martes")
            {
                nuevo.Dia1="MA";
            }
            if (cboDia.Text == "Miercoles")
            {
                nuevo.Dia1 = "MI";
            }
            if (cboDia.Text == "Jueves")
            {
                nuevo.Dia1="JU";
            }
            if (cboDia.Text == "Viernes")
            {
                nuevo.Dia1="VI";
            }
            if (cboDia.Text == "Sabado")
            {
                nuevo.Dia1="SA";
            }
            if (cboDia.Text == "Domingo")
            {
                nuevo.Dia1 = "DO";
            }
            //nuevo.Dia1 = cboDia.Text.ToUpper();
                nuevo.Inicio =TimeSpan.Parse (cboInicio1.Text+":"+cboInicio2.Text);
                nuevo.Fin = TimeSpan.Parse(cboFin1.Text+":"+cboFin2.Text);
                nuevo.Aula = txbAula.Text;
                int resp = nuevo.guardar();
                if (resp != 0)
                    MessageBox.Show("Horario Insertado Adecuadamente");
                else
                    MessageBox.Show("El Horario No se Guardo adecuadamente");
            
            this.limpiar();
            this.cargarTabla();


        }

        /* En este metodo limpiamos las cajas de texto
         *  
         */
        public void limpiar()
        {
            txbHorario.Text = "";
            cboDia.Text = "";
            cboInicio1.Text = "";
            cboInicio2.Text = "";
            cboFin1.Text = "";
            cboFin2.Text = "";
            txbAula.Text = "";

        }

        /* En este metodo se carga nuestra tabla
         *  
         */
        private void FrmHorario_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }

         
        /* En este metodo cargamos los datos ingresados de la tabla
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


        /* En este metodo cargamos los datos en la caja de texto
         *  
         */
        private void dgvHora_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txbHorario.Text = dgvHora.CurrentRow.Cells[0].Value.ToString();
            if (dgvHora.CurrentRow.Cells[1].Value.ToString().ToUpper()=="LU")
                cboDia.Text = "Lunes";
            if (dgvHora.CurrentRow.Cells[1].Value.ToString().ToUpper() == "MA")
                cboDia.Text = "Martes";
            if (dgvHora.CurrentRow.Cells[1].Value.ToString().ToUpper() == "MI")
                cboDia.Text = "Miercoles";
            if (dgvHora.CurrentRow.Cells[1].Value.ToString().ToUpper() == "JU")
                cboDia.Text = "Jueves";
            if (dgvHora.CurrentRow.Cells[1].Value.ToString().ToUpper() == "VI")
                cboDia.Text = "Viernes";
            if (dgvHora.CurrentRow.Cells[1].Value.ToString().ToUpper() == "SA")
                cboDia.Text = "Sabado";
            if (dgvHora.CurrentRow.Cells[1].Value.ToString().ToUpper() == "DO")
                cboDia.Text = "Domingo";

            datos = dgvHora.CurrentRow.Cells[2].Value.ToString();
            datos2 = dgvHora.CurrentRow.Cells[3].Value.ToString();
            txbAula.Text = dgvHora.CurrentRow.Cells[4].Value.ToString();
            txbHorario.Enabled = false;
            tmiGuardar.Enabled = false;
            tmiModificar.Enabled = true;
            tmiEliminar.Enabled = true;
            tmiCancelar.Enabled = true;

            string inicio;
            string[] split = datos.Split(new Char[] { ':' });
            for (int i = 0; i < split.Length; i++)
            {
                if (i == 0)
                {
                    cboInicio1.Text = split[i];
                }
                if (i == 1)
                {
                    cboInicio2.Text=split[i];
                }

            }

            string[] split2 = datos2.Split(new Char[] { ':' });
            for (int i = 0; i < split2.Length; i++)
            {
                if (i == 0)
                {
                    cboFin1.Text = split2[i];
                }
                if (i == 1)
                {
                    cboFin2.Text = split2[i];
                }

            }

        }


        /* En este metodo  cargamos los datos del tmiModificar y se mandan la exepciones
         *  
         */
        private void tmiModificar_Click(object sender, EventArgs e)
        {

            MHorario modificado = new MHorario();

            if (cboDia.Text == "Lunes")
            {
                modificado.Dia1 = "LU";
            }
            if (cboDia.Text == "Martes")
            {
                modificado.Dia1 = "MA";
            }
            if (cboDia.Text == "Miercoles")
            {
                modificado.Dia1 = "MI";
            }
            if (cboDia.Text == "Jueves")
            {
                modificado.Dia1 = "JU";
            }
            if (cboDia.Text == "Viernes")
            {
                modificado.Dia1 = "VI";
            }
            if (cboDia.Text == "Sabado")
            {
                modificado.Dia1 = "SA";
            }
            if (cboDia.Text == "Domingo")
            {
                modificado.Dia1 = "DO";
            }
            modificado.IdHorario= Convert.ToInt32( txbHorario.Text);
            //modificado.Dia1 = cboDia.Text;
            modificado.Inicio = TimeSpan.Parse(cboInicio1.Text + ":" + cboInicio2.Text);
            modificado.Fin = TimeSpan.Parse(cboFin1.Text + ":" + cboFin2.Text);
            modificado.Aula = txbAula.Text;
            int resp = modificado.modificar();
            if (resp != 0)
                MessageBox.Show("Elemento modificado Adecuadamente");
            else
                MessageBox.Show("Fallo la modificacion");
            txbHorario.Enabled = true;
            tmiGuardar.Enabled = true;
            tmiModificar.Enabled = false;
            this.tmiEliminar.Enabled = false;
            this.tmiCancelar.Enabled = false;
            this.cargarTabla();
            this.limpiar();

        }

        /* En este metodo cargamos los datos del TmiEliminar para poder eliminar los datos ingresados en la tabla
         *  
         */
        private void pnlBuscar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MHorario eliminado = new MHorario();
            eliminado.IdHorario = Convert.ToInt32(txbHorario.Text);
            eliminado.Dia1 = Convert.ToString(cboDia.Text);
            eliminado.Inicio = TimeSpan.Parse(cboInicio1.Text);
            eliminado.Fin = TimeSpan.Parse(cboFin1.Text);
            eliminado.Aula = Convert.ToString(txbAula.Text);
            DialogResult respuesta = MessageBox.Show("Estas seguro de eliminar " + eliminado.IdHorario, "Eliminado...", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes) {
                int r = eliminado.eliminar();
                if (r != 0)
                {

                    MessageBox.Show("Elemento eliminado correctamente");

                }
                else
                    MessageBox.Show("Elemento no eliminado");

            
            }

            this.tmiGuardar.Enabled = true;
            this.tmiModificar.Enabled = false;
            this.tmiEliminar.Enabled = false;
            this.tmiCancelar.Enabled = false;
            this.limpiar();
            this.cargarTabla();

        }

        /* En este metodo te permite cancelar la tabla cuando ya no quieres ingresar datos
         *  
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


        /* Este metodo cambia el color y el numero de la columna 
         *  
         */
        private void dgvHora_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvHora.Columns[indiceColumna].DefaultCellStyle.BackColor =Color.White;
            indiceColumna = Convert.ToInt16(e.ColumnIndex);
            dgvHora.Columns[indiceColumna].DefaultCellStyle.BackColor = Color.SteelBlue;

        }

        /* Este metodo es para filtrar los datos de la clase filtro
         *  
         */
        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {
            String filtroPor = dgvHora.Columns[indiceColumna].Name;
            if (txbBusqueda.Text != string.Empty) { 
            DataView view = CFiltroDatos.filtroDatos(filtro, filtroPor, txbBusqueda.Text);
                dgvHora.DataSource = view;

            }
            else
            {

                this.cargarTabla();
            }

            dgvHora.AutoResizeColumns();
        }

        /* Este metodo te permite buscar los datos haciendo click en el boton 
         *   
         */
        private void btnBusca_Click(object sender, EventArgs e)
        {
            BuscaHorario cuadro = new BuscaHorario();
            cuadro.ShowDialog(this);
            MHorario leido = cuadro.Elegido;

            if (leido != null){


                txbHorario.Text = (leido.IdHorario.ToString());
                cboDia.Text = leido.Dia1;
                cboInicio1.Text = (leido.Inicio.ToString());
                cboFin1.Text = (leido.Fin.ToString());
                txbAula.Text = leido.Aula;
            }
           

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txbHorario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboInicio2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboFin2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboInicio1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         




    }
}
