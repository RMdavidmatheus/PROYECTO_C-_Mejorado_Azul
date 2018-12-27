using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_logica
{
    public class Logica_Metodos
    {
        private string Email, nombres, contrasena, mensaje;
        ConexionSQL bd = new ConexionSQL();
        public void Abrir_Formulario_En_Panel(Panel Panel_Receptor, object Formulario_Hijo)
        {
            if (Panel_Receptor.Controls.Count >= 0)
            {
                Panel_Receptor.Controls.Clear();
                Form fh = Formulario_Hijo as Form;

                if (fh.Visible == true)
                {
                    fh.BringToFront();
                }
                else
                {
                    fh.TopLevel = false;
                    fh.Dock = DockStyle.Fill;
                    Panel_Receptor.Controls.Add(fh);
                    Panel_Receptor.Tag = fh;
                    fh.Show();
                }
            }
        }
        public void LlenarTabla_Poliza(DataGridView Llenar)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT* from vista_interface", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }
        public void LlenarTabla_Tomadores(DataGridView Llenar)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT* from tom", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }
        public void LlenarTabla_Beneficiarios(DataGridView Llenar)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM ben", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }
        public void LlenarTabla_Vehiculos(DataGridView Llenar)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM polizasveh", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }
        public void LlenarTabla_VigPol(DataGridView Llenar, int SelectIndexMes)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM vigencia_polizas_activas vpa WHERE MONTH(vpa.`Fecha vencimiento Poliza`)=" + SelectIndexMes + " AND vpa.Estado='ACTIVO'", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }
        public void LlenarTabla_VigSOAT(DataGridView Llenar, int SelectIndexMes)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM vigencia_soat_mes vsm WHERE MONTH(vsm.`Fecha Vencimiento SOAT`)='" + SelectIndexMes + "'", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }
        public void LlenarTabla_PolCancel(DataGridView Llenar, int SelectIndexMes)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM vigencia_polizas_activas vpa WHERE MONTH(vpa.`Fecha vencimiento Poliza`)=" + SelectIndexMes + " AND vpa.Estado='INACTIVO'", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }
        public bool Insertar_Datos_Poliza_General(string query)
        {
            bool Insertado = false;
            try
            {
                bd.ObtenerConexion();
                int registros = 0;
                MySqlCommand sentencia = new MySqlCommand(query, bd.GetConnection());
                registros = sentencia.ExecuteNonQuery();
                if (registros > 0)
                {
                    Insertado = true;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
            return Insertado;
        }
        public DataTable Extraer_Tom(string DocumentoTomador)
        {
            //TOMANDO DATOS CONCRETOS DE TOMADOR

            DataTable dt = new DataTable();

            MySqlCommand query = new MySqlCommand("select tom.tomNombres,tom.tomApellidos,tom.tomDireccion,tom.tomEmail,tom.tomFechaNacimiento from tomador tom where tom.tomDocumento = '" + DocumentoTomador + "' ", bd.GetConnection());
            MySqlDataAdapter rs = new MySqlDataAdapter(query);
            rs.Fill(dt);


            return dt;
        }
        public DataTable Extraer_Ben(string DocumentoBeneficiario)
        {
            // TOMANDO DATOS CONCRETOS DE BENEFICIARIO
            DataTable dt = new DataTable();
            MySqlCommand query = new MySqlCommand("select ben.benNombres,ben.benApellidos,ben.benDireccion,ben.benEmail,ben.benFechaNacimiento from beneficiario ben where ben.benDocumento = '" + DocumentoBeneficiario + "' ", bd.GetConnection());
            MySqlDataAdapter rs = new MySqlDataAdapter(query);
            rs.Fill(dt);


            return dt;
        }
        public DataTable Extraer_Pol(string Num_pol)
        {
            // TOMANDO DATOS CONCRETOS DE POLIZA
            DataTable dt = new DataTable();
            MySqlCommand query = new MySqlCommand("select p.tipo_poliza_tipIdRamo , p.aseguradora_aseId, p.polValorPrima from poliza p where p.pol_NumeroPoliza = '" + Num_pol + "' ", bd.GetConnection());
            MySqlDataAdapter rs = new MySqlDataAdapter(query);
            rs.Fill(dt);


            return dt;
        }
        public DataTable Extraer_Pol_Veh(string Num_pol)
        {
            // TOMANDO DATOS CONCRETOS DE POLIZA DE VEHICULOS
            DataTable dt = new DataTable();
            MySqlCommand query = new MySqlCommand("select p.vehiculo_vehPlaca from pol_veh p where p.poliza_pol_NumeroPoliza = '" + Num_pol + "' ", bd.GetConnection());
            MySqlDataAdapter rs = new MySqlDataAdapter(query);
            rs.Fill(dt);


            return dt;
        }
        public DataTable Extraer_Veh(string Placa)
        {
            // TOMANDO DATOS CONCRETOS DE VEHICULOS
            DataTable dt = new DataTable();
            MySqlCommand query = new MySqlCommand("select v.vehModelo, v.vehFasecolda, v.vehServicio, v.vehClase, v.vehMarca, vehValorAuto, v.vehVigenciaSOAT from vehiculo v where v.vehPlaca = '" + Placa + "' ", bd.GetConnection());
            MySqlDataAdapter rs = new MySqlDataAdapter(query);
            rs.Fill(dt);


            return dt;
        }
        public bool Eliminar_Datos(string query)
        {
            bool Eliminado = false;
            try
            {
                bd.ObtenerConexion();
                int registros = 0;
                MySqlCommand sentencia = new MySqlCommand(query, bd.GetConnection());
                registros = sentencia.ExecuteNonQuery();
                if (registros > 0)
                {
                    Eliminado = true;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();

            return Eliminado;
        }
        public void Buscar_Tom(DataGridView Llenar, string TextoBusqueda)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM tom t WHERE t.Documento LIKE '" + TextoBusqueda + "%' OR t.Nombres LIKE '" + TextoBusqueda + "%' OR t.Apellidos LIKE '" + TextoBusqueda + "%' ", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }
        public void Buscar_Poliza(DataGridView Llenar, string TextoBusqueda)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("select * from vista_interface vi where vi.`N.Poliza` LIKE '" + TextoBusqueda + "%' or vi.`Doc Tomador` LIKE '" + TextoBusqueda + "%' or vi.`Doc Beneficiario`LIKE '" + TextoBusqueda + "%' OR vi.`Nombres Tomador` LIKE '" + TextoBusqueda + "%' OR vi.`Nombres Beneficiario` LIKE '" + TextoBusqueda + "%'", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }
        public void Buscar_Ben(DataGridView Llenar, string TextoBusqueda)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM ben b WHERE b.Documento  LIKE '" + TextoBusqueda + "%' OR b.Nombres LIKE '" + TextoBusqueda + "%' OR b.Apellidos LIKE '" + TextoBusqueda + "%'  ", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }
        public void Buscar_Vehiculo(DataGridView Llenar, string TextoBusqueda)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM polizasveh pv WHERE pv.`N.Poliza` LIKE '" + TextoBusqueda + "%' or pv.`Documento Tomador` LIKE '" + TextoBusqueda + "%' OR pv.`Nombres Tomador` LIKE '" + TextoBusqueda + "%' or pv.Placa LIKE '" + TextoBusqueda + "%'", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }
        public void Reporte_SOAT_Buscar(DataGridView Llenar, string TextoBusqueda)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("select * from vigencia_soat_mes vs where vs.Placa LIKE '" + TextoBusqueda + "%' OR vs.`N.Poliza` LIKE '" + TextoBusqueda + "%' OR vs.`Documento Tomador`LIKE '" + TextoBusqueda + "%' OR vs.`Nombres Tomador` LIKE '" + TextoBusqueda + "%' ", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }
        public void Reporte_Vigencia_Poliza_Buscar(DataGridView Llenar, string TextoBusqueda)
        {
            try
            {
                MySqlCommand query = new MySqlCommand("SELECT * FROM vigencia_polizas_activas vpa WHERE vpa.`Nombres Tomador` LIKE '" + TextoBusqueda + "%' OR vpa.`N.Poliza` LIKE '" + TextoBusqueda + "%' OR vpa.`Documento Tomador` LIKE '" + TextoBusqueda + "%' AND vpa.Estado='ACTIVO'", bd.GetConnection());
                MySqlDataAdapter rs = new MySqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bd.DesconectarBase();
        }
        public DataTable Validar_Ingreso(string Usuario, string Contraseña)
        {
            // TOMANDO DATOS CONCRETOS DE USUARIOS
            DataTable dt = new DataTable();
            MySqlCommand query = new MySqlCommand("SELECT usu.Usuario, usu.Contrasena FROM usuarios usu WHERE usu.Usuario = '" + Usuario + "' AND usu.Contrasena= '" + Contraseña + "' ", bd.GetConnection());
            MySqlDataAdapter rs = new MySqlDataAdapter(query);
            rs.Fill(dt);


            return dt;
        }
        // VALIDACIONES
        public void SoloLetras(KeyPressEventArgs ev)
        {
            if (Char.IsLetter(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsSeparator(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsControl(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else
            {
                ev.Handled = true;
            }
        }
        public void SoloNumeros(KeyPressEventArgs ev)
        {
            if (Char.IsNumber(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsSeparator(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsControl(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else
            {
                ev.Handled = true;
            }
        }
        public void AlphaNumerico(KeyPressEventArgs ev)
        {
            if (Char.IsLetterOrDigit(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsSeparator(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsControl(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else
            {
                ev.Handled = true;
            }
        }
        public void Validar_Email(KeyPressEventArgs ev)
        {
            if (Char.IsLetterOrDigit(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsSymbol(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsPunctuation(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsSeparator(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsControl(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else
            {
                ev.Handled = true;
            }
        }
        public string Metodo_Recuperar_Contrasena(string DocumentoUsu)
        {
            // TOMANDO DATOS CONCRETOS DEL USUARIO
            DataTable dt = new DataTable();
            MySqlCommand query = new MySqlCommand("select * from usuarios usu where usu.Documento = '" + DocumentoUsu + "' ", bd.GetConnection());
            MySqlDataAdapter rs = new MySqlDataAdapter(query);
            rs.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Email = Convert.ToString(row["Email"]);
                nombres= Convert.ToString(row["Usuario"]);
                contrasena = Convert.ToString(row["Contrasena"]);
                //ENVIANDO EMAIL
                EnviarEmail();
                mensaje = "Estimad@ "+nombres+" , se envio su contraseña al correo: "+Email+" , verifique su bandeja de entrada";
            }
            else
            {
                mensaje = "El usuario no existe en nuestras bases de datos";
            }

            return mensaje;
        }
        public void EnviarEmail()
        {
            // ESTRUCTURA DEL CORREO
            MailMessage Correo = new MailMessage();
            Correo.From = new MailAddress("millos2013returns@gmail.com");
            Correo.To.Add(Email);
            Correo.Subject = ("RECUPERACION DE CONTRASEÑA");
            Correo.Body = "Bienvenido "+nombres+" a nuestro sistema de recuperacion de contraseñas\n Su contraseña es: "+contrasena+" \n Esperamos haya sido de ayuda, gracias por usar nuestros servicios.";
            Correo.Priority = MailPriority.High;
            // CONFIGURANDO PROTOCOLO DE TRANSFERENCIA SMTP
            SmtpClient ServerEmail = new SmtpClient();
            ServerEmail.Credentials = new NetworkCredential("millos2013returns@gmail.com", "DAVIDALE98");
            ServerEmail.Host = "smtp.gmail.com";
            ServerEmail.Port = 587;
            ServerEmail.EnableSsl = true;
            try
            {
                ServerEmail.Send(Correo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ENVIAR EMAIL " + ex.Message);
            }
            Correo.Dispose();
        }
    }
}
