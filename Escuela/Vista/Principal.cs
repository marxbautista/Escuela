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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumno alu = new FrmAlumno();
            alu.MdiParent = this;
            alu.Show();
        }

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCarrera mat = new FrmCarrera();
            mat.MdiParent = this;
            mat.Show();
        }

        private void tipoDeReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoReporte tiR = new FrmTipoReporte();
            tiR.MdiParent = this;
            tiR.Show();
        }

        private void horarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHorario hor = new FrmHorario();
            hor.MdiParent = this;
            hor.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMateria mat = new frmMateria();
            mat.MdiParent = this;
            mat.Show();
        }

        private void periodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeriodo2 per = new frmPeriodo2();
            per.MdiParent = this;
            per.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocente doc = new FrmDocente();
            doc.MdiParent = this;
            doc.Show();
        }

        private void indicadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIndicador ind=new FrmIndicador();
            ind.MdiParent = this;
            ind.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario usu = new FrmUsuario();
            usu.MdiParent = this;
            usu.Show();
        }

        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrupo gru = new frmGrupo();
            gru.MdiParent = this;
            gru.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
