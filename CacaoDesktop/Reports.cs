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
    public partial class Reports : Form
    {
        private DataTable tabla;
        DLMysql _dlMysql = new DLMysql();
        public Reports()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            loadCombo();
            LlenarTablaProducto();
            LlenarTablaClienteCiudad();
        }

        private void loadCombo()
        {
            try
            {
                string selectQuery = "SELECT * FROM monosabios.cities";
                MySqlDataReader reader = null;
                reader = _dlMysql.EjecutarConsultaDR(selectQuery);
                while (reader.Read())
                {
                    listCiudad.Items.Add(reader.GetString("name"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Direccion");
            tabla.Columns.Add("Telefono");
            dgvCliente.DataSource = tabla;
            try
            {
                
                if (listCiudad.SelectedIndex != -1)
                {
                    int city = listCiudad.SelectedIndex + 1;
                    string strComando = "select concat_ws(' ', firstName, lastName) as name, address, phone from clients as a inner join cities as b on a.cities = b.idCities where a.cities = '"+city+"';";
                    MySqlDataReader dr = null;
                    dr = _dlMysql.EjecutarConsultaDR(strComando);
                    if (dr != null)
                    {
                        while (dr.Read())
                        {
                            try
                            {
                                DataRow row = tabla.NewRow();
                                row["Nombre"] = dr.GetString("name");
                                row["Direccion"] = dr.GetString("address");
                                row["Telefono"] = dr.GetString("phone");
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
                else
                {
                    MessageBox.Show("Seleccione una ciudad");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }

        public void LlenarTablaProducto()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Descripcion");
            tabla.Columns.Add("Cantidad");
            dgvProducto.DataSource = tabla;
            try
            {
                string strComando = "select name, description, count(products) as count from clients as a inner join cities as b on a.cities = b.idCities inner join products as c on a.products = c.idproduct group by name, description order by b.name asc; ";
                MySqlDataReader dr = null;
                dr = _dlMysql.EjecutarConsultaDR(strComando);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        try
                        {
                            DataRow row = tabla.NewRow();
                            row["Nombre"] = dr.GetString("name");
                            row["Descripcion"] = dr.GetString("description");
                            row["Cantidad"] = dr.GetInt32("count");
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

        public void LlenarTablaClienteCiudad()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Cantidad");
            dvgClienteCiudad.DataSource = tabla;
            try
            {
                string strComando = "select name, count(name) as count from cities as a inner join clients as b on a.idCities = b.cities group by name;";
                MySqlDataReader dr = null;
                dr = _dlMysql.EjecutarConsultaDR(strComando);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        try
                        {
                            DataRow row = tabla.NewRow();
                            row["Nombre"] = dr.GetString("name");
                            row["Cantidad"] = dr.GetInt32("count");
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
            this.Close();
        }
    }
}