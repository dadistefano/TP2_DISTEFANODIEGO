using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TP2_DIEGO_DISTEFANO
{
    public partial class ListarArticulos : Form
    {
        public ListarArticulos()
        {
            InitializeComponent();
           

        }

        private void ListarArticulos_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        public void cargarGrilla() //por el tema del actualizar
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                dgvListadoArticulos.DataSource = negocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            Articulo modif = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
            AltaArticulo alta = new AltaArticulo(modif);
            alta.ShowDialog();
            cargarGrilla();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            Articulo artBaja = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
            
            DialogResult elección = MessageBox.Show("¿Desea eliminar este artículo?", "Atención", MessageBoxButtons.OKCancel);
            if (elección == DialogResult.OK)
            {
                ArticuloNegocio articNegocio = new ArticuloNegocio();
                articNegocio.BajaArticulo(artBaja);
                cargarGrilla();
            }
            else
            {
                Dispose();
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Visible = true;
            this.Dispose(false);
        }
    }
}
