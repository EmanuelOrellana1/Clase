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
using Clase.Vista.Formulariodebusqueda;

namespace Clase.Vista
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            retornoid();
            CargarComobo();
        }

        public void retornoid()
        {
            using (sistema_ventaEntities2 db = new sistema_ventaEntities2())
            {

                var tb_Ventas = db.tb_venta;
                foreach (var iterardatosTbVenta in tb_Ventas)
                {

                    txtNumeroVenta.Text = iterardatosTbVenta.idVenta.ToString();
                    //dtvUsuarios.Rows.Add(iterardatosTbUsuarios.Email, iterardatosTbUsuarios.Contrasena);
                }

                
            }
        }

        public void CargarComobo()
        {
            using (sistema_ventaEntities2 bd = new sistema_ventaEntities2()) {

                var clientes = bd.tb_cliente.ToList();

                cmbCliente.DataSource = clientes;
                cmbCliente.DisplayMember = "nombreCliente";
                cmbCliente.ValueMember = "iDCliente";


                var tipodoc = bd.tb_documento.ToList();

                cmbTipoDocumento.DataSource = tipodoc;
                cmbTipoDocumento.DisplayMember = "nombreDocumento";
                cmbTipoDocumento.ValueMember = "iDDocumento";

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusqueda busqueda = new frmBusqueda();
            busqueda.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {

            }
            catch (Exception ex)
            {

            }
            dtvVenta.Rows.Add(txtCodigoProd.Text,txtNombreProd.Text,txtPrecioProd.Text,txtCantidad.Text,txtTotal.Text);
            
        }


        private void txtTOTALF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            calculo();

        }

        void calculo()
        {
            try
            {
                double precioProd;
                double cantidad;
                double total;

                precioProd = double.Parse(txtPrecioProd.Text);
                cantidad = Convert.ToDouble(txtCantidad.Text);

                total = precioProd * cantidad;

                txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                txtCantidad.Text = "0";
                MessageBox.Show("No puede operar datos menores a 0");
                txtCantidad.Select();
            }
        }
    }
}
