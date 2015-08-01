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

namespace Escuela.Vista
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.cargaCombo();
            this.cargaTabla();
        }
        private void cargaCombo() {
            cboDocente.DataSource = new MDocente().listarTodos();
            cboDocente.ValueMember = "IdDocente";
            cboDocente.DisplayMember = "Nombre";

            cbocDocente.DataSource = new MDocente().listarTodos();
            cbocDocente.ValueMember = "IdDocente";
            cbocDocente.DisplayMember = "Nombre";
        }
        private void cargaTabla() {
          
            List<MUsuario> datos = new MUsuario().listarTodos();
            dgvUsuario.RowCount = datos.Count;
            int i = 0;
            foreach (MUsuario leido in datos)
            {            
                dgvUsuario[0,i].Value = leido.Idusuario;
                dgvUsuario[1,i].Value = leido.FkIdDocente;
                dgvUsuario[2,i].Value = leido.Rol;
                dgvUsuario[3,i].Value = leido.Contrasena;
                i++;
            }
            dgvUsuario.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvUsuario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvUsuario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvUsuario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            

        
        }


        private void tmiGuardar_Click(object sender, EventArgs e)
        {
            MUsuario nuevo = new MUsuario();
            nuevo.Idusuario = txbIdusuario.Text.Trim();
            if (nuevo.Idusuario.Length > 50)
                nuevo.Idusuario.Substring(0, 49);
            nuevo.FkIdDocente = Convert.ToInt32(cboDocente.SelectedValue.ToString());
            nuevo.Rol = cboRol.SelectedItem.ToString();
            nuevo.Contrasena = txbContrasenia.Text;
            int resp = nuevo.guardar();
            if (resp != 0)
                MessageBox.Show("Usuario insertado adecuadamente");
            else
                MessageBox.Show("Falló la inserción del nuevo usuario");

        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tmiModificar_Click(object sender, EventArgs e)
        {

        }

    }
}
