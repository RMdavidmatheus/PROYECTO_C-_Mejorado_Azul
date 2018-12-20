using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_logica
{
    public class Logica_Metodos
    {
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
            MySqlCommand query = new MySqlCommand("select p.tipo_poliza_tipIdRamo , p.aseguradora_aseId from poliza p where p.pol_NumeroPoliza = '" + Num_pol + "' ", bd.GetConnection());
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
            MySqlCommand query = new MySqlCommand("select v.vehModelo, v.vehFasecolda, v.vehServicio, v.vehClase, v.vehMarca, v.vehVigenciaSOAT from vehiculo v where v.vehPlaca = '" + Placa + "' ", bd.GetConnection());
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
    }
}
