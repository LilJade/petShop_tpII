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

namespace petShop.Views
{
    public partial class frmListaProductos : Form
    {
        public frmListaProductos()
        {
            InitializeComponent();
            selectProductosActivos();
        }

        void selectProductosActivos()
        {
            dgvListaProds.Rows.Clear();

            using (petShopEntities db = new petShopEntities())

            {
                var query = from p in db.productos
                            where p.estado == 1
                            select new
                            {
                                idProducto = p.idProducto,
                                nombre = p.nombre,
                                stock = p.stock,
                                precio = p.precio,
                            };




                foreach (var d in query)
                {
                    dgvListaProds.Rows.Add(d.idProducto, d.nombre, d.stock, d.precio);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListaProds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaProds.Columns[e.ColumnIndex].Name == "seleccionar")
            {

                this.Close();
            }
        }

        public productos obtenerProducto()
        {
            productos productoSeleccionado = new productos();

            productoSeleccionado.idProducto = int.Parse(dgvListaProds.CurrentRow.Cells[0].Value.ToString());

            return productoSeleccionado;
        }

        
    }
}
