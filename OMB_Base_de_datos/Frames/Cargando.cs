using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMB_Base_de_datos.Frames
{
    public partial class Cargando : Form
    {
        public Cargando(string TomarUsu)
        {
            InitializeComponent();
            Usu = TomarUsu;
        }

        private string Usu;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Carga.Value++;
            if (Carga.Value==Carga.MaxValue)
            {
                timer1.Stop();
                Menu Menu = new Menu(Usu);
                this.Hide();
                Menu.Show();
                MessageBox.Show("Bienvenido a nuestro aplicativo "+Usu,"INGRESO EXITOSO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
