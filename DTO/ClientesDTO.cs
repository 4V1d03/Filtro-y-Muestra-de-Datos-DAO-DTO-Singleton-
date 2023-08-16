using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostrar_y_Filtrar_Datos.DTO
{
    internal class ClientesDTO
    {
        //Atributos
        int iD;
        string nombre;
        string apellido;
        string direccion;
        string ciudad;
        string email;
        string telefono;
        string ocupacion;
        
        //propiedades Getters y Setters
        public int ID { get => iD; set => iD = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Ocupacion { get => ocupacion; set => ocupacion = value; }
    }
}
