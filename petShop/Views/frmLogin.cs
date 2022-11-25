using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using petShop.Helpers;
using petShop.Models;

namespace petShop.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private int x = 0, y = 0;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void loguearUsuario()
        {
            usuarios usuarioLogin = new usuarios();
            usuarioLogin.correo = txtCorreo.Text;
            usuarioLogin.pass = txtPass.Text;
            string passEncriptada = Encrypt.GetSHA256(usuarioLogin.pass);

            using (petShopEntities db = new petShopEntities())
            {
                usuarioLogin = (from u in db.usuarios
                                where u.correo == usuarioLogin.correo && u.pass == passEncriptada
                                select u).FirstOrDefault();

                if (usuarioLogin != null)
                {
                    frmPrincipal frm = new frmPrincipal(usuarioLogin);
                    frm.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Falló con éxito",
                    "Usuario NO encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            loguearUsuario();
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtCorreo.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show(
                        "Asegurese de ingresar su correo y su contraseña!",
                        "Aún faltan datos..",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                }
                else
                {
                    loguearUsuario();
                }
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtCorreo.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show(
                        "Asegurese de ingresar su correo y su contraseña!",
                        "Aún faltan datos..",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                }
                else
                {
                    loguearUsuario();
                }
            }
        }

        private void panelMover_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
            else
            {
                this.Left = this.Left + (e.X - x);
                this.Top = this.Top + (e.Y - y);
            }
        }
    }
}
