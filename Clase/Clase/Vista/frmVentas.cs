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
    }
}
