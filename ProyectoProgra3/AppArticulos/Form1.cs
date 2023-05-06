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

        private void Boton_Agregar_Click(object sender, EventArgs e)
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

        private void Ventana_Principal_Load(object sender, EventArgs e)
        {
            cboCriterioBusqueda.Items.Add("Id");
            cboCriterioBusqueda.Items.Add("Codigo");
            cboCriterioBusqueda.Items.Add("Nombre");
            cboCriterioBusqueda.Items.Add("Marca");
            cboCriterioBusqueda.Items.Add("Categoria");

            DatosDeArticulos negocio = new DatosDeArticulos();
            listaArticulos = negocio.listar();
            dgvPrincipal.DataSource = listaArticulos;
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

        private void itemModificar_Click(object sender, EventArgs e)
        {

            Articulo Seleccion;
            Seleccion = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;

            VentanaAgregar Modificar = new VentanaAgregar(Seleccion);
            Modificar.ShowDialog();



        }
    }
}
