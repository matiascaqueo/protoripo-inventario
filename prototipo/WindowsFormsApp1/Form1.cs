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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string cantidad = txtCantidad.Text;
            

            string query = "INSERT INTO dbo.Productos (id, cantidad) VALUES ("+id+", '"+cantidad+"')";

            try
            {
                SqlConnection conexion = new SqlConnection("server=DESKTOP-I41RIDO\\SQLEXPRESS; database=Tienda; integrated security = true");
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                int result = comando.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("No pudo guardarse el registro");
                } else
                {
                    MessageBox.Show("El registro se guardo exitosamente.");
                }
                conexion.Close();
                txtId.Text = "";
                txtCantidad.Text = "";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string cantidad = txtCantidad.Text;

            string query = "UPDATE dbo.alumnos SET cantidad='" + cantidad + "' WHERE idAlumno = " + id + ";";

            try
            {
                SqlConnection conexion = new SqlConnection("server=KHALLED; database=colegio; integrated security = true");
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                int result = comando.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("No pudo actualizarse el registro");
                }
                else
                {
                    MessageBox.Show("El registro se actualizo exitosamente.");
                }
                conexion.Close();
                txtId.Text = "";
                txtCantidad.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string cantidad = txtCantidad.Text;

            string query = "DELETE FROM dbo.alumnos WHERE idAlumno = " + id + ";";

            try
            {
                SqlConnection conexion = new SqlConnection("server=KHALLED; database=colegio; integrated security = true");
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                int result = comando.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("No pudo eliminar el registro");
                }
                else
                {
                    MessageBox.Show("El registro fue eliminado correctamente.");
                }
                conexion.Close();
                txtId.Text = "";
                txtCantidad.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
