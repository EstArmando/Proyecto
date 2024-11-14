using Microsoft.Data.SqlClient;
using Proyecto.Clases.Labs;
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
        public List<Usuario> LeerUsuarios() {

            List<Usuario> usuarios = new List<Usuario>();

            Conexion conexion = new Conexion();
            conexion.AbrirConexion();

            SqlCommand comando = new SqlCommand("sp_LeerTUsuarios", conexion.GetConexion())
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };

            try
            {
                SqlDataReader reader = comando.ExecuteReader();

                while (reader != null && reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        UsuarioId = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Correo = reader.GetString(2),
                        Contraseña = reader.GetString(3),
                        FechaRegistro = reader.GetDateTime(4)
                    };

                    usuarios.Add(usuario);
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los usuarios: " + ex.Message);
                return null;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }

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
                        Contraseña = reader.GetString(3),
                        FechaRegistro = reader.GetDateTime(4)
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
