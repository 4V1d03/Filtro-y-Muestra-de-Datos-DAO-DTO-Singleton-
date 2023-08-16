using Mostrar_y_Filtrar_Datos.DAO;
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
    public partial class Clientes : Form
    {
        //patron singleton
        private Clientes()
        {
            InitializeComponent();
        }

        private static Clientes instancia = null;

        public static Clientes obtenerinstancia()
        {
            if (instancia == null)
            {
                instancia = new Clientes();
            }
            
            return instancia; 
        }





        private void Clientes_Load(object sender, EventArgs e)
        {
            verregistros("");//muestra todos los registros
        }

        private void verregistros(string busqueda) //metodo para ver todos los registros
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            dataGridView1.DataSource = clienteDAO.MostrarRegistros(busqueda);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            verregistros(txtbuscar.Text);
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            verregistros(txtbuscar.Text);
        }
    }
}
