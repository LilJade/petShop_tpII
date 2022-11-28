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
    public partial class frmAgregarProductos : Form
    {
        public frmAgregarProductos()
        {
            InitializeComponent();
        }

        private void frmAgregarProductos_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }


        private void cargarCategorias()
        {
            using (petShopEntities db = new petShopEntities())
            {
                cbxCategoria.DataSource = db.categorias.Where(c => c.idCategoria == c.idCategoria).OrderBy(c => c.nombre).ToList();

                cbxCategoria.DisplayMember = "nombre";

                cbxCategoria.ValueMember = "idCategoria";
            }
        }


        private void insertarProducto()
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            int stock = int.Parse(txtStock.Text);
            decimal precio = decimal.Parse(txtPrecio.Text);
            int estado = int.Parse(txtEstado.Text);
            int categoria = Convert.ToInt32(cbxCategoria.SelectedValue);


            try
            {

                using (petShopEntities insert = new petShopEntities())
                {

                    productos p = new productos
                    {

                        nombre = nombre,
                        descripcion = descripcion,
                        stock = stock,
                        precio = precio,
                        estado = estado,
                        idCategoria = categoria


                    };

                    insert.productos.Add(p);
                    insert.SaveChanges();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            insertarProducto(); 
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
