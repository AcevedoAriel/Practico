using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practico_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (RBHombre.Checked)
                {
                    //código para abrir y leer el archivo
                    TFoto.Text = openFileDialog1.FileName;

                    // Asignar la imagen y la ruta al PictureBox
                    PBHombre.Image = Image.FromFile(openFileDialog1.FileName);
                    PBHombre.Tag = openFileDialog1.FileName;
                    //al cargar la imagen se ajusta con el picturebox.
                    PBHombre.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (RBMujer.Checked)
                {
                    //código para abrir y leer el archivo
                    TFoto.Text = openFileDialog1.FileName;

                    // Asignar la imagen y la ruta al PictureBox
                    PBMujer.Image = Image.FromFile(openFileDialog1.FileName);
                    PBMujer.Tag = openFileDialog1.FileName;
                    //al cargar la imagen se ajusta con el picturebox.
                    PBMujer.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
        }

        private string sexo()
        {
            if (!RBHombre.Checked) return "mujer";
            else return "hombre";
        }

        private void RBHombre_CheckedChanged(object sender, EventArgs e)
        {
            // si RBHombre esta cheakeado que me muestre el picture box que esta en true.
            if (RBHombre.Checked)
            {
                PBHombre.Visible = true;
                PBMujer.Visible = false;
            }
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMujer.Checked)
            {
                PBHombre.Visible = false;
                PBMujer.Visible = true;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 95) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solamente letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 95) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solamente letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {
            TNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TNombre.Text);
            TNombre.SelectionStart = TNombre.Text.Length;
        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {
            TApellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TApellido.Text);
            TApellido.SelectionStart = TApellido.Text.Length;
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (TNombre.Text != "" && TApellido.Text != "" && TSaldo.Text != "")
            {
                resultado = MessageBox.Show("Seguro que desea insertar un nuveo registro?", "Confirmar Insercion", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    DateTime fecha = dateTimePicker1.Value;
                    decimal saldo = decimal.Parse(TSaldo.Text);
                    string apellido = TApellido.Text;
                    string nombre = TNombre.Text;
                    string ruta = TFoto.Text;
                    // Agregar una nueva fila al datagrid con los valores
                    dataGridView1.Rows.Add(apellido, nombre, fecha, this.sexo(), saldo, TFoto.Text, ruta);
                    MessageBox.Show("Se inserto correctamente", "Guardar", MessageBoxButtons.OK);
                }
                // Limpiar formulario
                TNombre.Clear();
                TApellido.Clear();
                TSaldo.Clear();
                TFoto.Clear();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }

        private void TSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("¿Seguro desea eliminarlo?", "Confirmar", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            }
        }
    }
}