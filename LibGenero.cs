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

namespace Biblioteca
{
    public partial class LibGenero : Form
    {
        public LibGenero()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new("server=DESKTOP-4VR7A0T\\SQLEXPRESS; database=Biblioteca;integrated security= true");

        private void LibGenero_Load(object sender, EventArgs e)
        {
            string datos = "select * from Biblioteca";
            SqlDataAdapter adaptador = new SqlDataAdapter(datos, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }


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
            string buscar = "SELECT * FROM Biblioteca WHERE CAST(Genero AS NVARCHAR(MAX)) = @Genero";
            SqlCommand comando = new SqlCommand(buscar, conexion);
            comando.Parameters.AddWithValue("@Genero", textBox1.Text);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

            conexion.Close();
        }
    }
}