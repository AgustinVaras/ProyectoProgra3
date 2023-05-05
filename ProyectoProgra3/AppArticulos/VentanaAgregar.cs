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
        public VentanaAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            DatosDeArticulos dato = new DatosDeArticulos();
            try
            {
                Categoria categoria = (Categoria)cbCategoria.SelectedItem;
                Marca marca = (Marca)cbMarca.SelectedItem;
                
                art.Nombre = txtNombre.Text;
                art.Precio = decimal.Parse(txtPrecio.Text);
                art.Descripcion = rtxtDescripcion.Text;
                art.Codigo = txtCodigoArticulo.Text;

                art.IdCategoria = categoria.Id;
                art.IdMarca = marca.Id;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void VentanaAgregar_Load(object sender, EventArgs e)
        {
            CategoriaDatos categorias = new CategoriaDatos();
            MarcaDatos marcas = new MarcaDatos();
            try
            {
                cbCategoria.DataSource = categorias.Listar();
                cbMarca.DataSource = marcas.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
