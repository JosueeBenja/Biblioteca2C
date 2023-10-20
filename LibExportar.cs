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
    public partial class LibExportar : Form
    {
        public LibExportar()
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

        private void LibExportar_Load(object sender, EventArgs e)
        {
            string datos = "select * from Biblioteca";
            SqlDataAdapter adaptador = new SqlDataAdapter(datos, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string connectionString = "Data Source=TuServidorSQL;Initial Catalog=TuBaseDeDatos;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Libros";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                string csvFilePath = "../../../Libros.csv";

                                using (StreamWriter sw = new StreamWriter(csvFilePath))
                                {
                                    for (int i = 0; i < dataTable.Columns.Count; i++)
                                    {
                                        sw.Write(dataTable.Columns[i]);
                                        if (i < dataTable.Columns.Count - 1)
                                            sw.Write(",");
                                    }
                                    sw.Write(sw.NewLine);

                                    foreach (DataRow row in dataTable.Rows)
                                    {
                                        for (int i = 0; i < dataTable.Columns.Count; i++)
                                        {
                                            sw.Write(row[i].ToString());
                                            if (i < dataTable.Columns.Count - 1)
                                                sw.Write(",");
                                        }
                                        sw.Write(sw.NewLine);
                                    }
                                }

                                MessageBox.Show("Los datos se exportaron correctamente a " + csvFilePath, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No hay datos para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
    private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
