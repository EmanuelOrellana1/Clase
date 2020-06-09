using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase.Model;
using Clase.Reportes;

namespace Clase.ConsultasRpt
{
    public partial class frmrptProductos : Form
    {
        public frmrptProductos()
        {
            InitializeComponent();
        }

        private void frmrptProductos_Load(object sender, EventArgs e)
        {
            using(sistema_ventaEntities2 db = new sistema_ventaEntities2())
            {
                rptProductos rptpr = new rptProductos();
                rptpr.SetDataSource(db.producto.ToList());
                crproductos.ReportSource = rptpr;
            }
        }
    }
}
