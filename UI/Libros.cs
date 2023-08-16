using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mostrar_y_Filtrar_Datos.UI
{
    public partial class Libros : Form
    {
        private Libros()
        {
            InitializeComponent();
        }

        private static Libros instancia = null;

        public static Libros obtenerinstancia()
        {
            if (instancia == null)
            {
                instancia = new Libros();
            }    
            
            return instancia; 
        }




        private void Libros_Load(object sender, EventArgs e)
        {

        }
    }
}
