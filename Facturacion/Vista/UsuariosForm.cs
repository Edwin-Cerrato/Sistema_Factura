using Entidades;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UsuariosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public UsuariosForm()
        {
            InitializeComponent();

        }
        //variable que informara que boton presiono el usuario
        string TipoOperacion = "";

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, System.EventArgs e)
        {
            txtCodigo.Focus();
            HabilitarControles();
            TipoOperacion = "Nuevo";
        }

        //procedimiento que habilita los controles
        private void HabilitarControles()
        {
            txtNombre.Enabled = true;
            txtCodigo.Enabled = true;
            txtContraseña.Enabled = true;
            txtCorreo.Enabled = true;
            btnAdjuntarFoto.Enabled = true;
            cbxRol.Enabled = true;
            EstaActivoCheckBox.Enabled = true;

            //botones
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;



        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
        }
        private void DeshabilitarControles()
        {
            txtNombre.Enabled = false;
            txtCodigo.Enabled = false;
            txtContraseña.Enabled = false;
            txtCorreo.Enabled = false;
            btnAdjuntarFoto.Enabled = false;
            cbxRol.Enabled = false;
            EstaActivoCheckBox.Enabled = false;

            //botones
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtCodigo.Clear();
            txtContraseña.Clear();
            txtCorreo.Clear();
            cbxRol.Text = string.Empty;
            EstaActivoCheckBox.Checked = false;
            FotoPictureBox.Image = null;

        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (TipoOperacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    errorProvider1.SetError(txtCodigo, "Ingrese un Codigo");
                    txtCodigo.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    errorProvider1.SetError(txtNombre, "Ingrese el Nombre");
                    txtNombre.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(txtContraseña.Text))
                {
                    errorProvider1.SetError(txtContraseña, "Ingrese la Contraseña");
                    txtContraseña.Focus();
                    return;
                }
                errorProvider1.Clear();
                ;
                //instanciamos la objeto Usuario

                Usuario user = new Usuario();
                user.CodigoUsuario = txtCodigo.Text;
                user.Nombre = txtNombre.Text;
                user.Contraseña = txtContraseña.Text;
                user.Rol = cbxRol.Text;
                user.Correo = txtCorreo.Text;
                user.EstaActivo = EstaActivoCheckBox.Checked;

                //validar que el usuario adjunto la foto correctamente

                if (FotoPictureBox.Image != null)
                {
                    //la clase memorystream sirve para manejar archivos(audios,pdf,iamgenes,etc)
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    FotoPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    user.Foto = ms.GetBuffer();
                }




                //Insertar en Base de Datos
            }
            else if (TipoOperacion == "Modificar")
            {

            }

        }

        private void btnModificar_Click(object sender, System.EventArgs e)
        {
            TipoOperacion = "Modificar";
        }

        private void btnAdjuntarFoto_Click(object sender, System.EventArgs e)
        {
            //Abre ventana de archivos de la pc del usuario
            OpenFileDialog Foto = new OpenFileDialog();
            DialogResult resultado = Foto.ShowDialog();

            //ese dialog.ok significa que el usuario si subio la imagen
            if (resultado == DialogResult.OK)
            {
                FotoPictureBox.Image = Image.FromFile(Foto.FileName);


            }

        }
    }
}
