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
    public partial class Listado_polizas : Form
    {
        public Listado_polizas()
        {
            InitializeComponent();
            Listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string Titulo_Añadir = Anadir.Text;
            string Titulo_Editar = Editar.Text;
        }
        /*SELECCION DE PLACA DE LA TABLA POL_VEH */     private string PlacaVeh;
        /*SELECCION DE ID ASE Y TIPO POLIZA*/           private int seleccionTP, seleccionAse;
        private string DocumentoBen;
        private string DocumentoTom;
        Capa_logica.Logica_Metodos Metodos = new Capa_logica.Logica_Metodos();
        private void Listado_polizas_Load(object sender, EventArgs e)
        {
            Metodos.LlenarTabla_Poliza(Listado);
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            // INSTANCIANDO FRAME AGREGAR
            Agregar_poliza Añadir = new Agregar_poliza(Anadir.Text);
            Añadir.Vehiculo.Parent = null;
            this.SendToBack();
            Añadir.ActualizarTom.Visible = false;
            Añadir.ActualizarBen.Visible = false;
            Añadir.ActualizarPol.Visible = false;
            Añadir.ActualizarVeh.Visible = false;
            Añadir.ShowDialog();

            // REFRESCANDO TABLA
            if (Añadir.Visible==false)
            {
                Metodos.LlenarTabla_Poliza(Listado);
            }
            else
            {
                Metodos.LlenarTabla_Poliza(Listado);
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            Agregar_poliza Editar = new Agregar_poliza(this.Editar.Text);
            Editar.Vehiculo.Parent = null;
            this.SendToBack();

            if (Listado.SelectedRows.Count > 0)
            {
            // OCULTANDO BOTON GUARDAR, EVITANDO MODIFICAR LLAVES PRIMARIAS DEL REGISTRO...
            Editar.GuardarTom.Visible = false;
            Editar.GuardarBen.Visible = false;
            Editar.GuardarPol.Visible = false;
            Editar.GuardarVeh.Visible = false;
            Editar.DocTom.Enabled = false;
            Editar.DocBen.Enabled = false;
            Editar.NumPoliza.Enabled = false;
            Editar.Placa.Enabled = false;

                // EXTRAYENDO DATOS DESDE EL DATAGRID PARA LLENAR DATOS AL ACTUALIZAR
                Editar.DocTom.Text = Listado.CurrentRow.Cells[3].Value.ToString();
                Editar.TipoDocTom.Text = Listado.CurrentRow.Cells[4].Value.ToString();

                Editar.TelTom.Text = Listado.CurrentRow.Cells[6].Value.ToString();
                Editar.TelTom.ForeColor = Color.Black;

                Editar.DocBen.Text = Listado.CurrentRow.Cells[7].Value.ToString();
                Editar.TipoDocBen.Text = Listado.CurrentRow.Cells[8].Value.ToString();

                Editar.TelBen.Text = Listado.CurrentRow.Cells[10].Value.ToString();
                Editar.TelBen.ForeColor = Color.Black;

                Editar.NumPoliza.Text = Listado.CurrentRow.Cells[0].Value.ToString();
                Editar.Estado.Text = Listado.CurrentRow.Cells[12].Value.ToString();
                Editar.Vigencia.Text = Listado.CurrentRow.Cells[11].Value.ToString();

                // EXTRAYENDO DATOS QUE NO ESTAN EN EL DATAGRID, POLIZA
                DataTable dt4 = Metodos.Extraer_Pol(Editar.NumPoliza.Text);
                if (dt4.Rows.Count > 0)
                {
                    DataRow row = dt4.Rows[0];
                    seleccionTP = Convert.ToInt32(row["tipo_poliza_tipIdRamo"]);
                    seleccionAse = Convert.ToInt32(row["aseguradora_aseId"]);
                    Editar.TpPoliza.SelectedIndex = seleccionTP-1; 
                    Editar.Ase.SelectedIndex = seleccionAse-1;
                }
                //PONIENDO VISIBLE LA PESTAÑA VEHICULO CUANDO LA POLIZA ES EXCLUSIVAMENTE DE AUTOS
                if (Editar.TpPoliza.SelectedItem.Equals("AUTOS"))
                {
                    Editar.Vehiculo.Parent = Editar.Contenido;
                    //EXTRAYENDO PLACA DE LA POLIZA PARA ACTUALIZAR DATOS DEL VEHICULO
                    DataTable dt1 = Metodos.Extraer_Pol_Veh(Editar.NumPoliza.Text);
                    if (dt1.Rows.Count > 0)
                    {
                        DataRow row = dt1.Rows[0];
                        PlacaVeh = Convert.ToString(row["vehiculo_vehPlaca"]);
                        Editar.Placa.Text = PlacaVeh;
                    }
                    // EXTRAYENDO DATOS DE LA TABLA VEHICULOS
                    DataTable dt9 = Metodos.Extraer_Veh(PlacaVeh);
                    if (dt9.Rows.Count > 0)
                    {
                        DataRow row = dt9.Rows[0];

                        Editar.Modelo.Value = Convert.ToDateTime(row["vehModelo"]+"-12-24");
                        Editar.Fasecolda.Text = Convert.ToString(row["vehFasecolda"]);
                        Editar.Fasecolda.ForeColor = Color.Black;
                        Editar.Servicio.Text = Convert.ToString(row["vehServicio"]);
                        Editar.Servicio.ForeColor = Color.Black;
                        Editar.Clase.Text = Convert.ToString(row["vehClase"]);
                        Editar.Clase.ForeColor = Color.Black;
                        Editar.Marca.Text = Convert.ToString(row["vehMarca"]);
                        Editar.Marca.ForeColor = Color.Black;
                        // FORMATO DE FECHA VIG SOAT
                        Editar.VigenciaSOAT.Text = Convert.ToDateTime(row["vehVigenciaSOAT"]).ToString("yyyy-MM-dd");
                    }
                }

                //EXTRAYENDO DATOS FALTANTES DESDE LA BASE DE DATOS, TOMADOR
                DataTable dt2 = Metodos.Extraer_Tom(Editar.DocTom.Text);
                if (dt2.Rows.Count > 0)
                {
                    DataRow row = dt2.Rows[0];
                    Editar.NomTom.Text = Convert.ToString(row["tomNombres"]);
                    Editar.NomTom.ForeColor = Color.Black;

                    Editar.ApeTom.Text = Convert.ToString(row["tomApellidos"]);
                    Editar.ApeTom.ForeColor = Color.Black;

                    Editar.DirTom.Text = Convert.ToString(row["tomDireccion"]);
                    Editar.DirTom.ForeColor = Color.Black;

                    Editar.EmailTom.Text = Convert.ToString(row["tomEmail"]);
                    Editar.EmailTom.ForeColor = Color.Black;

                    // CONVIRTIENDO A FORMATO DE FECHA CORRECTO
                    Editar.FechaNaTom.Text = Convert.ToDateTime(row["tomFechaNacimiento"]).ToString("yyyy-MM-dd");
                    Editar.FechaNaTom.ForeColor = Color.Black;
                }

                //EXTRAYENDO DATOS FALTANTES DESDE LA BASE DE DATOS, BENEFICIARIO
                DataTable dt3 = Metodos.Extraer_Ben(Editar.DocBen.Text);
                if (dt3.Rows.Count > 0)
                {
                    DataRow row = dt3.Rows[0];
                    Editar.NomBen.Text = Convert.ToString(row["benNombres"]);
                    Editar.NomBen.ForeColor = Color.Black;

                    Editar.ApeBen.Text = Convert.ToString(row["benApellidos"]);
                    Editar.ApeBen.ForeColor = Color.Black;

                    Editar.DirBen.Text = Convert.ToString(row["benDireccion"]);
                    Editar.DirBen.ForeColor = Color.Black;

                    Editar.EmailBen.Text = Convert.ToString(row["benEmail"]);
                    Editar.EmailBen.ForeColor = Color.Black;

                    // CONVIRTIENDO A FORMATO DE FECHA CORRECTO
                    Editar.FechaBen.Text = Convert.ToDateTime(row["benFechaNacimiento"]).ToString("yyyy-MM-dd");
                }
                Editar.ShowDialog();
                // RESTAURANDO VALORES
                PlacaVeh = "";
                //RESTAURANDO VALORES A LAS VARIABLES
                seleccionTP = 0;
                seleccionAse = 0;
            }
            else
            {
                MessageBox.Show("Seleccione una columna","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            // REFRESCANDO TABLA
            if (Editar.Visible == false)
            {
                Metodos.LlenarTabla_Poliza(Listado);
            }
            else
            {
                Metodos.LlenarTabla_Poliza(Listado);
            }
        }

        private void Buscar_Enter(object sender, EventArgs e)
        {
            if (Buscar.Text == "Buscar...")
            {
                Buscar.Text = "";
                Buscar.ForeColor = Color.Black;
            }
        }

        private void Buscar_Leave(object sender, EventArgs e)
        {
            if (Buscar.Text != "Buscar...")
            {
                Buscar.Text = "Buscar...";
                Buscar.ForeColor = Color.DimGray;
            }
        }

        private void Listado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.Listado.Columns[e.ColumnIndex].Name == "Estado")
            {
                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {


                        if (e.Value.ToString().Equals("ACTIVO"))
                        {
                            e.CellStyle.BackColor = Color.LightGreen;

                        }

                        if (e.Value.ToString().Equals("INACTIVO"))
                        {
                            e.CellStyle.BackColor = Color.IndianRed;
                        }

                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void Buscar_KeyUp(object sender, KeyEventArgs e)
        {
            Metodos.Buscar_Poliza(Listado,Buscar.Text);
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            DocumentoBen = Listado.CurrentRow.Cells[7].Value.ToString();
            DocumentoTom = Listado.CurrentRow.Cells[3].Value.ToString();
            // SI ES POLIZA DE AUTOS
            if (Listado.CurrentRow.Cells[1].Value.ToString().Equals("AUTOS"))
            {

                DataTable dt5 = Metodos.Extraer_Pol_Veh(Listado.CurrentRow.Cells[0].Value.ToString());
                if (dt5.Rows.Count > 0)
                {
                    DataRow row = dt5.Rows[0];
                    PlacaVeh = Convert.ToString(row["vehiculo_vehPlaca"]);
                }
                //ELIMINANDO RELACION POL_VEH
                string query = "DELETE FROM pol_veh WHERE  poliza_pol_NumeroPoliza='" + Listado.CurrentRow.Cells[0].Value.ToString() + "' AND vehiculo_vehPlaca='" + PlacaVeh + "' ";
                if (Metodos.Eliminar_Datos(query))
                {
                    MessageBox.Show("Relacion Poliza-Vehiculo Eliminada Correctamente");
                    //Metodos.LlenarTabla_Poliza(Listado);

                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Relacion");
                    //Metodos.LlenarTabla_Poliza(Listado);

                }
                // ELIMINANDO VEHICULO
                string queryVeh = "DELETE FROM vehiculo WHERE vehPlaca='" + PlacaVeh + "' ";
                if (Metodos.Eliminar_Datos(queryVeh))
                {
                    MessageBox.Show("Vehiculo Eliminado Correctamente");
                    //Metodos.LlenarTabla_Poliza(Listado);

                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Vehiculo");
                    //Metodos.LlenarTabla_Poliza(Listado);

                }
                // EXTRAYENDO DATOS QUE NO ESTAN EN EL DATAGRID, POLIZA
                DataTable dt4 = Metodos.Extraer_Pol(Listado.CurrentRow.Cells[0].Value.ToString());
                if (dt4.Rows.Count > 0)
                {
                    DataRow row = dt4.Rows[0];
                    seleccionTP = Convert.ToInt32(row["tipo_poliza_tipIdRamo"]);
                    seleccionAse = Convert.ToInt32(row["aseguradora_aseId"]);
                }
                //ELIMINANDO POLIZA
                string querypol = "DELETE FROM poliza WHERE  pol_NumeroPoliza='" + Listado.CurrentRow.Cells[0].Value.ToString() + "' AND tipo_poliza_tipIdRamo='" + seleccionTP + "' AND aseguradora_aseId='" + seleccionAse + "' AND tomador_tomDocumento='" + Listado.CurrentRow.Cells[3].Value.ToString() + "' AND beneficiario_benDocumento='" + Listado.CurrentRow.Cells[7].Value.ToString() + "' ";
                if (Metodos.Eliminar_Datos(querypol))
                {
                    MessageBox.Show("Poliza Eliminada Correctamente");
                    //Metodos.LlenarTabla_Poliza(Listado);


                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Poliza");
                    //Metodos.LlenarTabla_Poliza(Listado);

                }

                //ELIMINANDO TOMADOR
                string querytom = "DELETE FROM tomador WHERE  tomDocumento= '" + DocumentoTom + "'    ";
                if (Metodos.Eliminar_Datos(querytom))
                {
                    MessageBox.Show("Tomador Eliminado Correctamente");
                    //Metodos.LlenarTabla_Poliza(Listado);
                    DocumentoTom = "";

                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Tomador");
                    //Metodos.LlenarTabla_Poliza(Listado);

                }

                //ELIMINANDO BENEFICIARIO
                string queryben = "DELETE FROM beneficiario WHERE  benDocumento= '" + DocumentoBen + "'   ";
                if (Metodos.Eliminar_Datos(queryben))
                {
                    MessageBox.Show("Beneficiario Eliminado Correctamente");
                    //Metodos.LlenarTabla_Poliza(Listado);
                    DocumentoBen = "";

                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Beneficiario");
                    //Metodos.LlenarTabla_Poliza(Listado);

                }

            }
            else
            {
                // EXTRAYENDO DATOS QUE NO ESTAN EN EL DATAGRID, POLIZA
                DataTable dt4 = Metodos.Extraer_Pol(Listado.CurrentRow.Cells[0].Value.ToString());
                if (dt4.Rows.Count > 0)
                {
                    DataRow row = dt4.Rows[0];
                    seleccionTP = Convert.ToInt32(row["tipo_poliza_tipIdRamo"]);
                    seleccionAse = Convert.ToInt32(row["aseguradora_aseId"]);
                }
                //ELIMINANDO POLIZA
                string querypol = "DELETE FROM poliza WHERE  pol_NumeroPoliza='" + Listado.CurrentRow.Cells[0].Value.ToString() + "' AND tipo_poliza_tipIdRamo='" + seleccionTP + "' AND aseguradora_aseId='" + seleccionAse + "' AND tomador_tomDocumento='" + Listado.CurrentRow.Cells[3].Value.ToString() + "' AND beneficiario_benDocumento='" + Listado.CurrentRow.Cells[7].Value.ToString() + "' ";
                if (Metodos.Eliminar_Datos(querypol))
                {
                    MessageBox.Show("Poliza Eliminada Correctamente");
                    //Metodos.LlenarTabla_Poliza(Listado);


                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Poliza");
                    //Metodos.LlenarTabla_Poliza(Listado);

                }

                //ELIMINANDO TOMADOR
                string querytom = "DELETE FROM tomador WHERE  tomDocumento= '" + DocumentoTom + "'    ";
                if (Metodos.Eliminar_Datos(querytom))
                {
                    MessageBox.Show("Tomador Eliminado Correctamente");
                    //Metodos.LlenarTabla_Poliza(Listado);
                    DocumentoTom = "";

                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Tomador");
                    //Metodos.LlenarTabla_Poliza(Listado);

                }

                //ELIMINANDO BENEFICIARIO
                string queryben = "DELETE FROM beneficiario WHERE  benDocumento= '" + DocumentoBen + "'   ";
                if (Metodos.Eliminar_Datos(queryben))
                {
                    MessageBox.Show("Beneficiario Eliminado Correctamente");
                    //Metodos.LlenarTabla_Poliza(Listado);

                    DocumentoBen = "";
                }
                else
                {
                    MessageBox.Show("ERROR al eliminar Beneficiario");

                }
            }
                    Metodos.LlenarTabla_Poliza(Listado);
        }
    }
    
}
