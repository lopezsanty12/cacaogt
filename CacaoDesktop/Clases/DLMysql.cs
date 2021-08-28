using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaoDesktop.Clases
{
    public class DLMysql : DataLayer
    {
        public static MySqlConnection conexion, conexionLuis;
        public static string _connectionString = "Server=localhost; Database=monosabios; user=root; password=24LopezSanty;";

        public DLMysql()
        { }

        public string CrearConexionMYSQL()
        {
            try
            {
                if (conexion == null)
                    conexion = new MySqlConnection(_connectionString);
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception ex)
            {
                return "Error al Conectar con MySql: " + ex.Message;
            }
            return string.Empty;
        }

        public void CerrarConexionMYSQL()
        {
            try
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public override string Ejecutar(string query)
        {
            try
            {
                CrearConexionMYSQL();
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.CommandTimeout = 2147483;
                comando.ExecuteNonQuery();
                return "Correcto";
            }
            catch (Exception ex)
            {

                return "Error: " + ex.Message;
            }
            finally
            {
                CerrarConexionMYSQL();
            }
        }


        public MySqlDataReader EjecutarConsultaDR(string query)
        {
            MySqlDataReader dataReader = null;
            try
            {
                CrearConexionMYSQL();
                MySqlCommand comando = new MySqlCommand(query, conexion);
                dataReader = comando.ExecuteReader();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //CerrarConexionMYSQL();
            }
            return dataReader;
            
        }

    }
}
