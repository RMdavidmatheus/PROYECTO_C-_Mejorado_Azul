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
    public partial class Recuperacion_pass : Form
    {
        public Recuperacion_pass()
        {
            InitializeComponent();
        }
        // ARCHIVOS PARA MOVER PANTALLA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // FIN ARCHIVOS MOVER PANTALLA

        // INSTANCIANDO CAPA LOGICA
        Capa_logica.Logica_Metodos Metodos = new Capa_logica.Logica_Metodos();

        private void Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                this.Close();    
            }
            else
            {
                MessageBox.Show("Retornara a la ventana anterior..","RETORNANDO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Documento_Enter(object sender, EventArgs e)
        {
            if (Documento.Text == "INGRESE SU DOCUMENTO")
            {
                Documento.Text = "";
                Documento.ForeColor = Color.Black;
            }
        }

        private void Documento_Leave(object sender, EventArgs e)
        {
            if (Documento.Text == "")
            {
                Documento.Text = "INGRESE SU DOCUMENTO";
                Documento.ForeColor = Color.Gray;
            }
        }

        private void Recuperar_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = Metodos.Metodo_Recuperar_Contrasena(Documento.Text);
        }
    }
}
