using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                {
                    string query = "SELECT * FROM dbo.Ventas";
                    string connectionString = "server=DESKTOP-I41RIDO\\SQLEXPRESS;database=Tienda;integrated security=true";

                    try
                    {
                        using (SqlConnection conexion = new SqlConnection(connectionString))
                        {
                            conexion.Open();
                            using (SqlCommand comando = new SqlCommand(query, conexion))
                            {
                                using (SqlDataReader reader = comando.ExecuteReader())
                                {
                                    DataTable dataTable = new DataTable();
                                    dataTable.Load(reader);
                                    dataGridView1.DataSource = dataTable;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
