using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mostrar_y_Filtrar_Datos.UI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = Clientes.obtenerinstancia();
            clientes.MdiParent = this;
            clientes.Show();
            clientes.BringToFront();



        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Libros libros = Libros.obtenerinstancia();
            libros.MdiParent = this;
            libros.Show();
            libros.BringToFront();
        }
    }
}
