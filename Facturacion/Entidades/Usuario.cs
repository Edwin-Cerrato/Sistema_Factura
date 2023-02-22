using System;

namespace Entidades
{
    public class Usuario
    {
        //Propiedades
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public string Rol { get; set; }

        // Propiedad de Fecha de cuando fue creado el usuario
        public DateTime FechaCreacion { get; set; }
        //propiedad de estado de trabajador,si esta o no laborando.
        public bool EstaActivo { get; set; }

        //constructor vacio-siempre
        public Usuario()
        {
        }
        //constructor de todas las propiedades
        public Usuario(string codigoUsuario, string nombre, string contraseña, string correo, string rol, DateTime fechaCreacion, bool estaActivo)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Contraseña = contraseña;
            Correo = correo;
            Rol = rol;
            FechaCreacion = fechaCreacion;
            EstaActivo = estaActivo;
        }
    }


}
