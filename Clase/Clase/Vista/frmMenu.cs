using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase.Vista
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void rOLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmROLES rol = new frmROLES();
            rol.MdiParent = this;
            rol.Show();
        }

        private void uSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usu = new frmUsuarios();
            usu.MdiParent = this;
            usu.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas ven = new frmVentas();
            ven.MdiParent = this;
            ven.Show();
        }
    }
}
