using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases.Usuario
{
    public class Usuario
    {
        private int usuarioId;
        private string nombre;
        private string correo;
        private string contraseña;
        private DateTime fechaRegistro;

        public int UsuarioId
        {
            get { return usuarioId; }
            set { usuarioId = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public DateTime FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        public override string ToString()
        {
            return $"UsuarioId: {UsuarioId}, Nombre: {Nombre}, Correo: {Correo}, Fecha de Registro: {FechaRegistro}";
        }
    }
}
