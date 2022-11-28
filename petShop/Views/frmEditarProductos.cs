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
    public partial class frmEditarProductos : Form
    {
        public frmEditarProductos()
        {
            InitializeComponent();
        }

        public frmEditarProductos(int porId)
        {
            InitializeComponent();
            buscarProducto(porId);
        }

        private void frmEditarProductos_Load(object sender, EventArgs e)
        {

        }

        //Metodo para buscar mi producto a editar
        productos editarProducto = new productos();
        private void buscarProducto(int porId)
        {
            try
            {
                using (petShopEntities db = new petShopEntities())
                {
                    editarProducto = db.productos.Where(b => b.idProducto == porId).FirstOrDefault();
                    if (editarProducto != null)
                    {


                        txtNombre.Text = editarProducto.nombre;
                        txtDescripcion.Text = editarProducto.descripcion;
                        txtStock.Text = editarProducto.stock.ToString();
                        txtPrecio.Text = editarProducto.precio.ToString();
                        txtEstado.Text = editarProducto.estado.ToString();
                        cbxCategoria.Text = Convert.ToString(editarProducto.idCategoria);


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Metodo para actualizar el producto
        private void actualizarProducto()
        {


            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            int stock = int.Parse(txtStock.Text);
            decimal precio = decimal.Parse(txtPrecio.Text);
            int estado = int.Parse(txtEstado.Text);
            int categoria = Convert.ToInt32(cbxCategoria.Text);

            using (petShopEntities bd = new petShopEntities())
            {

                productos pro = new productos();

                pro = (from p in bd.productos where p.idProducto == editarProducto.idProducto select p).FirstOrDefault();


                pro.nombre = nombre;
                pro.descripcion = descripcion;
                pro.stock = stock;
                pro.precio = precio;
                pro.estado = estado;
                pro.idCategoria = categoria;

                bd.Entry(pro);
                bd.SaveChanges();

            }


        }

        private void btnProceso_Click(object sender, EventArgs e)
        {
            actualizarProducto();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
