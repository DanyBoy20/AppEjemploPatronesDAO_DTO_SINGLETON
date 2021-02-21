using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEjemploPatronesDAO_DTO_SINGLETON.DTO
{
    class ClientesDto
    {
        //ATRIBUTOS
        private int _ID;
        private string _Nombre;
        private string _Apellido;
        private string _Direccion;
        private string _Ciudad;
        private string _Email;
        private string _Telefono;
        private string _Ocupacion;

        // PROPIEDADES GETTERS SETTERS
        public int ID { get => _ID; set => _ID = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Ocupacion { get => _Ocupacion; set => _Ocupacion = value; }
    }
}
