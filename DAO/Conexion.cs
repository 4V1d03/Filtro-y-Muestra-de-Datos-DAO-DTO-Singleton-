using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Mostrar_y_Filtrar_Datos.DAO
{
    internal class Conexion //este es una super clase la cual sera heredada por todas las clases DAO
    {

        protected SqlConnection ConexionBD = new SqlConnection("Server=MSI\\SQLEXPRESS;DataBase=Practica_Patrones;Integrated Security=true");





    }
}
