using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion
{
    internal class Conexion
    {
        private readonly string cadena = "Server=Ricardo;Database=FACTURACIONPI;Integrated Security=true;";
        private SqlConnection conexion;

        public SqlConnection AbrirConexion() {
            if (conexion == null) { 
                conexion = new SqlConnection(cadena);
            }

            if (conexion.State == System.Data.ConnectionState.Closed) 
                conexion.Open();

            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }
    }
}
