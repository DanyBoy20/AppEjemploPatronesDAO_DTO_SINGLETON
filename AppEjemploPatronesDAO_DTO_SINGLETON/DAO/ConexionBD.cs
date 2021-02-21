using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppEjemploPatronesDAO_DTO_SINGLETON.DAO
{
    class ConexionBD
    {
        // CADENA CONEXION - AUTENTICACION S.O.
        protected SqlConnection Conexion = new SqlConnection("Server=DESKTOP-1NCENQ8;DataBase=Ejemplo_Patrones;Integrated Security=true");
    }
}
