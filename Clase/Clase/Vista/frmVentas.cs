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
                txtNumeroVenta.Text = "1";
                foreach (var iterardatosTbVenta in tb_Ventas)
                {
                    int idVenta = iterardatosTbVenta.idVenta;
                    int suma = idVenta + 1;
                    txtNumeroVenta.Text = suma.ToString();

                    //dtvUsuarios.Rows.Add(iterardatosTbUsuarios.Email, iterardatosTbUsuarios.Contrasena);
                }


            }
        }

        public void CargarComobo()
        {
            using (sistema_ventaEntities2 bd = new sistema_ventaEntities2())
            {

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
                calculo();
            }
            catch (Exception ex)
            {

            }
            dtvVenta.Rows.Add(txtCodigoProd.Text, txtNombreProd.Text, txtPrecioProd.Text, txtCantidad.Text, txtTotal.Text);
            double suma = 0;
            for (int i = 0; i < dtvVenta.RowCount; i++)
            {
                string DatosaOperar = dtvVenta.Rows[i].Cells[4].Value.ToString();
                double DatosConvertidos = Convert.ToDouble(DatosaOperar);

                //suma = suma + DatosConvertidos;
                suma += DatosConvertidos;

                txtTOTALF.Text = suma.ToString();

            }

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
                txtCantidad.Text = "1";
                
                txtCantidad.Select();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (sistema_ventaEntities2 db = new sistema_ventaEntities2())
            {
                tb_venta tv_v = new tb_venta();
                string comboTipoDocumento = cmbTipoDocumento.SelectedValue.ToString();
                string comboCliente = cmbCliente.SelectedValue.ToString();
                tv_v.idDocumento = Convert.ToInt32(comboTipoDocumento);
                tv_v.iDCliente = Convert.ToInt32(comboCliente);
                tv_v.iDUsuario = 1;
                tv_v.totalVenta = Convert.ToDecimal(txtTOTALF.Text);
                tv_v.fecha = Convert.ToDateTime(dtpFecha.Text);

                db.tb_venta.Add(tv_v);
                db.SaveChanges();


                detalleVenta dete = new detalleVenta();
                for (int i = 0; i < dtvVenta.RowCount; i++)
                {
                    string idProducto = dtvVenta.Rows[i].Cells[0].Value.ToString();
                    int idProductosConvertidos = Convert.ToInt32(idProducto);

                    string cantidad = dtvVenta.Rows[i].Cells[3].Value.ToString();
                    int CantidadConvertidos = Convert.ToInt32(cantidad);

                    string precio = dtvVenta.Rows[i].Cells[2].Value.ToString();
                    decimal PrecioConvertidos = Convert.ToDecimal(precio);

                    string total = dtvVenta.Rows[i].Cells[4].Value.ToString();
                    decimal TotalConvertidos = Convert.ToDecimal(total);

                    dete.idVenta = Convert.ToInt32(txtNumeroVenta.Text);
                    dete.idProducto = idProductosConvertidos;
                    dete.cantidad = CantidadConvertidos;
                    dete.precio = PrecioConvertidos;
                    dete.total = TotalConvertidos;
                    db.detalleVenta.Add(dete);
                    db.SaveChanges();

                }
            }
            
            retornoid();
            dtvVenta.Rows.Clear();
            txtTOTALF.Text = "";
        }

        private void txtBuscarProd_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBuscarProd.Text == "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnBuscar.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                using (sistema_ventaEntities2 bd = new sistema_ventaEntities2())
                {
                    producto pr = new producto();
                    int buscar = int.Parse(txtBuscarProd.Text);
                    pr = bd.producto.Where(idBuscar => idBuscar.idProducto==buscar).First();
                    txtCodigoProd.Text = Convert.ToString(pr.idProducto);
                    txtNombreProd.Text = Convert.ToString(pr.nombreProducto);
                    txtPrecioProd.Text = Convert.ToString(pr.precioProducto);
                    txtCantidad.Focus();
                    txtBuscarProd.Text = "";
                    intentos = 2;
                }
            }
        }

        int intentos = 1;
        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               if(intentos == 2)
                {
                    btnAgregar.PerformClick();
                    txtCodigoProd.Text = "";
                    txtNombreProd.Text = "";
                    txtPrecioProd.Text = "";
                    txtTotal.Text = "";
                    intentos = 0;
                    txtCantidad.Text = "1";
                    txtBuscarProd.Focus();
                }
                intentos += 1;
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
