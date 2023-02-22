namespace Entidades
{
    public class Login
    {
        //Propiedades
        public string CodigoUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }


        //constructor vacio
        public Login()
        {
        }

        //constructores de propiedades 
        public Login(string codigoUsuario, string contraseña, string rol)
        {
            CodigoUsuario = codigoUsuario;
            Contraseña = contraseña;
            Rol = rol;
        }







    }

}
