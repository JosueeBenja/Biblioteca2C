using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Biblioteca
{
    public partial class AgregarLib : Form
    {

        public AgregarLib()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new("server=DESKTOP-4VR7A0T\\SQLEXPRESS; database=Biblioteca;integrated security= true");

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Inicio = new Form1();
            Inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string datos = "insert into Biblioteca values('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "')";
            SqlCommand comando = new SqlCommand(datos, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Libro Agregado Exitosamente");
            conexion.Close();
        }

        private void AgregarLib_Load(object sender, EventArgs e)
        {
            string datos = "select * from Biblioteca";
            SqlDataAdapter adaptador = new SqlDataAdapter(datos, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
