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
            selectCategorias();
            limpiarCampos();
        }

        public void selectCategorias()
        {
            dgvListaCateg.Rows.Clear();
            using (petShopEntities db = new petShopEntities())
            {
                List<categorias> listaCategorías = (from c in db.categorias
                                                    select c).ToList();

                foreach (var c in listaCategorías)
                {
                    dgvListaCateg.Rows.Add(c.idCategoria, c.nombre);
                }
            }
        }

        void limpiarCampos()
        {
            lblIdCateg.Text = "";
            txtNombreCateg.Text = "";

            txtNombreCateg.Enabled = false;
            btnGuardarNuevaCateg.Enabled = false;
            btnGuardarCambiosCateg.Enabled = false;
            btnEditarCateg.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevaCateg.Enabled = true;

            btnGuardarNuevaCateg.BackColor = Color.Gray;
            btnGuardarCambiosCateg.BackColor = Color.Gray;
            btnEditarCateg.BackColor = Color.Gray;
            btnCancelar.BackColor = Color.Gray;
            btnNuevaCateg.BackColor = Color.Lime;
        }

        private void dgvListaCategorías_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdCateg.Text = dgvListaCateg.CurrentRow.Cells[0].Value.ToString();
            txtNombreCateg.Text = dgvListaCateg.CurrentRow.Cells[1].Value.ToString();

            btnNuevaCateg.Enabled = false;
            btnNuevaCateg.BackColor = Color.Gray;
            btnEditarCateg.Enabled = true;
            btnEditarCateg.BackColor = Color.Orange;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevaCateg_Click(object sender, EventArgs e)
        {
            txtNombreCateg.Enabled = true;
            btnGuardarNuevaCateg.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardarNuevaCateg.BackColor = Color.Lime;
            btnNuevaCateg.BackColor = Color.Gray;
            btnCancelar.BackColor = Color.Red;
        }

        private void btnGuardarNuevaCateg_Click(object sender, EventArgs e)
        {
            using (petShopEntities db = new petShopEntities())
            {
                categorias categoriaNueva = new categorias();
                categoriaNueva.nombre = txtNombreCateg.Text;

                db.categorias.Add(categoriaNueva);
                db.SaveChanges();
            }

            limpiarCampos();
            selectCategorias();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnEditarCateg_Click(object sender, EventArgs e)
        {
            txtNombreCateg.Enabled = true;
            btnGuardarCambiosCateg.Enabled = true;
            btnCancelar.Enabled = true;

            btnEditarCateg.BackColor = Color.Gray;
            btnGuardarCambiosCateg.BackColor = Color.Lime;
            btnCancelar.BackColor = Color.Red;
        }

        private void btnGuardarCambiosCateg_Click(object sender, EventArgs e)
        {
            using (petShopEntities db = new petShopEntities())
            {
                categorias categoriaEditada = new categorias();
                categoriaEditada.nombre = txtNombreCateg.Text;

                db.Entry(categoriaEditada);
                db.SaveChanges();
            }

            limpiarCampos();
            selectCategorias();
        }
    }
}
