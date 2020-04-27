using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TP2_DIEGO_DISTEFANO
{
    public partial class AltaArticulo : Form
    {
        public Articulo articulo = null;
        public AltaArticulo()
        {
            InitializeComponent();
        }
        public AltaArticulo(Articulo Art)
        {
            InitializeComponent();
            articulo = Art;
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void AltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio Marca = new MarcaNegocio();
            CategoriaNegocio Categoria = new CategoriaNegocio();


            try
            {
                cbMarca.DataSource = Marca.listar();
                cbMarca.DisplayMember = "descripcion";
                cbMarca.ValueMember = "id";
                
                cbCategoria.DataSource = Categoria.listar();
                cbCategoria.DisplayMember = "descripcion";
                cbCategoria.ValueMember = "id";

                if (articulo != null)
                {
                    txtNombre.Text = articulo.nombre;
                    cbMarca.SelectedValue = articulo.marca.id; //ver
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void brAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.cod = txtCod.Text;
                articulo.nombre = txtNombre.Text.Trim();
                articulo.descripcion = txtDescripcion.Text.Trim();
                articulo.marca = (Marca)cbMarca.SelectedItem;
                articulo.categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.imagenUrl = txtImagenURL.Text.Trim();
                articulo.precio = double.Parse(txtPrecio.Text);


                if (articulo.cod == null)
                    negocio.agregar(articulo);
                else
                    negocio.modificar(articulo);
     
                Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
