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
            rol.Show();
        }

        private void uSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usu = new frmUsuarios();
            usu.Show();
        }
    }
}
