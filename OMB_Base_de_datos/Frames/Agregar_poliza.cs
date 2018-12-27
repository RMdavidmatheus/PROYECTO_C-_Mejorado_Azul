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
    public partial class Agregar_poliza : Form
    {
        public Agregar_poliza(string Titulo_Label)
        {
            InitializeComponent();
            // ENVIANDO TITULO DEL BOTON DEL FORMULARIO LISTADO DE POLIZAS
            Titulo = Titulo_Label;
            TituloForm.Text = Titulo;
            // DANDOLE FORMATO AL DATEPICKER DE MODELO
            Modelo.Format = DateTimePickerFormat.Custom;
            Modelo.CustomFormat = "yyyy";
            Modelo.ShowUpDown = true;
        }

        // STRING QUE AGARRA EL TITULO POR PARAMETRO
        private string Titulo;

        // STRING QUE ALMACENA EL NUMERO DE POLIZA DEL FORM
        private string DatoNumPol;

        //METODO PARA MOVER VENTANA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // INSTANCIA DEL FORM FECHA
        SelectDate Fechas = new SelectDate();

        // INSTANCIA DE LA CAPA LOGICA METODOS

        Capa_logica.Logica_Metodos Metodos = new Capa_logica.Logica_Metodos();

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //CERRANDO FORM

            if (MessageBox.Show("¿Desea salir del formulario?","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Volvera al formulario..","RETORNANDO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // EVENTO MOVER LA VENTANA DEL FORM
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void DocTom_Enter(object sender, EventArgs e)
        {
            if (DocTom.Text == "Documento Tomador")
            {
                DocTom.Text = "";
                DocTom.ForeColor = Color.Black;
            }
        }
        // PLACE HOLDERS DE CADA TXT BOX
        private void DocTom_Leave(object sender, EventArgs e)
        {
            if (DocTom.Text == "")
            {
                DocTom.Text = "Documento Tomador";
                DocTom.ForeColor = Color.DimGray;
            }
        }

        private void NomTom_Enter(object sender, EventArgs e)
        {
            if (NomTom.Text=="Nombres Tomador")
            {
                NomTom.Text = "";
                NomTom.ForeColor = Color.Black;
            }
        }

        private void NomTom_Leave(object sender, EventArgs e)
        {
            if (NomTom.Text == "")
            {
                NomTom.Text = "Nombres Tomador";
                NomTom.ForeColor = Color.DimGray;
            }
        }

        private void ApeTom_Enter(object sender, EventArgs e)
        {
            if (ApeTom.Text == "Apellidos Tomador")
            {
                ApeTom.Text = "";
                ApeTom.ForeColor = Color.Black;
            }
        }

        private void ApeTom_Leave(object sender, EventArgs e)
        {
            if (ApeTom.Text == "")
            {
                ApeTom.Text = "Apellidos Tomador";
                ApeTom.ForeColor = Color.DimGray;
            }
        }

        private void DirTom_Enter(object sender, EventArgs e)
        {
            if (DirTom.Text == "Direccion Tomador")
            {
                DirTom.Text = "";
                DirTom.ForeColor = Color.Black;
            }
        }

        private void DirTom_Leave(object sender, EventArgs e)
        {
            if (DirTom.Text == "")
            {
                DirTom.Text = "Direccion Tomador";
                DirTom.ForeColor = Color.DimGray;
            }
        }

        private void TelTom_Enter(object sender, EventArgs e)
        {
            if (TelTom.Text == "Telefono Tomador")
            {
                TelTom.Text = "";
                TelTom.ForeColor = Color.Black;
            }
        }

        private void TelTom_Leave(object sender, EventArgs e)
        {
            if (TelTom.Text == "")
            {
                TelTom.Text = "Telefono Tomador";
                TelTom.ForeColor = Color.DimGray;
            }
        }

        private void EmailTom_Enter(object sender, EventArgs e)
        {
            if (EmailTom.Text == "Email Tomador")
            {
                EmailTom.Text = "";
                EmailTom.ForeColor = Color.Black;
            }
        }

        private void EmailTom_Leave(object sender, EventArgs e)
        {
            if (EmailTom.Text == "")
            {
                EmailTom.Text = "Email Tomador";
                EmailTom.ForeColor = Color.DimGray;
            }
        }

        private void Calendario_Click(object sender, EventArgs e)
        {
            Fechas.ShowDialog();
            Fechas.MandarFechas(FechaNaTom);
        }

        private void DocBen_Enter(object sender, EventArgs e)
        {
            if (DocBen.Text == "Documento Beneficiario")
            {
                DocBen.Text = "";
                DocBen.ForeColor = Color.Black;
            }
        }

        private void DocBen_Leave(object sender, EventArgs e)
        {
            if (DocBen.Text == "")
            {
                DocBen.Text = "Documento Beneficiario";
                DocBen.ForeColor = Color.DimGray;
            }
        }

        private void NomBen_Enter(object sender, EventArgs e)
        {
            if (NomBen.Text == "Nombres Beneficiario")
            {
                NomBen.Text = "";
                NomBen.ForeColor = Color.Black;
            }
        }

        private void NomBen_Leave(object sender, EventArgs e)
        {
            if (NomBen.Text == "")
            {
                NomBen.Text = "Nombres Beneficiario";
                NomBen.ForeColor = Color.DimGray;
            }
        }

        private void ApeBen_Enter(object sender, EventArgs e)
        {
            if (ApeBen.Text == "Apellidos Beneficiario")
            {
                ApeBen.Text = "";
                ApeBen.ForeColor = Color.Black;
            }
        }

        private void ApeBen_Leave(object sender, EventArgs e)
        {
            if (ApeBen.Text == "")
            {
                ApeBen.Text = "Apellidos Beneficiario";
                ApeBen.ForeColor = Color.DimGray;
            }
        }

        private void DirBen_Enter(object sender, EventArgs e)
        {
            if (DirBen.Text == "Direccion Beneficiario")
            {
                DirBen.Text = "";
                DirBen.ForeColor = Color.Black;
            }
        }

        private void DirBen_Leave(object sender, EventArgs e)
        {
            if (DirBen.Text == "")
            {
                DirBen.Text = "Direccion Beneficiario";
                DirBen.ForeColor = Color.DimGray;
            }
        }

        private void TelBen_Enter(object sender, EventArgs e)
        {
            if (TelBen.Text == "Telefono Beneficiario")
            {
                TelBen.Text = "";
                TelBen.ForeColor = Color.Black;
            }
        }

        private void TelBen_Leave(object sender, EventArgs e)
        {
            if (TelBen.Text == "")
            {
                TelBen.Text = "Telefono Beneficiario";
                TelBen.ForeColor = Color.DimGray;
            }
        }

        private void EmailBen_Enter(object sender, EventArgs e)
        {
            if (EmailBen.Text == "Email Beneficiario")
            {
                EmailBen.Text = "";
                EmailBen.ForeColor = Color.Black;
            }
        }

        private void EmailBen_Leave(object sender, EventArgs e)
        {
            if (EmailBen.Text == "")
            {
                EmailBen.Text = "Email Beneficiario";
                EmailBen.ForeColor = Color.DimGray;
            }
        }

        private void CalendarBen_Click(object sender, EventArgs e)
        {
            Fechas.ShowDialog();
            Fechas.MandarFechas(FechaBen);
        }

        private void NumPoliza_Enter(object sender, EventArgs e)
        {
            if (NumPoliza.Text == "Numero de poliza")
            {
                NumPoliza.Text = "";
                NumPoliza.ForeColor = Color.Black;
            }
        }

        private void NumPoliza_Leave(object sender, EventArgs e)
        {
            if (NumPoliza.Text == "")
            {
                NumPoliza.Text = "Numero de poliza";
                NumPoliza.ForeColor = Color.DimGray;
            }
        }

        private void CalendarPol_Click(object sender, EventArgs e)
        {
            Fechas.ShowDialog();
            Fechas.MandarFechas(Vigencia);
        }

        private void CalendarVeh_Click(object sender, EventArgs e)
        {
            Fechas.ShowDialog();
            Fechas.MandarFechas(VigenciaSOAT);
        }

        private void Placa_Enter(object sender, EventArgs e)
        {
            if (Placa.Text == "Placa")
            {
                Placa.Text = "";
                Placa.ForeColor = Color.Black;
            }
        }

        private void Placa_Leave(object sender, EventArgs e)
        {
            if (Placa.Text == "")
            {
                Placa.Text = "Placa";
                Placa.ForeColor = Color.DimGray;
            }
        }

        private void Fasecolda_Enter(object sender, EventArgs e)
        {
            if (Fasecolda.Text == "Fasecolda")
            {
                Fasecolda.Text = "";
                Fasecolda.ForeColor = Color.Black;
            }
        }

        private void Fasecolda_Leave(object sender, EventArgs e)
        {
            if (Fasecolda.Text == "")
            {
                Fasecolda.Text = "Fasecolda";
                Fasecolda.ForeColor = Color.DimGray;
            }
        }

        private void Servicio_Enter(object sender, EventArgs e)
        {
            if (Servicio.Text == "Servicio")
            {
                Servicio.Text = "";
                Servicio.ForeColor = Color.Black;
            }
        }

        private void Servicio_Leave(object sender, EventArgs e)
        {
            if (Servicio.Text == "")
            {
                Servicio.Text = "Servicio";
                Servicio.ForeColor = Color.DimGray;
            }
        }

        private void Clase_Enter(object sender, EventArgs e)
        {
            if (Clase.Text == "Clase")
            {
                Clase.Text = "";
                Clase.ForeColor = Color.Black;
            }
        }

        private void Clase_Leave(object sender, EventArgs e)
        {
            if (Clase.Text == "")
            {
                Clase.Text = "Clase";
                Clase.ForeColor = Color.DimGray;
            }
        }

        private void Marca_Enter(object sender, EventArgs e)
        {
            if (Marca.Text == "Marca")
            {
                Marca.Text = "";
                Marca.ForeColor = Color.Black;
            }
        }

        private void Marca_Leave(object sender, EventArgs e)
        {
            if (Marca.Text == "")
            {
                Marca.Text = "Marca";
                Marca.ForeColor = Color.DimGray;
            }
        }
        // AQUI TERMINAN LOS PLACEHOLDERS

        private void Agregar_poliza_Load(object sender, EventArgs e)
        {
            // OCULTANDO TAB VEHICULO
            //Vehiculo.Parent = null;
        }

        private void ActualizarPol_Click(object sender, EventArgs e)
        {
            if (NumPoliza.Text == "Numero de poliza")
            {
                MessageBox.Show("Digite un numero de poliza");
            }
            else if (TpPoliza.Text.Equals("-- SELECCIONE UN TIPO DE POLIZA --"))
            {
                MessageBox.Show("Seleccione un tipo de poliza");
            }
            else if (Ase.Text.Equals("-- SELECCIONE UNA ASEGURADORA --"))
            {
                MessageBox.Show("Seleccione una aseguradora");
            }
            else if (Vigencia.Text.Equals("Fecha Vigencia"))
            {
                MessageBox.Show("Seleccione una fecha de vigencia final");
            }
            else if (VigenciaIni.Text.Equals("Fecha Vigencia Inicial"))
            {
                MessageBox.Show("Seleccione una fecha de vigencia inicial");
            }
            // UPDATE POLIZA
            string query = "update poliza set polVigenciaInicial='"+VigenciaIni.Text+"', polVigenciaFinal='" + Vigencia.Text + "', polValorPrima='"+ValorPrima.Text+"' WHERE pol_NumeroPoliza='" + NumPoliza.Text + "'";

            if (Metodos.Insertar_Datos_Poliza_General(query))
            {
                MessageBox.Show("Actualizo la poliza correctamente", "SATISFACTORIO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (TpPoliza.SelectedItem.Equals("AUTOS"))
                {
                    DatoNumPol = NumPoliza.Text;
                    // MOSTRANDO TAB SI ES TIPO DE POLIZA AUTOS
                    Vehiculo.Parent = Contenido;
                    Contenido.SelectedTab = Vehiculo;
                }
                else
                {
                    this.Close(); //NO MODIFICA EL PROCESO SI NO CUMPLE LA CONDICION
                }
            }
            else
            {
                MessageBox.Show("Error al actualizar la poliza", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void GuardarPol_Click(object sender, EventArgs e)
        {
            if (NumPoliza.Text=="Numero de poliza")
            {
                MessageBox.Show("Digite un numero de poliza");
            }
            else if (TpPoliza.Text.Equals("-- SELECCIONE UN TIPO DE POLIZA --"))
            {
                MessageBox.Show("Seleccione un tipo de poliza");
            }
            else if (Ase.Text.Equals("-- SELECCIONE UNA ASEGURADORA --"))
            {
                MessageBox.Show("Seleccione una aseguradora");
            }
            else if (Vigencia.Text.Equals("Fecha Vigencia Final"))
            {
                MessageBox.Show("Seleccione una fecha de vigencia final");
            }
            else if (VigenciaIni.Text.Equals("Fecha Vigencia Inicial"))
            {
                MessageBox.Show("Seleccione una fecha de vigencia inicial");
            }
            int ComboboxCorrectoTP = TpPoliza.SelectedIndex + 1;
            string DatosTP = ComboboxCorrectoTP.ToString();

            int ComboboxCorrectoAse = Ase.SelectedIndex + 1;
            string DatosAse = ComboboxCorrectoAse.ToString();

            //// INSERT POLIZA
            string query = "insert into poliza(pol_NumeroPoliza,tipo_poliza_tipIdRamo,aseguradora_aseId,tomador_tomDocumento,beneficiario_benDocumento,polVigenciaInicial,polVigenciaFinal,polValorPrima)" +
            " values('" + NumPoliza.Text + "','" + DatosTP + "','" + DatosAse + "','" + DocTom.Text + "','" + DocBen.Text + "','" + VigenciaIni.Text + "','"+Vigencia.Text+"','"+ValorPrima.Text+"')";

            if (Metodos.Insertar_Datos_Poliza_General(query))
            {
                MessageBox.Show("Ingreso la poliza correctamente", "SATISFACTORIO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (TpPoliza.SelectedItem.Equals("AUTOS"))
                {
                    DatoNumPol = NumPoliza.Text;
                    // MOSTRANDO TAB SI ES TIPO DE POLIZA AUTOS
                    Vehiculo.Parent = Contenido;
                    Contenido.SelectedTab = Vehiculo;
                }
                else
                {
                    this.Close(); //NO MODIFICA EL PROCESO SI NO CUMPLE LA CONDICION
                }
            }
            else
            {
                MessageBox.Show("Error al ingresar la poliza", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // ACTUALIZAR AUTOMATICAMENTE POLIZA SI ESTA ACTIVA O INACTIVA
            string PolqueryActivo = "UPDATE poliza p set p.polEstado = 'ACTIVO'where p.polVigenciaFinal >= NOW()";
            Metodos.Insertar_Datos_Poliza_General(PolqueryActivo);
            string PolqueryInactivo = "UPDATE poliza p set p.polEstado = 'INACTIVO'where p.polVigenciaFinal < NOW()";
            Metodos.Insertar_Datos_Poliza_General(PolqueryInactivo);
            // FINALIZACION POLIZA UPDATE

            //ACTUALIZAR ACTIVO O INACTIVO EN VEHICULOS
            string SOATqueryActivo = "UPDATE vehiculo v set v.veh_soat_estado = 'ACTIVO'where v.vehVigenciaSOAT >= NOW()";
            Metodos.Insertar_Datos_Poliza_General(SOATqueryActivo);
            string SOATqueryInactivo = "UPDATE vehiculo v set v.veh_soat_estado = 'INACTIVO'where v.vehVigenciaSOAT < NOW()";
            Metodos.Insertar_Datos_Poliza_General(SOATqueryInactivo);
            // FIN
        }

        private void GuardarVeh_Click(object sender, EventArgs e)
        {
            if (Placa.Text.Equals("Placa"))
            {
                MessageBox.Show("Digite una placa");
            }
            else if (Fasecolda.Text.Equals("Fasecolda"))
            {
                MessageBox.Show("Digite un fasecolda");
            }
            else if (Servicio.Text.Equals("Servicio"))
            {
                MessageBox.Show("Digite un tipo de servicio");
            }
            else if (Clase.Text.Equals("Clase"))
            {
                MessageBox.Show("Digite una clase del vehiculo");
            }
            else if (Marca.Text.Equals("Marca"))
            {
                MessageBox.Show("Digite una marca del vehiculo");
            }
            else if (VigenciaSOAT.Text.Equals("Fecha vigencia SOAT"))
            {
                MessageBox.Show("Ingrese una fecha de vigencia del SOAT");
            }
            else if (ValorAuto.Text.Equals("Valor del vehiculo"))
            {
                MessageBox.Show("Ingrese un valor del vehiculo");
            }
            // FINALIZACION DE VALIDACION
            else
            {
            // INSERT VEHICULO
            string query = "insert into vehiculo (vehPlaca,vehModelo,vehFasecolda,vehServicio,vehClase,vehMarca,vehValorAuto,vehVigenciaSOAT)" +
                   " values('" + Placa.Text + "','" + Modelo.Text + "','" + Fasecolda.Text + "','" + Servicio.Text + "','" + Clase.Text + "','" + Marca.Text + "','"+ValorAuto.Text+"','" + VigenciaSOAT.Text + "')";
            if (Metodos.Insertar_Datos_Poliza_General(query))
            {

                MessageBox.Show("Añadio vehiculo satisfactoriamente", "INGRESO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // CREANDO INMEDIATAMENTE LA RELACION CON LA TABLA POL_VEH

                string query2 = "insert into pol_veh(poliza_pol_NumeroPoliza,vehiculo_vehPlaca) values('" + NumPoliza.Text + "','" + Placa.Text + "')";
                Metodos.Insertar_Datos_Poliza_General(query2);

                this.Close();
            }
            else
            {
                MessageBox.Show("Error al ingresar vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
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

        private void GuardarTom_Click(object sender, EventArgs e)
        {
            // VALIDANDO CAMPOS VACIOS
            if (DocTom.Text.Equals("Documento Tomador"))
            {
                MessageBox.Show("Digite un documento del tomador");
            }
            else if (TipoDocTom.Text.Equals("-- SELECCIONE UN TIPO DE DOCUMENTO --"))
            {
                MessageBox.Show("Seleccione un tipo de documento");
            }
            else if (NomTom.Text.Equals("Nombres Tomador"))
            {
                MessageBox.Show("Digite los nombres del tomador");
            }
            else if (ApeTom.Text.Equals("Apellidos Tomador"))
            {
                MessageBox.Show("Digite los apellidos del tomador");
            }
            else if (DirTom.Text.Equals("Direccion Tomador"))
            {
                MessageBox.Show("Digite una direccion del tomador");
            }
            else if (TelTom.Text.Equals("Telefono Tomador"))
            {
                MessageBox.Show("Digite un telefono del tomador");
            }
            else if (EmailTom.Text.Equals("Email Tomador"))
            {
                MessageBox.Show("Digite un email del tomador");
            }
            else if (FechaNaTom.Text.Equals("Fecha de Nacimiento"))
            {
                MessageBox.Show("Ingrese una fecha de nacimiento");
            }
            // FINALIZACION DE VALIDACION
            else
            {
            
            // INSERT DATOS TOM
            string query = "insert into tomador (tomDocumento,tomTipoDocumento,tomNombres,tomApellidos,tomDireccion,tomTelefono,tomEmail,tomFechaNacimiento) " +
            "values ('" + DocTom.Text + "','" + TipoDocTom.SelectedItem.ToString() + "','" + NomTom.Text + "','" + ApeTom.Text + "','" + DirTom.Text + "','" + TelTom.Text + "','" + EmailTom.Text + "','" + FechaNaTom.Text + "')";

            if (Metodos.Insertar_Datos_Poliza_General(query))
            {
                MessageBox.Show("Tomador Ingresado correctamente", "SATISFACTORIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Contenido.SelectedTab = Beneficiario;
            }
            else
            {
                MessageBox.Show("Error al ingresar Tomador","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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
        }

        private void GuardarBen_Click(object sender, EventArgs e)
        {
            // VALIDANDO CAMPOS VACIOS
            if (DocBen.Text.Equals("Documento Beneficiario"))
            {
                MessageBox.Show("Digite un documento del beneficiario");
            }
            else if (TipoDocBen.Text.Equals("-- SELECCIONE UN TIPO DE DOCUMENTO --"))
            {
                MessageBox.Show("Seleccione un tipo de documento");
            }
            else if (NomBen.Text.Equals("Nombres Beneficiario"))
            {
                MessageBox.Show("Digite los nombres del beneficiario");
            }
            else if (ApeBen.Text.Equals("Apellidos Beneficiario"))
            {
                MessageBox.Show("Digite los apellidos del beneficiario");
            }
            else if (DirBen.Text.Equals("Direccion Beneficiario"))
            {
                MessageBox.Show("Digite una direccion del beneficiario");
            }
            else if (TelBen.Text.Equals("Telefono Beneficiario"))
            {
                MessageBox.Show("Digite un telefono del beneficiario");
            }
            else if (EmailBen.Text.Equals("Email Beneficiario"))
            {
                MessageBox.Show("Digite un email del beneficiario");
            }
            else if (FechaBen.Text.Equals("Fecha de Nacimiento"))
            {
                MessageBox.Show("Ingrese una fecha de nacimiento");
            }
            // FINALIZACION DE VALIDACION
            else
            {
            // INSERT DATOS BEN
            string query = "insert into beneficiario(benDocumento,benTipoDoc,benNombres,benApellidos,benDireccion,benTelefono,benEmail,benFechaNacimiento)" +
            "values ('" + DocBen.Text + "','" + TipoDocBen.SelectedItem.ToString() + "','" + NomBen.Text + "','" + ApeBen.Text + "','" + DirBen.Text + "','" + TelBen.Text + "','" + EmailBen.Text + "','" + FechaBen.Text + "')";

            if (Metodos.Insertar_Datos_Poliza_General(query))
            {
                MessageBox.Show("Beneficiario Ingresado correctamente", "SATISFACTORIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Contenido.SelectedTab = Poliza;
            }
                else
            {
                MessageBox.Show("Error al ingresar Beneficiario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // FINALIZACION DEL INSERTAR
            }
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

        private void ActualizarTom_Click(object sender, EventArgs e)
        {
            // VALIDANDO CAMPOS VACIOS
            if (DocTom.Text.Equals("Documento Tomador"))
            {
                MessageBox.Show("Digite un documento del tomador");
            }
            else if (TipoDocTom.Text.Equals("-- SELECCIONE UN TIPO DE DOCUMENTO --"))
            {
                MessageBox.Show("Seleccione un tipo de documento");
            }
            else if (NomTom.Text.Equals("Nombres Tomador"))
            {
                MessageBox.Show("Digite los nombres del tomador");
            }
            else if (ApeTom.Text.Equals("Apellidos Tomador"))
            {
                MessageBox.Show("Digite los apellidos del tomador");
            }
            else if (DirTom.Text.Equals("Direccion Tomador"))
            {
                MessageBox.Show("Digite una direccion del tomador");
            }
            else if (TelTom.Text.Equals("Telefono Tomador"))
            {
                MessageBox.Show("Digite un telefono del tomador");
            }
            else if (EmailTom.Text.Equals("Email Tomador"))
            {
                MessageBox.Show("Digite un email del tomador");
            }
            else if (FechaNaTom.Text.Equals("Fecha de Nacimiento"))
            {
                MessageBox.Show("Ingrese una fecha de nacimiento");
            }
            // FINALIZACION DE VALIDACION
            else
            {
                // UPDATE DATOS TOM
                string query = "update tomador set tomTipoDocumento='" + TipoDocTom.SelectedItem.ToString() + "', tomNombres='" + NomTom.Text + "', tomApellidos='" + ApeTom.Text + "', tomDireccion='" + DirTom.Text + "', tomTelefono='" + TelTom.Text + "', tomEmail='" + EmailTom.Text + "', tomFechaNacimiento='" + FechaNaTom.Text + "' WHERE tomDocumento='" + DocTom.Text + "'";

                if (Metodos.Insertar_Datos_Poliza_General(query))
                {
                    MessageBox.Show("Tomador actualizado correctamente", "SATISFACTORIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Contenido.SelectedTab = Beneficiario;
                }
                else
                {
                    MessageBox.Show("Error al actualizar Tomador", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // FINALIZACION DEL UPDATE
            }
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

        private void ActualizarBen_Click(object sender, EventArgs e)
        {
            // VALIDANDO CAMPOS VACIOS
            if (DocBen.Text.Equals("Documento Beneficiario"))
            {
                MessageBox.Show("Digite un documento del beneficiario");
            }
            else if (TipoDocBen.Text.Equals("-- SELECCIONE UN TIPO DE DOCUMENTO --"))
            {
                MessageBox.Show("Seleccione un tipo de documento");
            }
            else if (NomBen.Text.Equals("Nombres Beneficiario"))
            {
                MessageBox.Show("Digite los nombres del beneficiario");
            }
            else if (ApeBen.Text.Equals("Apellidos Beneficiario"))
            {
                MessageBox.Show("Digite los apellidos del beneficiario");
            }
            else if (DirBen.Text.Equals("Direccion Beneficiario"))
            {
                MessageBox.Show("Digite una direccion del beneficiario");
            }
            else if (TelBen.Text.Equals("Telefono Beneficiario"))
            {
                MessageBox.Show("Digite un telefono del beneficiario");
            }
            else if (EmailBen.Text.Equals("Email Beneficiario"))
            {
                MessageBox.Show("Digite un email del beneficiario");
            }
            else if (FechaBen.Text.Equals("Fecha de Nacimiento"))
            {
                MessageBox.Show("Ingrese una fecha de nacimiento");
            }
            // FINALIZACION DE VALIDACION
            else
            {
                //  ACTUALIZANDO BENEFICIARIO

                string query = "update beneficiario set benTipoDoc='" + TipoDocBen.SelectedItem.ToString() + "', benNombres='" + NomBen.Text + "', benApellidos='" + ApeBen.Text + "', benDireccion='" + DirBen.Text + "', benTelefono='" + TelBen.Text + "', benEmail='" + EmailBen.Text + "', benFechaNacimiento='" + FechaBen.Text + "' WHERE benDocumento='" + DocBen.Text + "'";
                if (Metodos.Insertar_Datos_Poliza_General(query))
                {
                    MessageBox.Show("Beneficiario actualizado correctamente", "SATISFACTORIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Contenido.SelectedTab = Poliza;
                }
                else
                {
                    MessageBox.Show("Error al actualizar Beneficiario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void ActualizarVeh_Click(object sender, EventArgs e)
        {
            if (Fasecolda.Text.Equals("Fasecolda"))
            {
                MessageBox.Show("Digite un fasecolda");
            }
            else if (Servicio.Text.Equals("Servicio"))
            {
                MessageBox.Show("Digite un servicio para el auto");
            }
            else if (Clase.Text.Equals("Clase"))
            {
                MessageBox.Show("Digite una clase para el vehiculo");
            }
            else if (Marca.Text.Equals("Marca"))
            {
                MessageBox.Show("Digite una marca para el vehiculo");
            }
            else if (VigenciaSOAT.Text.Equals("Fecha vigencia SOAT"))
            {
                MessageBox.Show("Seleccione una fecha de vigencia");
            }
            else if (ValorAuto.Text.Equals("Valor del vehiculo"))
            {
                MessageBox.Show("Digite un valor para el vehiculo");

            }
            else
            {
            string query = "update vehiculo set vehModelo='" + Modelo.Text + "', vehFasecolda='" + Fasecolda.Text + "', vehServicio='" + Servicio.Text + "', vehClase='" + Clase.Text + "', vehMarca='" + Marca.Text + "', vehValorAuto='"+ValorAuto.Text+"', vehVigenciaSOAT='" + VigenciaSOAT.Text + "' WHERE vehPlaca='" + Placa.Text + "'";
            if (Metodos.Insertar_Datos_Poliza_General(query))
            {
                MessageBox.Show("Vehiculo actualizado correctamente", "SATISFACTORIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar Vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
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

        private void CalendarPolIni_Click(object sender, EventArgs e)
        {
            Fechas.ShowDialog();
            Fechas.MandarFechas(VigenciaIni);
        }

        private void ValorPrima_Enter(object sender, EventArgs e)
        {
            if (ValorPrima.Text == "Valor Prima")
            {
                ValorPrima.Text = "";
                ValorPrima.ForeColor = Color.Black;
            }
        }

        private void ValorPrima_Leave(object sender, EventArgs e)
        {
            if (ValorPrima.Text == "")
            {
                ValorPrima.Text = "Valor Prima";
                ValorPrima.ForeColor = Color.DimGray;
            }
        }

        private void ValorAuto_Enter(object sender, EventArgs e)
        {
            if (ValorAuto.Text == "Valor del vehiculo")
            {
                ValorAuto.Text = "";
                ValorAuto.ForeColor = Color.Black;
            }
        }

        private void ValorAuto_Leave(object sender, EventArgs e)
        {
            if (ValorAuto.Text == "")
            {
                ValorAuto.Text = "Valor del vehiculo";
                ValorAuto.ForeColor = Color.DimGray;
            }
        }

        private void Placa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.AlphaNumerico(e);
        }

        private void Fasecolda_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloNumeros(e);
        }

        private void Servicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloLetras(e);
        }

        private void Clase_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloLetras(e);
        }

        private void Marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloLetras(e);
        }

        private void ValorAuto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloNumeros(e);
        }

        private void NumPoliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloNumeros(e);
        }

        private void ValorPrima_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloNumeros(e);
        }

        private void DocBen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloNumeros(e);
        }

        private void NomBen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloLetras(e);
        }

        private void ApeBen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloLetras(e);
        }

        private void DirBen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.AlphaNumerico(e);
        }

        private void TelBen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloNumeros(e);
        }

        private void EmailBen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.Validar_Email(e);
        }

        private void DocTom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloNumeros(e);
        }

        private void NomTom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloLetras(e);
        }

        private void ApeTom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloLetras(e);
        }

        private void DirTom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.AlphaNumerico(e);
        }

        private void TelTom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloNumeros(e);
        }

        private void EmailTom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.Validar_Email(e);
        }
    }
}
