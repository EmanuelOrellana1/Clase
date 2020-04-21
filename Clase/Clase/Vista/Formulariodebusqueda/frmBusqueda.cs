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

namespace Clase.Vista.Formulariodebusqueda
{
    public partial class frmBusqueda : Form
    {
        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            cargar(); 
        }

        void cargar()
        {
            using (sistema_ventaEntities2 bd = new sistema_ventaEntities2())
            {
                var Jointablas = from tbprod in bd.producto
                                 



                                 select new
                                 {
                                     Id = tbprod.idProducto,
                                     Email = tbprod.nombreProducto,
                                     Precio = tbprod.precioProducto
                                 };


                dtgProducto.DataSource = Jointablas.ToList();
            }
        }

        public String Id;
        public String Nombre;
        public String Precio;
        private void dtgProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id= dtgProducto.CurrentRow.Cells[0].Value.ToString();
            Nombre = dtgProducto.CurrentRow.Cells[1].Value.ToString();
            Precio = dtgProducto.CurrentRow.Cells[2].Value.ToString();
            
        }
    }
}
