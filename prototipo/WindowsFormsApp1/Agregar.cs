using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            string id = txtid.Text;
            string nombreProducto = txtnombre.Text;
            string descripcion = txtdescrpicion.Text;
            string precio = txtprecio.Text;
            string stock = txtstock.Text;
            string categoria = txtcategoria.Text;

           
            string query = "INSERT INTO dbo.producto (id_Producto, Nombre, Descripcion, Precio, Stock, Categoria) VALUES (@id_Producto, @Nombre, @Descripcion, @Precio, @Stock, @Categoria)";

            try
            {
                
                using (SqlConnection conexion = new SqlConnection("server=DESKTOP-I41RIDO\\SQLEXPRESS;database=Tienda;integrated security=true"))
                {
                    conexion.Open();

                    
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        
                        comando.Parameters.AddWithValue("@id_Producto", id);
                        comando.Parameters.AddWithValue("@Nombre", nombreProducto);
                        comando.Parameters.AddWithValue("@Descripcion", descripcion);
                        comando.Parameters.AddWithValue("@Precio", precio);
                        comando.Parameters.AddWithValue("@Stock", stock);
                        comando.Parameters.AddWithValue("@Categoria",categoria);

                     
                        int result = comando.ExecuteNonQuery();
                        if (result == 0)
                        {
                            MessageBox.Show("No pudo insertarse el registro");
                        }
                        else
                        {
                            MessageBox.Show("El registro se insertó exitosamente.");
                        }
                    }
                }

               
                txtid.Text = "";
                txtnombre.Text = "";
                txtdescrpicion.Text = "";
                txtprecio.Text = "";
                txtstock.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}




