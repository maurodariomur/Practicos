using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        private int a;
        private int b;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void THasta_TextChanged(object sender, EventArgs e)
        {

        }

        private void THasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BGenerador_Click(object sender, EventArgs e)
        {
            string desde = TDesde.Text;
            string hasta = THasta.Text;

            if (string.IsNullOrWhiteSpace(desde) || string.IsNullOrWhiteSpace(hasta))
            {
                MessageBox.Show("Por favor complete los campos faltantes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si los campos están incompletos
            }

            LListaNum.Items.Clear();

            a = int.Parse(desde);
            b = int.Parse(hasta);

            // Agregar los números al Chart
            chart1.Series.Clear(); // Limpia cualquier serie previa
            Series numerosSerie = new Series("Números Generados");

            for (int num = a; num <= b; num++)
            {
                numerosSerie.Points.AddXY(num, num); // Agrega el punto (x=num, y=num)
            }

            chart1.Series.Add(numerosSerie);
        }


        private void BPares_Click(object sender, EventArgs e)
        {
            string desde = TDesde.Text;
            string hasta = THasta.Text;

            if (string.IsNullOrWhiteSpace(desde) || string.IsNullOrWhiteSpace(hasta))
            {
                MessageBox.Show("Por favor complete los campos faltantes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LListaNum.Items.Clear();
            a = int.Parse(desde);
            b = int.Parse(hasta);

            // Agregar los números al Chart
            chart1.Series.Clear(); // Limpia cualquier serie previa
            Series numerosSerie = new Series("Números Pares");

            while (a <= b)
            {
                if (a % 2 == 0)
                {
                    LListaNum.Items.Add(a);
                    numerosSerie.Points.AddXY(a, a);
                }

                a++;
            }

            chart1.Series.Add(numerosSerie);
        }

        private void BImpares_Click(object sender, EventArgs e)
        {
            string desde = TDesde.Text;
            string hasta = THasta.Text;

            if (string.IsNullOrWhiteSpace(desde) || string.IsNullOrWhiteSpace(hasta))
            {
                MessageBox.Show("Por favor complete los campos faltantes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LListaNum.Items.Clear();
            a = int.Parse(desde);
            b = int.Parse(hasta);

            // Agregar los números al Chart
            chart1.Series.Clear(); // Limpia cualquier serie previa
            Series numerosSerie = new Series("Números Impares");

            while (a <= b)
            {
                if (a % 2 != 0)
                {
                    LListaNum.Items.Add(a);
                    numerosSerie.Points.AddXY(a, a);
                }

                a++;
            }

            chart1.Series.Add(numerosSerie);
        }

        private void BPrimos_Click(object sender, EventArgs e)
        {
            LListaNum.Items.Clear();
            chart1.Series.Clear(); // Limpiar series anteriores en el gráfico

            string desde = TDesde.Text;
            string hasta = THasta.Text;

            if (string.IsNullOrWhiteSpace(desde) || string.IsNullOrWhiteSpace(hasta))
            {
                MessageBox.Show("Por favor complete los campos faltantes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int a = int.Parse(desde);
            int b = int.Parse(hasta);

            Series seriePrimos = new Series("Números Primos");
            seriePrimos.ChartType = SeriesChartType.Column; // Puedes ajustar el tipo de gráfico según tu preferencia

            while (a <= b)
            {
                if (EsPrimo(a))
                {
                    LListaNum.Items.Add(a);
                    seriePrimos.Points.AddXY(a, a); // Agregar el número primo al gráfico
                }

                a++;
            }

            chart1.Series.Add(seriePrimos); // Agregar la serie al gráfico
        }

        private bool EsPrimo(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TDesde_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void TDesde_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter ingresado si no es un número o un carácter de control
            }
        }

        private void THasta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter ingresado si no es un número o un carácter de control
            }
        }
    }
}
