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

namespace OMB_Base_de_datos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Selection.Height = Polizas.Height;
            Selection.Top = Polizas.Top;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        int LX, LY;

        Capa_logica.Logica_Metodos Metodos = new Capa_logica.Logica_Metodos();

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.Main.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(64, 64, 64));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            //base.OnPaint(e);
            //ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent , sizeGripRectangle);
        }


        private void Polizas_Click(object sender, EventArgs e)
        {
            Selection.Height = Polizas.Height;
            Selection.Top = Polizas.Top;
            Title.Text = Polizas.Text;
            Metodos.Abrir_Formulario_En_Panel(Contenido,new Frames.Listado_polizas());

        }

        private void Tomadores_Click(object sender, EventArgs e)
        {
            Selection.Height = Tomadores.Height;
            Selection.Top = Tomadores.Top;
            Title.Text = Tomadores.Text;
            Metodos.Abrir_Formulario_En_Panel(Contenido,new Frames.Listado_Tomadores());
        }

        private void Beneficiarios_Click(object sender, EventArgs e)
        {
            Selection.Height = Beneficiarios.Height;
            Selection.Top = Beneficiarios.Top;
            Title.Text = Beneficiarios.Text;
            Metodos.Abrir_Formulario_En_Panel(Contenido,new Frames.Listado_Beneficiarios());
        }

        private void Vehiculos_Click(object sender, EventArgs e)
        {
            Selection.Height = Vehiculos.Height;
            Selection.Top = Vehiculos.Top;
            Title.Text = Vehiculos.Text;
        }

        private void vigenciapol_Click(object sender, EventArgs e)
        {
            Selection.Height = vigenciapol.Height;
            Selection.Top = vigenciapol.Top;
            Title.Text = vigenciapol.Text;
        }

        private void vigenciasoat_Click(object sender, EventArgs e)
        {
            Selection.Height = vigenciasoat.Height;
            Selection.Top = vigenciasoat.Top;
            Title.Text = vigenciasoat.Text;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del aplicativo?","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Continuara en el aplicativo..","RETORNANDO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;

            this.Size = new Size(1280, 720);
            this.Location = new Point(LX, LY);
            Maximizar.Visible = true;
            Restaurar.Visible = false;
        }

        private void Herramienta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MenuSlide_Click(object sender, EventArgs e)
        {
            if (Slide.Width == 60)
            {
                Slide.Visible = false;
                Slide.Width = 266;
                PanelSlideAni.ShowSync(Slide);
                PanelSlideAni.ShowSync(MenuSlide);
                LogoHide.ShowSync(Logo);
            }
            else
            {
                LogoHide.Hide(Logo);
                Slide.Visible = false;
                Slide.Width = 60;
                PanelSlideAni.ShowSync(Slide);
            }
                
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Title.Text = "Aplicativo OMB SEGUROS";
            Metodos.Abrir_Formulario_En_Panel(Contenido, new Principal());
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            Title.Text = "Aplicativo OMB SEGUROS";
            Metodos.Abrir_Formulario_En_Panel(Contenido, new Principal());
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            Restaurar.Visible = true;
            Maximizar.Visible = false;
        }
    }
}
