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
using Clase.Vista;



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
            filtro();
        }
        void filtro()
        {
            using (sistema_ventaEntities2 bd = new sistema_ventaEntities2())
            {
                String nombre = txtBuscar.Text;

                var buscarprod = from tbprod in bd.producto

                                 where tbprod.nombreProducto.Contains(nombre)


                                 select new
                                 {
                                     Id = tbprod.idProducto,
                                     Nombre = tbprod.nombreProducto,
                                     Precio = tbprod.precioProducto
                                 };


                dtgProducto.DataSource = buscarprod.ToList();

            }
        }
  
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void dtgProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            envio();
        }

        void envio()
        {
            String Id = dtgProducto.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgProducto.CurrentRow.Cells[1].Value.ToString();
            String Precio = dtgProducto.CurrentRow.Cells[2].Value.ToString();


            frmMenu.ven.txtCodigoProd.Text = Id;
            frmMenu.ven.txtNombreProd.Text = Nombre;
            frmMenu.ven.txtPrecioProd.Text = Precio;

            frmMenu.ven.txtCantidad.Focus();
            this.Close();
        }

        private void dtgProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                envio();
            }
        }
    }
}
