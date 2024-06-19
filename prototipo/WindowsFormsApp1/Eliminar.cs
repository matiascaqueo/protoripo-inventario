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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            {
                
                string id = txtEliminar.Text;

                
                string query = "DELETE FROM dbo.Producto WHERE id_Producto = @id_Producto";

                try
                {
                    
                    using (SqlConnection conexion = new SqlConnection("server=DESKTOP-I41RIDO\\SQLEXPRESS;database=Tienda;integrated security=true"))
                    {
                        conexion.Open();

                       
                        using (SqlCommand comando = new SqlCommand(query, conexion))
                        {
                            
                            comando.Parameters.AddWithValue("@id_Producto", id);

                           
                            int result = comando.ExecuteNonQuery();
                            if (result == 0)
                            {
                                MessageBox.Show("No se encontró ningún producto con ese ID.");
                            }
                            else
                            {
                                MessageBox.Show("El producto se eliminó exitosamente.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar el producto: " + ex.Message);
                }
                finally
                {
                    
                    txtEliminar.Text = "";
                }
            }

        }
    }
}
