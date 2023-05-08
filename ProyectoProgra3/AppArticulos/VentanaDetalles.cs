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
        private List<Imagen> imagenes = null;
        int imgActual = 1 ;
        int cantImg;

        public VentanaDetalles(Articulo articulo)
        {
            art = articulo;   
            InitializeComponent();
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbImagenes.Load(imagen);
            }
            catch (Exception ex)
            {

                pbImagenes.Load("https://media.istockphoto.com/vectors/thumbnail-image-vector-graphic-vector-id1147544807?k=20&m=1147544807&s=612x612&w=0&h=pBhz1dkwsCMq37Udtp9sfxbjaMl27JUapoyYpQm0anc=");
            }
        }

        private void VentanaDetalles_Load(object sender, EventArgs e)
        {
            MarcaDatos md = new MarcaDatos();
            CategoriaDatos cd = new CategoriaDatos();
            ImagenesDatos id = new ImagenesDatos();

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

                imagenes = id.Buscar("IdArticulo", art.Id.ToString());

                if(imagenes != null)
                {
                    cantImg = imagenes.Count();
                    CargarImagen(imagenes[imgActual].ImagenUrl);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
