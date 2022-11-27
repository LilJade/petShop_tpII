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
                //BUSCO EL PRODUCTO EN LA BASE DE DATOS
                //MEDIANTE EL ID QUE EL USUARIO ESCRIBE
                using (petShopEntities db = new petShopEntities())
                {
                    int idProducto = int.Parse(txtBuscador.Text);
                    productoBuscado = db.productos
                        .Where(p => p.idProducto == idProducto)
                        .FirstOrDefault();
                }

                //ME ASEGURO QUE EL RESULTADO DE LA CONSULTA
                //NO SEA == NULL
                if (productoBuscado != null)
                {
                    //SI EL ESTADO DEL PRODUCTO ES IGUAL A 0
                    //ENTONCES EL PRODUCTO ESTÁ DESACTIVADO
                    if (productoBuscado.estado == 0)
                    {
                        MessageBox.Show(
                                "Este producto está agotado en existencias! :/",
                                "Producto AGOTADO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                    //EN CASO CONTRARIO EL PRODUCTO SÍ
                    //ESTÁ DISPONIBLE
                    else
                    {
                        lblIdProducto.Text = productoBuscado.idProducto.ToString();
                        lblNombreProducto.Text = productoBuscado.nombre;
                        lblStockProducto.Text = productoBuscado.stock.ToString();
                        lblPrecioProducto.Text = productoBuscado.precio.ToString();
                    }
                }
                //SI EL RESULTADO DE LA CONSULTA ES
                //IGUAL A NULL MUESTRO QUE ESE ID NO EXISTE
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

        public void AgregarDetalleVenta()
        {
            if (productoExiste(productoBuscado) == false)
            {
                dgvDetalleVentas.Rows.Add(
                                productoBuscado.idProducto,
                                productoBuscado.nombre,
                                productoBuscado.precio,
                                txtCantidad.Text,
                                (productoBuscado.precio * int.Parse(txtCantidad.Text))
                                );

                calcularTotal();

            }
        }

        Boolean productoExiste(productos producto)
        {
            foreach (DataGridViewRow row in dgvDetalleVentas.Rows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());

                if (id == producto.idProducto)
                {
                    int cantidadActual = int.Parse(row.Cells[3].Value.ToString());
                    int nuevaCantidad = int.Parse(txtCantidad.Text) + cantidadActual;
                    row.Cells[3].Value = nuevaCantidad;
                    row.Cells[4].Value = (producto.precio * nuevaCantidad);

                    calcularTotal();

                    return true;
                }
            }

            return false;
        }

        void calcularTotal()
        {
            decimal newTotal = 0;

            foreach (DataGridViewRow row in dgvDetalleVentas.Rows)
            {
                newTotal += decimal.Parse(row.Cells[4].Value.ToString());
            }

            lblTotalVenta.Text = newTotal.ToString();
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

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            AgregarDetalleVenta();
        }
    }
}
