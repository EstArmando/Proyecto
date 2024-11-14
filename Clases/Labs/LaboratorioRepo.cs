using Microsoft.Data.SqlClient;
using Proyecto.Clases.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto.Clases.Labs
{
    internal class LaboratorioRepo
    {
        public List<Laboratorio> LeerLaboratorios()
        {
            List<Laboratorio> labs = new List<Laboratorio>();
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            SqlCommand comando = new SqlCommand("sp_LeerTLaboratorios", conexion.GetConexion())
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };

            try
            {
                SqlDataReader reader = comando.ExecuteReader();

                while (reader != null && reader.Read())
                {
                    Laboratorio lab = new Laboratorio
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Ubicacion = reader.GetString(2),
                        Capacidad = reader.GetInt32(3),
                        Responsable = reader.GetString(4),
                        FechaApertura = reader.GetDateTime(5),
                        FechaCierre = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6)
                    };

                    labs.Add(lab);
                }
                return labs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los laboratorios: " + ex.Message);
                return null;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
