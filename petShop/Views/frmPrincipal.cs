using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using petShop.Models;

namespace petShop.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal(usuarios user)
        {
            InitializeComponent();
            lblNombreUsuario.Text = user.nombre.ToUpper();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        productos productoBuscado = new productos();
        private void txtBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                using (petShopEntities db = new petShopEntities())
                {
                    int idProducto = int.Parse(txtBuscador.Text);
                    productoBuscado = db.productos
                        .Where(p => p.idProducto == idProducto)
                        .FirstOrDefault();
                }

                if (productoBuscado != null)
                {
                    lblIdProducto.Text = productoBuscado.idProducto.ToString();
                    lblNombreProducto.Text = productoBuscado.nombre;
                    lblStockProducto.Text = productoBuscado.stock.ToString();
                    lblPrecioProducto.Text = productoBuscado.precio.ToString();
                }
                else
                {
                    MessageBox.Show(
                        "Este producto no existe", 
                        "Producto no encontrado", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarDetalleVenta();
        }

        public void AgregarDetalleVenta()
        {
            dgvDetalleVentas.Rows.Add(
                productoBuscado.idProducto, 
                productoBuscado.nombre, 
                productoBuscado.precio, 
                txtCantidad.Text, 
                (productoBuscado.precio * int.Parse(txtCantidad.Text))
                );

            decimal total;
            decimal nuevoTotal = 0;

            for (int fila = 0; fila < dgvDetalleVentas.Rows.Count - 1; fila++)
            {
                string valor = dgvDetalleVentas.Rows[fila].Cells[4].Value.ToString();
                total = decimal.Parse(valor);

                nuevoTotal += total;

            }

            lblTotalVenta.Text = nuevoTotal.ToString();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            using (petShopEntities db = new petShopEntities())
            {
                ventas venta = new ventas();
                venta.fecha = DateTime.Now;
                venta.total = decimal.Parse(lblTotalVenta.Text);

                for (int fila = 0; fila < dgvDetalleVentas.Rows.Count - 1; fila++)
                {
                    venta.detalleVentas.Add
                        (
                            new detalleVentas
                            (
                                int.Parse(dgvDetalleVentas.Rows[fila].Cells[3].Value.ToString()),
                                decimal.Parse(dgvDetalleVentas.Rows[fila].Cells[4].Value.ToString()),
                                int.Parse(dgvDetalleVentas.Rows[fila].Cells[0].Value.ToString()),
                                venta.idVenta
                            )
                        );

                    db.ventas.Add(venta);
                }

                db.SaveChanges();

                foreach (var item in venta.detalleVentas)
                {
                    productos producto = new productos();
                    producto.idProducto = item.idProducto;

                    producto = db.productos.Where(p => p.idProducto == producto.idProducto).FirstOrDefault();

                    producto.stock = (producto.stock - item.cantidad);

                    db.Entry(producto);
                    db.SaveChanges();
                }
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }
    }
}
