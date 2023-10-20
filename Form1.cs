namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarLib Opcion1 = new AgregarLib();
            Opcion1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista Opcion2 = new Lista();
            Opcion2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibAutor Opcion3 = new LibAutor();
            Opcion3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibGenero Opcion4 = new LibGenero();
            Opcion4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibEliminar Opcion5 = new LibEliminar();
            Opcion5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibExportar Opcion6 = new LibExportar();
            Opcion6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}