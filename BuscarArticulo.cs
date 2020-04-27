using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_DIEGO_DISTEFANO
{
    public partial class BuscarArticulo : Form
    {
        public BuscarArticulo()
        {
            InitializeComponent();
        }
        public void BuscarCod()
        {
            try
            {
                // Buscar codigo
                string CodBusqueda = txBuscarCodigo.Text.Trim();

                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                List<Articulo> resultados = articuloNegocio.BuscarArticuloXcodigo(CodBusqueda);
                if (resultados.Count <= 0)
                {
                    dgvBuscar.DataSource = null;
                    MessageBox.Show("No hay Articulos con ese CODIGO", "ATENCION");
                }
                else
                {
                    dgvBuscar.DataSource = resultados;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void BuscarMarca()
        {
            try
            {
                // Buscamos articulos
                string MarcBusqueda = txBuscarMarca.Text.Trim();

                ArticuloNegocio artNegocio = new ArticuloNegocio();
                List<Articulo> result = artNegocio.BuscarArticuloXmarca(MarcBusqueda);
                if (result.Count <= 0)
                {
                    dgvBuscar.DataSource = null;
                    MessageBox.Show("No hay Articulos con esa MARCA", "ATENCION");
                }
                else
                {
                    dgvBuscar.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void BuscarCategoria()
        {
            try
            {
                // Buscamos articulos
                string CatBusqueda = txBuscarCategoria.Text.Trim();

                ArticuloNegocio artNegocio = new ArticuloNegocio();
                List<Articulo> result = artNegocio.BuscarArticuloXcategoria(CatBusqueda);
                if (result.Count <= 0)
                {
                    dgvBuscar.DataSource = null;
                    MessageBox.Show("No hay Articulos con esa MARCA", "ATENCION");
                }
                else
                {
                    dgvBuscar.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btBuscarXCodigo_Click(object sender, EventArgs e)
        {
            BuscarCod();
            txBuscarCodigo.Clear();
            txBuscarMarca.Clear();
            txBuscarCategoria.Clear();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Visible = true;
            this.Dispose(false);
        }

        private void BuscarArticulo_Load(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarMarca();
            txBuscarCodigo.Clear();
            txBuscarMarca.Clear();
            txBuscarCategoria.Clear();
        }

        private void btBuscarCategoria_Click(object sender, EventArgs e)
        {
            BuscarCategoria();
            txBuscarCodigo.Clear();
            txBuscarMarca.Clear();
            txBuscarCategoria.Clear();
        }
    }
}
