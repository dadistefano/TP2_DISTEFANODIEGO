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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            ListarArticulos la = new ListarArticulos();
            la.Visible = true;
            this.Dispose(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaArticulo alta = new AltaArticulo();
            alta.ShowDialog();
        }

        private void btBuscarArticulo_Click(object sender, EventArgs e)
        {
            BuscarArticulo ba = new BuscarArticulo();
            ba.Visible = true;
            this.Dispose(false);
        }

        private void btDetalleArticulo_Click(object sender, EventArgs e)
        {
            DetalleArticulo da = new DetalleArticulo();
            da.Visible = true;
            this.Dispose(false);
        }

        private void btModificarArticulo_Click(object sender, EventArgs e)
        {
            ListarArticulos la = new ListarArticulos();
            la.Visible = true;
            this.Dispose(false);
        }

        private void btEliminarArt_Click(object sender, EventArgs e)
        {
            ListarArticulos la = new ListarArticulos();
            la.Visible = true;
            this.Dispose(false);
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
