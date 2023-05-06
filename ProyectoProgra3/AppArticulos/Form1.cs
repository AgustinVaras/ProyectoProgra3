using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexiones;
using Clases;

namespace AppArticulos
{
    public partial class Ventana_Principal : Form
    {
        private List<Articulo> listaArticulos;
        private List<Articulo> busquedaArticulos;
        public Ventana_Principal()
        {
            InitializeComponent();
        }

        private void ActulizarListado()
        {
            try
            {
                //Agregar columnas
                dgvPrincipal.DataSource = listaArticulos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void itemModificar_Click_1(object sender, EventArgs e)
        {
            VentanaModificar Ventana_Modificar = new VentanaModificar();
            Ventana_Modificar.ShowDialog();
        }

        private void itemAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                VentanaAgregar Ventana_Agregar = new VentanaAgregar();
                Ventana_Agregar.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DatosDeArticulos negocio = new DatosDeArticulos();
                listaArticulos = negocio.listar();
                ActulizarListado();
            }
        }

        private void Boton_Detalles_Click(object sender, EventArgs e)
        {
            VentanaDetalles VentanaDetalles = new VentanaDetalles();
            VentanaDetalles.ShowDialog();
        }

        private void Ventana_Principal_Load(object sender, EventArgs e)
        {
            cboCriterioBusqueda.Items.Add("Id");
            cboCriterioBusqueda.Items.Add("IdMarca");
            cboCriterioBusqueda.Items.Add("IdCategoria");
            cboCriterioBusqueda.Items.Add("Nombre");
            cboCriterioBusqueda.Items.Add("Codigo");

            DatosDeArticulos negocio = new DatosDeArticulos();
            listaArticulos = negocio.listar();
            dgvPrincipal.DataSource = listaArticulos;
        }

        private void Boton_Buscar_Click(object sender, EventArgs e)
        {
            DatosDeArticulos datos = new DatosDeArticulos();
            busquedaArticulos = datos.Buscar(TextBox_Buscar.Text, cboCriterioBusqueda.Text);
            dgvPrincipal.DataSource = busquedaArticulos;
        }
    }
}
