namespace Practico_1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text + " " + textBox2.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formulario1_KeyDown(object sender, KeyEventArgs e)
        {
            //si oprimo (CTRL + S) sale del formulario
            if (e.Control && e.KeyCode == Keys.S)
            {
                Application.Exit();
            }
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {

        }
    }
}
