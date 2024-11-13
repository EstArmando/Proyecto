using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Proyecto.Clases.SQL
{
    internal class Conexion
    {
        private SqlConnection conexion;
        private string cadena = "Data Source=localhost;Initial Catalog=PROYECTO_f;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public Conexion()
        {
            conexion = new SqlConnection(cadena);
        }

        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                    Console.WriteLine("Conexión abierta.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }

        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                    Console.WriteLine("Conexión cerrada.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }

        }
        public SqlConnection GetConexion()
        {
            return conexion;
        }
    }
}
