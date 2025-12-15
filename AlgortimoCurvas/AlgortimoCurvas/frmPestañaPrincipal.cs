using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgortimoCurvas
{
    public partial class frmPestañaPrincipal : Form
    {
        public frmPestañaPrincipal()
        {
            InitializeComponent();
        }

        private void curvasBézierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurvaBezier frm= new frmCurvaBezier();
            frm.MdiParent = this;
            frm.Show();

        }

        private void curvaBSplineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurvaB_Spline frm = new frmCurvaB_Spline();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
