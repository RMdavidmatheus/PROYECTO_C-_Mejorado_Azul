using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMB_Base_de_datos
{
    public partial class Principal : Form
    {
        public Principal(string TomarUsu)
        {
            InitializeComponent();
            Usu = TomarUsu;
            txtUsuario.Text = Usu;
        }
        private string Usu;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.hora.Text = DateTime.Now.ToLongTimeString();
            this.Fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }
    }
}
