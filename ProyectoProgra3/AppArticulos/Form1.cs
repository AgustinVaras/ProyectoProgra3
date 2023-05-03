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

        private void Boton_Agregar_Click(object sender, EventArgs e)
        {
            VentanaAgregar Ventana_Agregar = new VentanaAgregar();
            Ventana_Agregar.ShowDialog();
        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            VentanaModificar Ventana_Modificar = new VentanaModificar();
            Ventana_Modificar.ShowDialog();
        }
    }
}
