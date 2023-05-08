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
            try
            {
                listaArticulos = negocio.listar();
                dgvPrincipal.DataSource = listaArticulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            Articulo seleccion = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
            VentanaDetalles VentanaDetalles = new VentanaDetalles(seleccion);
            VentanaDetalles.ShowDialog();
        }

        private void itemModificar_Click(object sender, EventArgs e)
        {
            cboCriterioBusqueda.Items.Add("Id");
            cboCriterioBusqueda.Items.Add("IdMarca");
            cboCriterioBusqueda.Items.Add("IdCategoria");
            cboCriterioBusqueda.Items.Add("Nombre");
            cboCriterioBusqueda.Items.Add("Codigo");

            Articulo Seleccion;
            Seleccion = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;

            VentanaAgregar Modificar = new VentanaAgregar(Seleccion);
            Modificar.ShowDialog();



        }

        private void Boton_Buscar_Click(object sender, EventArgs e)
        {
            DatosDeArticulos datos = new DatosDeArticulos();
            busquedaArticulos = datos.Buscar(TextBox_Buscar.Text, cboCriterioBusqueda.Text);
            
            if (!busquedaArticulos.Any<Articulo>())
                MessageBox.Show("Su búsqueda no arrojó ningún resultado");
            else
                dgvPrincipal.DataSource = busquedaArticulos;
        }

        private void itemEliminar_Click(object sender, EventArgs e)
        {

            DatosDeArticulos Negocio = new DatosDeArticulos();
            Articulo Seleccion;
            try
            {
                DialogResult Respuesta =  MessageBox.Show("Seguro que desea eliminar el articulo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(Respuesta == DialogResult.Yes)
                {
                    Seleccion = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
                    Negocio.Eliminar(Seleccion.Id);
                    ActulizarListado();

                }
                
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
