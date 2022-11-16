using petShop.Helpers;
using petShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectUsuarios();
        }

        private void selectUsuarios()
        {
            using (petShopEntities db = new petShopEntities())
            {
                dgvListaUsuarios.DataSource = db.productos.ToList();
            }
        }

        private void btnAddNormal_Click(object sender, EventArgs e)
        {
            using (petShopEntities db = new petShopEntities())
            {
                usuarios user = new usuarios();
                user.nombre = "Raquel";
                user.correo = "raquel@correo.com";
                user.pass = "12345";
                user.rol = 1;

                db.usuarios.Add(user);
                db.SaveChanges();

                selectUsuarios();
            }
        }

        private void btnAddEncrypt_Click(object sender, EventArgs e)
        {
            using (petShopEntities db = new petShopEntities())
            {
                usuarios user = new usuarios();
                user.nombre = "Diaz";
                user.correo = "diaz@correo.com";
                user.pass = Encrypt.GetSHA256("54321");
                user.rol = 0;

                db.usuarios.Add(user);
                db.SaveChanges();

                selectUsuarios();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (petShopEntities db = new petShopEntities())
            {
                string correo = "victor@correo.com";
                string pass = "unabASDASfbhasdñklahasdkasd12312dsfert#@1";

                string passEncrypt = Encrypt.GetSHA256(pass);

                var loginUser = (from u in db.usuarios
                                 where u.correo == correo && u.pass == passEncrypt
                                 select u).FirstOrDefault();

                if (loginUser != null) MessageBox.Show("Usuario encontrado: " + loginUser.nombre,
                    "Usuario encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Falló con éxito",
                    "Usuario NO encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
