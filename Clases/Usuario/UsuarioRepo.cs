using Microsoft.Data.SqlClient;
using Proyecto.Clases.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases.Usuario
{
    internal class UsuarioRepo
    {
        public Usuario IniciarSesion(string nombre, string contraseña)
        {
            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            SqlCommand comando = new SqlCommand("sp_IniciarSesion", conexion.GetConexion())
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };

            comando.Parameters.Add(new SqlParameter("@Nombre", nombre));
            comando.Parameters.Add(new SqlParameter("@Contrasena", contraseña));

            try
            {
                SqlDataReader reader = comando.ExecuteReader();

                if (reader != null && reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        UsuarioId = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Correo = reader.GetString(2),
                        FechaRegistro = reader.GetString(3)
                    };
                    return usuario;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el usuario: " + ex.Message);
                return null;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

    }
}
