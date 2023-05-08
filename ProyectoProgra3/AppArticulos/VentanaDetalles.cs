using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using Conexiones;

namespace AppArticulos
{
    public partial class VentanaDetalles : Form
    {
        Articulo art = null;
        public VentanaDetalles(Articulo articulo)
        {
            art = articulo;   
            InitializeComponent();
        }

        private void VentanaDetalles_Load(object sender, EventArgs e)
        {
            MarcaDatos md = new MarcaDatos();
            CategoriaDatos cd = new CategoriaDatos();

            try
            {
                gbDatos.Text += art.Codigo;
                txbNombre.Text = art.Nombre;

                Marca marca = md.Buscar("Id", art.IdMarca.ToString());
                txbMarca.Text = marca.ToString();
                Categoria categoria = cd.Buscar("Id", art.IdCategoria.ToString());
                txbCategoria.Text = categoria.ToString();

                txbPrecio.Text += art.Precio.ToString();

                rtxbDescripcion.Text = art.Descripcion.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
