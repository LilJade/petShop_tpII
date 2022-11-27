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
    public partial class frmCategoriaCrud : Form
    {
        public frmCategoriaCrud()
        {
            InitializeComponent();

            selectProductos();
            
        }

        public void selectProductos()
        {
            //LIMPIAR FILAS DE UN DATAGRIDVIEW
            dgvLista.Rows.Clear();

            using (petShopEntities db = new petShopEntities())
            {
                List<productos> lista = db.productos.ToList();

                foreach (var item in lista)
                {
                    string estadoActual = "";
                    if (item.estado == 0)
                    {
                        estadoActual = "INACTIVO";
                    }
                    if (item.estado == 1)
                    {
                        estadoActual = "ACTIVO";
                    }
                    dgvLista.Rows.Add(item.idProducto, item.nombre, estadoActual
                );
                }
            }
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdProd.Text = dgvLista.CurrentRow.Cells[0].Value.ToString();
            txtNombreProd.Text = dgvLista.CurrentRow.Cells[1].Value.ToString();
            txtEstadoProd.Text = dgvLista.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnActivarProd_Click(object sender, EventArgs e)
        {
            using (petShopEntities db = new petShopEntities())
            {
                int idProducto = int.Parse(txtIdProd.Text);
                productos prodActivar = (from p in db.productos
                                         where p.idProducto == idProducto
                                         select p).FirstOrDefault();

                prodActivar.estado = 1;

                db.Entry(prodActivar);
                db.SaveChanges();
            }

            txtIdProd.Text = "";
            txtNombreProd.Text = "";
            txtEstadoProd.Text = "";
            selectProductos();
        }

        private void btnDesactivarProd_Click(object sender, EventArgs e)
        {
            using (petShopEntities db = new petShopEntities())
            {
                int idProducto = int.Parse(txtIdProd.Text);
                productos prodActivar = (from p in db.productos
                                         where p.idProducto == idProducto
                                         select p).FirstOrDefault();

                prodActivar.estado = 0;

                db.Entry(prodActivar);
                db.SaveChanges();
            }

            txtIdProd.Text = "";
            txtNombreProd.Text = "";
            txtEstadoProd.Text = "";
            selectProductos();
        }
    }
}

/*using (petShopEntities db = new petShopEntities())
            {
                List<productos> lista = (from p in db.productos
                                         where p.estado == 1
                                         select p).ToList();

                foreach (var item in lista)
                {
                    string estadoActual = "";
                    if (item.estado == 0)
                    {
                        estadoActual = "INACTIVO";
                    }
                    if (item.estado == 1)
                    {
                        estadoActual = "ACTIVO";
                    }
                    dgvLista2.Rows.Add(item.idProducto, item.nombre, item.precio, estadoActual
                );
                }
            }*/

