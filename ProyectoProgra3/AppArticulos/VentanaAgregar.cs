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
    public partial class VentanaAgregar : Form
    {
        private List<Imagen> imagenes = new List<Imagen>();

        private Articulo articulo = null;

        public VentanaAgregar()
        {
            InitializeComponent();
        }

        public VentanaAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar articulo";
        }


        private void CargarImagen(string imagen)
        {
            try
            {
                pbImagen.Load(imagen);
            }
            catch (Exception ex)
            {

                pbImagen.Load("https://media.istockphoto.com/vectors/thumbnail-image-vector-graphic-vector-id1147544807?k=20&m=1147544807&s=612x612&w=0&h=pBhz1dkwsCMq37Udtp9sfxbjaMl27JUapoyYpQm0anc=");
            }
        }

        private void VentanaAgregar_Load(object sender, EventArgs e)
        {

           
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            CategoriaDatos categorias = new CategoriaDatos();
            MarcaDatos marcas = new MarcaDatos();
            ImagenesDatos imgData = new ImagenesDatos();

            try
            {
                cbCategoria.DataSource = categorias.Listar();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";

                cbMarca.DataSource = marcas.Listar();
                cbMarca.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";


                if (articulo != null) 
                {

                    txtNombre.Text = articulo.Nombre;
                    txtCodigoArticulo.Text = articulo.Codigo;
                    rtxtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cbCategoria.SelectedValue = articulo.IdCategoria;
                    cbMarca.SelectedValue = articulo.IdCategoria;
                    //lwImagenes.item = imgData.Buscar("IdArticulo", articulo.Id.ToString());


                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Articulo art = new Articulo();
            DatosDeArticulos dato = new DatosDeArticulos();
            ImagenesDatos imgData = new ImagenesDatos();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                

                Categoria categoria = (Categoria)cbCategoria.SelectedItem;
                Marca marca = (Marca)cbMarca.SelectedItem;
                
                articulo.Nombre = txtNombre.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Descripcion = rtxtDescripcion.Text;
                articulo.Codigo = txtCodigoArticulo.Text;

                articulo.IdCategoria = categoria.Id;
                articulo.IdMarca = marca.Id;


                int id = dato.Agregar_getId(articulo);
                foreach (Imagen img in imagenes)
                {
                    img.IdArticulo = id;
                    imgData.Agregar(img);
                }

                if(articulo.Id != 0)
                {
                    dato.Modificar(articulo);
                    MessageBox.Show("Modificado con éxito!");

                }
                
                else
                {
                    dato.Agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Close();
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            Imagen imagen = new Imagen();
            imagen.ImagenUrl = txtUrl.Text;
            lwImagenes.Items.Add(imagen.ImagenUrl);
            imagenes.Add(imagen);
        }




        private void lwImagenes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            CargarImagen(lwImagenes.FocusedItem.Text);
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que la tecla presionada no se ni CTRL ni cualquier digito no numerico
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarImg_Click(object sender, EventArgs e)
        {
            lwImagenes.FocusedItem.Remove();
            CargarImagen("");
        }
    }
}
