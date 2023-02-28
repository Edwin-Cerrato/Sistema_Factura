using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                Alerta.SetError(txtUsuario, "Ingrese un usuario");
                txtUsuario.Clear();
                txtUsuario.Focus();
                return;
            }
            Alerta.Clear();

            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                Alerta.SetError(txtContraseña, "Ingrese la contraseña");
                txtContraseña.Clear();
                txtContraseña.Focus();
                return;
            }
            //VALIDAR EN BASE DE DATOS


            //MOSTRAR EL MENU
            //instanciamos el formulario
            //Nombre de formulario al que queremos ir,despues el nombre y por ultimo la propiedad
            Menu menuformulario = new Menu();
            //comando para ocultar el formulario anterior
            this.Hide();
            menuformulario.Show();

        }

        private void btnVerContraseña_Click(object sender, EventArgs e)
        {
            ////Mostrar Contraseña

            //if (txtContraseña.PasswordChar == '*')
            //{
            //    bool v = txtContraseña.PasswordChar == '\0';
            //}
            //else
            //{
            //    bool v = txtContraseña.PasswordChar == '*';
            //}

        }
    }
}
