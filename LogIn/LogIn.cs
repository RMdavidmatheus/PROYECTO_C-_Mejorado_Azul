using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private void LoadNextImage()
        {
            // HAY 5 IMAGENES EL IF NOS RECORRERA LAS 5 IMAGENES EN EL TIMER
            if (imageNumber==6)
            {
                imageNumber = 1;
            }
            // DANDO LA RUTA DE LA CARPETA IMAGES
            Slider.ImageLocation = string.Format(@"C:\Users\David PC\source\repos\OMB_Base_de_datos\LogIn\bin\Debug\Images\{0}.Jpg", imageNumber);
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
    }
}
