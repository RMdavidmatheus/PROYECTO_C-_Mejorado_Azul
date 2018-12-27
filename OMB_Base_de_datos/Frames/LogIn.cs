using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        // NUMERO DE IMAGEN 
        private int imageNumber = 1;
        // VARIABLES
        private string usutxtBox;
        private string contxtBox;
        private string UsuarioBD;
        private string ContraseñaBD;
        public string TomarUsu;
        // FIN VARIABLES

        // ARCHIVOS PARA MOVER PANTALLA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // FIN ARCHIVOS MOVER PANTALLA

        // INTANCIA CAPA LOGICA METODOS
        Capa_logica.Logica_Metodos Metodos = new Capa_logica.Logica_Metodos();
        private void LoadNextImage()
        {
            // HAY 5 IMAGENES EL IF NOS RECORRERA LAS 5 IMAGENES EN EL TIMER
            if (imageNumber==6)
            {
                imageNumber = 1;
            }
            // DANDO LA RUTA DE LA CARPETA IMAGES
            Slider.ImageLocation = string.Format(@"C:\Program Files\OMB Seguros\SetUp OMB\Images\{0}.Jpg", imageNumber);
            imageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //UTILIZANDO EL MOTODO DENTRO DEL TIMER
            LoadNextImage();
        }

        private void Pass_Enter(object sender, EventArgs e)
        {
            if (Pass.Text == "INGRESE SU CONTRASEÑA")
            {
                Pass.Text = "";
                Pass.ForeColor = Color.Black;
                Pass.isPassword=true;
            }
        }

        private void Pass_Leave(object sender, EventArgs e)
        {
            if (Pass.Text == "")
            {
                Pass.Text = "INGRESE SU CONTRASEÑA";
                Pass.ForeColor = Color.Gray;
                Pass.isPassword = false;
            }
        }

        private void Usuario_Enter(object sender, EventArgs e)
        {
            if (Usuario.Text == "INGRESE SU USUARIO")
            {
                Usuario.Text = "";
                Usuario.ForeColor = Color.Black;
            }
        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.Text == "")
            {
                Usuario.Text = "INGRESE SU USUARIO";
                Usuario.ForeColor = Color.Gray;
            }
        }

        private void Loguear_Click(object sender, EventArgs e)
        {
            usutxtBox = Usuario.Text;
            contxtBox = Pass.Text;

            if (Usuario.Text != "" || Pass.Text != "")
            {
                DataTable ValidarDato = Metodos.Validar_Ingreso(usutxtBox, contxtBox);

                if (ValidarDato.Rows.Count > 0)
                {
                    DataRow row = ValidarDato.Rows[0];
                    UsuarioBD = Convert.ToString(row["Usuario"]);
                    ContraseñaBD = Convert.ToString(row["Contrasena"]);

                }

                if (Usuario.Text.Equals(UsuarioBD) || Pass.Text.Equals(ContraseñaBD))
                {
                    TomarUsu = UsuarioBD;
                    ContraseñaBD = "";
                    OMB_Base_de_datos.Frames.Cargando bar = new OMB_Base_de_datos.Frames.Cargando(TomarUsu);
                    bar.Show();
                    this.Hide();
                    //OMB_Base_de_datos.Menu Menu = new OMB_Base_de_datos.Menu(TomarUsu);
                    //Menu.Show();
                    UsuarioBD = "";
                    ContraseñaBD = "";
                }

                else if (Usuario.Text != UsuarioBD || Pass.Text != ContraseñaBD)
                {
                    Usuario.Text = "";
                    ErrorUsu.Text = "Error usuario incorrecto...";
                    Pass.Text = "";
                    ErrorPass.Text = "Error contraseña incorrecta...";

                }

                TomarUsu = "";
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del aplicativo?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Continuara en el login..", "RETORNANDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Contenido_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Web_Click(object sender, EventArgs e)
        {
            var proceso3 = new ProcessStartInfo("chrome.exe");
            // ABRIENDO CHROME
            proceso3.Arguments = "https://proyectoomb.azurewebsites.net/OMB_Proyecto_FINAL/index.php";
            // INSTANCIANDO SITIO CHROME
            Process.Start(proceso3);
            // INICIANDO PROCESO CHROME
        }

        private void Face_Click(object sender, EventArgs e)
        {

        }

        private void Insta_Click(object sender, EventArgs e)
        {

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Twitter_Click(object sender, EventArgs e)
        {

        }

        private void RecuperarPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OMB_Base_de_datos.Frames.Recuperacion_pass Recuperar = new OMB_Base_de_datos.Frames.Recuperacion_pass();
            Recuperar.ShowDialog();
        }
    }
}
