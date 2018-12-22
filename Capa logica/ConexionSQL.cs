using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Capa_logica
{
    class ConexionSQL
    {
        //MySqlConnection conexionBase = new MySqlConnection("server=localhost;user id=root;password=;persistsecurityinfo=True;port=3306;database=proyecto_omb;SslMode=none");
        MySqlConnection conexionBase = new MySqlConnection("server=proyecto-omb.mysql.database.azure.com;user id=DavidAlejandro@proyecto-omb;password=Davidale98;persistsecurityinfo=True;port=3306;database=proyecto_omb;SslMode=none");

        public void ObtenerConexion()
        {
            try
            {
                conexionBase.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void DesconectarBase()
        {
            try
            {
                conexionBase.Close();

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public MySqlConnection GetConnection()
        {
            return conexionBase;
        }
    }
}
