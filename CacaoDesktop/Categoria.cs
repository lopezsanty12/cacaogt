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
    public partial class Categoria : Form
    {
        private DataTable tabla;
        DLMysql _dlMySql = new DLMysql();
        private void Inicializar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Descripcion");
            dataGridView1.DataSource = tabla;
        }
        public Categoria()
        {
            InitializeComponent();
            LlenarTabla();
            StartPosition = FormStartPosition.CenterScreen;
        }
      
        public void LlenarTabla()
        {
            Inicializar();
            try
            {
                string strComando = "select idcategory, name, description from category";
                MySqlDataReader dr = null;
                dr = _dlMySql.EjecutarConsultaDR(strComando);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        try
                        {
                            DataRow row = tabla.NewRow();
                            row["Id"]= dr.GetInt32("idcategory");
                            row["Nombre"] = dr.GetString("name");
                            row["Descripcion"] = dr.GetString("description");
                            tabla.Rows.Add(row);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    dr.Close();
                    _dlMySql.CerrarConexionMYSQL();
                    
                }
            } 
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        private void Limpiar()
        {
            nameCat.Text = "";
            desCat.Text = "";
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            bool btn = false;
            try
            {
                if (btn == false)
                {
                    if (nameCat.Text.Length != 0 && desCat.Text.Length != 0)
                    {
                        string strComando = "insert into category (`name`, `description`) values ('" + nameCat.Text + "','" + desCat.Text + "');";
                        MySqlDataReader dr = null;
                        dr = _dlMySql.EjecutarConsultaDR(strComando);
                        if (dr != null)
                        {

                            MessageBox.Show("Se ingreso correctamente");
                            dr.Close();
                            _dlMySql.CerrarConexionMYSQL();
                        }
                        LlenarTabla();
                    }
                    else
                    {
                        MessageBox.Show("No ingreso ningun dato");
                    }
                }
                else if (btn == true)
                {
                    MessageBox.Show("Boton para actualizar");
                }
                
            }
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btn = false;
            LlenarTabla();
            Limpiar();
        }

        private void btnUpdateCat_Click(object sender, EventArgs e)
        {
            bool btn = true;
            string id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Id"].Value.ToString();
            string nombre = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Nombre"].Value.ToString();
            string descripcion = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Descripcion"].Value.ToString();

            nameCat.Text = nombre;
            desCat.Text = descripcion;
            
        
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            try
            {
                string i = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Id"].Value.ToString();

                if (DialogResult.Yes == MessageBox.Show("¿Deseas eliminar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    string command = "DELETE FROM `monosabios`.`category` WHERE (`idcategory` = '" + i + "');";
                    MySqlDataReader dr = null;
                    dr = _dlMySql.EjecutarConsultaDR(command);
                    dr.Close();
                    LlenarTabla();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

