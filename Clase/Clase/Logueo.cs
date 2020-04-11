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

namespace Clase
{
    public partial class Logueo : Form
    {
        public Logueo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (sistema_ventaEntities db = new sistema_ventaEntities())
            {

                var lista = from usuario in db.tb_usuarios
                            where usuario.Email == txtUsuario.Text
                            && usuario.Contrasena == txtContraseña.Text
                            select usuario;

                if (lista.Count() > 0)
                {
                   frmMenu menu = new frmMenu();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("El usuario no existe");

                }
            }
        }
    }
}
