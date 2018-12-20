using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMB_Base_de_datos.Frames
{
    public partial class SelectDate : Form
    {
        public SelectDate()
        {
            InitializeComponent();
            Date.Format = DateTimePickerFormat.Custom;
            Date.CustomFormat = "yyyy-MM-dd";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir sin elegir fecha?","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Retornando al formulario", "RETORNANDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void MandarFechas(Bunifu.Framework.UI.BunifuMaterialTextbox receptor)
        {
            receptor.Text=Date.Text;
        }

        private void GuardarDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se guardo la fecha correctamente");
            this.Close();
        }
    }
}
