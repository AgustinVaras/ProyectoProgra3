using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppArticulos
{
    public partial class Ventana_Principal : Form
    {
        public Ventana_Principal()
        {
            InitializeComponent();
        }

        private void itemModificar_Click_1(object sender, EventArgs e)
        {
            VentanaModificar Ventana_Modificar = new VentanaModificar();
            Ventana_Modificar.ShowDialog();
        }

        private void itemAgregar_Click_1(object sender, EventArgs e)
        {
            VentanaAgregar Ventana_Agregar = new VentanaAgregar();
            Ventana_Agregar.ShowDialog();
        }

        private void Boton_Detalles_Click(object sender, EventArgs e)
        {
            VentanaDetalles VentanaDetalles = new VentanaDetalles();
            VentanaDetalles.ShowDialog();
        }

        private void Ventana_Principal_Load(object sender, EventArgs e)
        {
            cboCriterioBusqueda.Items.Add("Id");
            cboCriterioBusqueda.Items.Add("Codigo");
            cboCriterioBusqueda.Items.Add("Nombre");
            cboCriterioBusqueda.Items.Add("Marca");
            cboCriterioBusqueda.Items.Add("Categoria");

            DatosDeArticulos negocio = new DatosDeArticulos();
            dgvPrincipal.DataSource = negocio.listar();
        }
    }
}
