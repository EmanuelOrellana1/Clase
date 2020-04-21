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

namespace Clase.Vista
{
    public partial class frmROLES : Form
    {
        public frmROLES()
        {
            InitializeComponent();
        }

        private void frmROLES_Load(object sender, EventArgs e)
        {
            using (sistema_ventaEntities2 bd = new sistema_ventaEntities2())
            {
                var Jointablas = from tbusua in bd.tb_usuarios
                                 from rolesusuarios in bd.roles_usuarios
                                 where tbusua.Id == rolesusuarios.id_Rol_Usuarios


                                 select new
                                 {
                                     Id = tbusua.Id,
                                     Email = tbusua.Email,
                                     Tipo_rol = rolesusuarios.tipo_rol
                                 };


                dtVistaRoles.DataSource = Jointablas.ToList();
            }
        }

        private void dtVistaRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
