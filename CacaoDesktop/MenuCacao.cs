using CacaoDesktop.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaoDesktop
{
    public partial class MonoSabios : Form
    {
        private DataTable tabla;
        DLMysql _dlMysql = new DLMysql();

        private void Inicializar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Tamaño");
            tabla.Columns.Add("Indice de robo Anual");
            tabla.Columns.Add("Egreso promedio mensual");
            dataGridView1.DataSource = tabla;
        }

        public MonoSabios()
        {
            InitializeComponent();
            LlenarTabla();
            StartPosition = FormStartPosition.CenterScreen;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        public void LlenarTabla()
        {
            Inicializar();
            try
            {
                string strComando = "select * from cities";
                MySqlDataReader dr = null;
                dr = _dlMysql.EjecutarConsultaDR(strComando);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        try
                        {
                            DataRow row = tabla.NewRow();
                            row["Id"] = dr.GetInt32("idCities");
                            row["Nombre"] = dr.GetString("name");
                            row["Tamaño"] = dr.GetFloat("size");
                            row["Indice de robo Anual"] = dr.GetFloat("rate");
                            row["Egreso promedio mensual"] = dr.GetFloat("average")+" %";
                            tabla.Rows.Add(row);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    dr.Close();
                    _dlMysql.CerrarConexionMYSQL();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Show();         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports reporte = new Reports();
            reporte.Show();
        }
    }
}
