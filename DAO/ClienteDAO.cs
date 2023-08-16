using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Mostrar_y_Filtrar_Datos.DTO;
//using Mostrar_y_Filtrar_Datos.DTO;

namespace Mostrar_y_Filtrar_Datos.DAO
{
    internal class ClienteDAO : Conexion
    {
        SqlDataReader leerfilas;
        SqlCommand cmd = new SqlCommand();

        //Metodos CRUD
        public List<ClientesDTO> MostrarRegistros(string busqueda)
        {
            cmd.Connection = ConexionBD;
            cmd.CommandText = "MostrarRegistros";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@busqueda", busqueda);
            
            ConexionBD.Open();

            leerfilas = cmd.ExecuteReader();
            List<ClientesDTO> listadatos = new List<ClientesDTO>();
            while (leerfilas.Read()) 
            {
                listadatos.Add(new ClientesDTO()
                { 
                    ID = leerfilas.GetInt32(0),
                    Nombre = leerfilas.GetString(1),
                    Apellido = leerfilas.GetString(2),
                    Direccion = leerfilas.GetString(3),
                    Ciudad = leerfilas.GetString(4),
                    Email = leerfilas.GetString(5),
                    Telefono = leerfilas.GetString(6),
                    Ocupacion = leerfilas.GetString(7),
                });
            }
            leerfilas.Close();
            ConexionBD.Close();
            return listadatos;

        }

        public void insertar()
        {

        }

        public void eliminar() 
        { 
        
        }
        
        public void editar() 
        { 
        
        }
    }
}
 