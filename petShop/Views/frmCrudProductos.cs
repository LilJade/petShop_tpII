using petShop.Clases;
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
    public partial class frmCrudProductos : Form
    {
        public frmCrudProductos()
        {
            InitializeComponent();
        }

        private void frmCrudProductos_Load(object sender, EventArgs e)
        {
            verProductos();
            colorDataGridView();
        }


        public void verProductos()
        {

            try
            {
                dgvProductos.Rows.Clear();

                using (petShopEntities db = new petShopEntities())

                {
                    var query = from p in db.productos

                                select new
                                {
                                    idProducto = p.idProducto,
                                    nombre = p.nombre,
                                    descripcion = p.descripcion,
                                    stock = p.stock,
                                    precio = p.precio,
                                    estado = p.estado,
                                    categorias = p.categorias

                                };




                    foreach (var d in query)
                    {
                        String estado;

                        if (d.estado == 1)
                        {
                            estado = "Activo";
                        }
                        else
                        {
                            estado = "Inactivo";
                        }
                        dgvProductos.Rows.Add(d.idProducto, d.nombre, d.descripcion, d.stock, d.precio, estado, d.categorias.nombre);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            verProductos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "Agregar")
            {
                frmAgregarProductos add = new frmAgregarProductos();
                add.ShowDialog();

            }

            int id;

            if (dgvProductos.Columns[e.ColumnIndex].Name == "Editar")
            {

                id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Id"].Value.ToString());
                frmEditarProductos edit = new frmEditarProductos(id);
                edit.ShowDialog();

            }


        }

        private void colorDataGridView()
        {
            dgvColor.Formato(dgvProductos, 2);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvProductos.CurrentCell = null;

                foreach (DataGridViewRow r in dgvProductos.Rows)
                {
                    r.Visible = false;
                }

                foreach (DataGridViewRow r in dgvProductos.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtBuscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                verProductos();
            }
        }
    }
}
