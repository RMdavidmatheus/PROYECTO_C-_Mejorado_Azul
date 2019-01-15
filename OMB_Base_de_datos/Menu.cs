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

namespace OMB_Base_de_datos
{
    public partial class Menu : Form
    {
        public Menu(string TomarUsu)
        {
            InitializeComponent();
            Selection.Height = Polizas.Height;
            Selection.Top = Polizas.Top;
            Usu = TomarUsu;
            Selection.Hide();
        }
        // METODO MOVER PANTALLA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // FIN METODO MOVER PANTALLA

        private int LX, LY;
        private string Usu;

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
            if (Selection.Visible==false)
            {
                Selection.Show();
                Selection.Top = Polizas.Top;
                Selection.Height = Polizas.Height;
            }
            else
            {
                Selection.Top = Polizas.Top;
                Selection.Height = Polizas.Height;
            }
            Title.Text = Polizas.Text;
            Metodos.Abrir_Formulario_En_Panel(Contenido,new Frames.Listado_polizas(Usu));

        }

        private void Tomadores_Click(object sender, EventArgs e)
        {
            if (Selection.Visible == false)
            {
                Selection.Show();
                Selection.Top = Tomadores.Top;
                Selection.Height = Tomadores.Height;
            }
            else
            {
                Selection.Top = Tomadores.Top;
                Selection.Height = Tomadores.Height;
            }
            Title.Text = Tomadores.Text;
            Metodos.Abrir_Formulario_En_Panel(Contenido,new Frames.Listado_Tomadores(Usu));
        }

        private void Beneficiarios_Click(object sender, EventArgs e)
        {
            if (Selection.Visible == false)
            {
                Selection.Show();
                Selection.Top = Beneficiarios.Top;
                Selection.Height = Beneficiarios.Height;
            }
            else
            {
                Selection.Top = Beneficiarios.Top;
                Selection.Height = Beneficiarios.Height;
            }
            Title.Text = Beneficiarios.Text;
            Metodos.Abrir_Formulario_En_Panel(Contenido,new Frames.Listado_Beneficiarios(Usu));
        }

        private void Vehiculos_Click(object sender, EventArgs e)
        {
            if (Selection.Visible == false)
            {
                Selection.Show();
                Selection.Top = Vehiculos.Top;
                Selection.Height = Vehiculos.Height;
            }
            else
            {
                Selection.Top = Vehiculos.Top;
                Selection.Height = Vehiculos.Height;
            }
            Title.Text = Vehiculos.Text;
            Metodos.Abrir_Formulario_En_Panel(Contenido, new Frames.Listado_Vehiculos(Usu));
        }

        private void vigenciapol_Click(object sender, EventArgs e)
        {
            if (Selection.Visible == false)
            {
                Selection.Show();
                Selection.Top = vigenciapol.Top;
                Selection.Height = vigenciapol.Height;
            }
            else
            {
                Selection.Top = vigenciapol.Top;
                Selection.Height = vigenciapol.Height;
            }
            Title.Text = vigenciapol.Text;
            Metodos.Abrir_Formulario_En_Panel(Contenido, new Frames.Reporte_Vigencias_Polizas(Usu));
        }

        private void vigenciasoat_Click(object sender, EventArgs e)
        {
            if (Selection.Visible == false)
            {
                Selection.Show();
                Selection.Top = vigenciasoat.Top;
                Selection.Height = vigenciasoat.Height;
            }
            else
            {
                Selection.Top = vigenciasoat.Top;
                Selection.Height = vigenciasoat.Height;
            }
            Title.Text = vigenciasoat.Text;
            Metodos.Abrir_Formulario_En_Panel(Contenido, new Frames.Reporte_Vigencia_SOAT(Usu));
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del aplicativo?","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
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
                Slide.Width = 272;
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
            Metodos.Abrir_Formulario_En_Panel(Contenido, new Principal(Usu));
            // ACTUALIZAR AUTOMATICAMENTE POLIZA SI ESTA ACTIVA O INACTIVA
            string PolqueryActivo = "UPDATE poliza p set p.polEstado = 'ACTIVO'where p.polVigenciaFinal >= NOW()  AND p.polEstado = 'INACTIVO'";
            Metodos.Insertar_Datos_Poliza_General(PolqueryActivo);
            string PolqueryInactivo = "UPDATE poliza p set p.polEstado = 'INACTIVO'where p.polVigenciaFinal < NOW() AND p.polEstado = 'ACTIVO'";
            Metodos.Insertar_Datos_Poliza_General(PolqueryInactivo);
            // FINALIZACION POLIZA UPDATE

            //ACTUALIZAR ACTIVO O INACTIVO EN VEHICULOS
            string SOATqueryActivo = "UPDATE vehiculo v set v.veh_soat_estado = 'ACTIVO'where v.vehVigenciaSOAT >= NOW()";
            Metodos.Insertar_Datos_Poliza_General(SOATqueryActivo);
            string SOATqueryInactivo = "UPDATE vehiculo v set v.veh_soat_estado = 'INACTIVO'where v.vehVigenciaSOAT < NOW()";
            Metodos.Insertar_Datos_Poliza_General(SOATqueryInactivo);
            // FIN
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            Title.Text = "Aplicativo OMB SEGUROS";
            Metodos.Abrir_Formulario_En_Panel(Contenido, new Principal(Usu));
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
