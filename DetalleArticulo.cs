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
    public partial class DetalleArticulo : Form
    {
        public DetalleArticulo()
        {
            InitializeComponent();
        }
        private void DetalleBuscar()
        {
            try
            {
                // Buscamos articulos
                string IdDetalle = txCodigo.Text.Trim();

                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                List<Articulo> resultados = articuloNegocio.DetalleArticulo(IdDetalle);
                if (resultados.Count <= 0)
                {
                    dgvDetalle.DataSource = null;
                    MessageBox.Show("No hay Articulos", "ATENCION");
                }
                else
                {
                    dgvDetalle.DataSource = resultados;
                    Articulo art;
                    art = (Articulo)dgvDetalle.CurrentRow.DataBoundItem;
                    picImagenUrl.Load(art.imagenUrl);
                    //picPoke.Load(poke.ImagenURL);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btBuscarID_Click(object sender, EventArgs e)
        {
            DetalleBuscar();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Visible = true;
            this.Dispose(false);
        }
    }
}
