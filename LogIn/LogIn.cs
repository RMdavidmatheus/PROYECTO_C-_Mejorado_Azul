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
        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if (imageNumber==6)
            {
                imageNumber = 1;
            }
            Slider.ImageLocation = string.Format(@"C:\Users\David PC\source\repos\OMB_Base_de_datos\LogIn\bin\Debug\Images\{0}.Jpg", imageNumber);
            imageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
