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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        tb_usuarios user = new tb_usuarios();

        void cargardatos()
        {
            using (sistema_ventaEntities2 db = new sistema_ventaEntities2())
            {

                var tb_usuarios = db.tb_usuarios;
                foreach (var iterardatosTbUsuarios in tb_usuarios)
                {
                    dtvUsuarios.Rows.Add(iterardatosTbUsuarios.Email, iterardatosTbUsuarios.Contrasena);
                }

                //dtvUsuarios.DataSource = db.tb_usuarios.ToList();
            }
        }
        void limpiardatos()
        {
            txtUsuario.Text= "";
            txtContraseña.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (sistema_ventaEntities2 db = new sistema_ventaEntities2())
            {


                user.Email = txtUsuario.Text;
                user.Contrasena = txtContraseña.Text;

                db.tb_usuarios.Add(user);
                db.SaveChanges();
            }
            cargardatos();
            cargardatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (sistema_ventaEntities2 db = new sistema_ventaEntities2())
            {
                String Id = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();

                user = db.tb_usuarios.Find(int.Parse(Id));
                db.tb_usuarios.Remove(user);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (sistema_ventaEntities2 db = new sistema_ventaEntities2())
            {
                String Id = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();
                int idC = int.Parse(Id);
                user = db.tb_usuarios.Where(VerificarId => VerificarId.Id == idC).First();
                user.Email = txtUsuario.Text;
                user.Contrasena = txtContraseña.Text;
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            cargardatos();
            limpiardatos();
        }

        private void dtvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Email = dtvUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Contra = dtvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtUsuario.Text = Email;
            txtContraseña.Text = Contra;

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            cargardatos();
        }
    }
}
