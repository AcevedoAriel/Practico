using System.Windows.Forms.DataVisualization.Charting;
namespace Practico_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solamente n�meros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void THasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solamente n�meros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BGenerarFuncion_Click(object sender, EventArgs e)
        {
            if (TDesde.Text != "" && THasta.Text != "")
            {
                // Obtener el n�mero desde y hasta
                //instancio dos variables "desde" y "hasta"
                int desde = int.Parse(TDesde.Text);
                int hasta = int.Parse(THasta.Text);

                // Limpia el listbox cada vez que se genere un nuevo recorrido al oprimir el boton "Generar Funcion"
                listBox1.Items.Clear();

                // Recorrer el rango de n�meros
                for (int i = desde; i <= hasta; i++)
                {
                    // Agregar el n�mero al listbox
                    listBox1.Items.Add(i);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }

        private void BNroPar_Click(object sender, EventArgs e)
        {
            if (TDesde.Text != "" && THasta.Text != "")
            {
                // Obtener el n�mero desde y hasta
                //instancio dos variables "desde" y "hasta"
                int desde = int.Parse(TDesde.Text);
                int hasta = int.Parse(THasta.Text);

                // Limpia el listbox cada vez que se genere un nuevo recorrido al oprimir el boton.
                listBox1.Items.Clear();

                // Recorrer el rango de n�meros
                for (int i = desde; i <= hasta; i++)
                {
                    // Si el n�mero es par
                    if (i % 2 == 0)
                    {
                        // Agregar el n�mero al listbox
                        listBox1.Items.Add(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }

        private void BNroImpar_Click(object sender, EventArgs e)
        {
            if (TDesde.Text != "" && THasta.Text != "")
            {
                // Obtener el n�mero desde y hasta
                //instancio dos variables "desde" y "hasta"
                int desde = int.Parse(TDesde.Text);
                int hasta = int.Parse(THasta.Text);

                // Limpia el listbox cada vez que se genere un nuevo recorrido al oprimir el boton
                listBox1.Items.Clear();

                // Recorrer el rango de n�meros
                for (int i = desde; i <= hasta; i++)
                {
                    // Si el n�mero no es par
                    if (i % 2 != 0)
                    {
                        // Agregar el n�mero al listbox
                        listBox1.Items.Add(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }

        // Funci�n que determina si un n�mero es primo
        private bool EsPrimo(int n)
        {
            // Si el n�mero es menor que 2, no es primo
            if (n < 2)
            {
                return false;
            }

            // Si el n�mero es divisible por alg�n n�mero menor que �l, no es primo
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            // Si no se cumple ninguna de las condiciones anteriores, el n�mero es primo
            return true;
        }


        private void BNroPrimo_Click(object sender, EventArgs e)
        {
            if (TDesde.Text != "" && THasta.Text != "")
            {
                // Obtener el n�mero desde y hasta
                //instancio dos variables "desde" y "hasta"
                int desde = int.Parse(TDesde.Text);
                int hasta = int.Parse(THasta.Text);

                // Limpia el listbox cada vez que se genere un nuevo recorrido al oprimir el boton
                listBox1.Items.Clear();

                // Recorrer el rango de n�meros
                for (int i = desde; i <= hasta; i++)
                {
                    // Si el n�mero es primo
                    if (EsPrimo(i))
                    {
                        // Agregar el n�mero al listbox
                        listBox1.Items.Add(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error");
            }
        }
    }
}