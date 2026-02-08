using System;
using System.Windows.Forms;

namespace CalculatorAppTestFV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ObtenerNumeros(out double n1, out double n2)
        {
            if (!double.TryParse(txtNumero1.Text, out n1))
            {
                MessageBox.Show("Número 1 no válido");
                n2 = 0;
                return false;
            }

            if (!double.TryParse(txtNumero2.Text, out n2))
            {
                MessageBox.Show("Número 2 no válido");
                return false;
            }

            return true;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                lblResultado.Text = "Resultado: " + (n1 + n2);
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                lblResultado.Text = "Resultado: " + (n1 - n2);
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                lblResultado.Text = "Resultado: " + (n1 * n2);
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                if (n2 == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero");
                    return;
                }

                lblResultado.Text = "Resultado: " + (n1 / n2);
            }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                lblResultado.Text = "Resultado: " + Math.Pow(n1, n2);
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNumero1.Text, out double n1))
            {
                MessageBox.Show("Número no válido");
                return;
            }

            if (n1 < 0)
            {
                MessageBox.Show("No existe raíz de número negativo");
                return;
            }

            lblResultado.Text = "Resultado: " + Math.Sqrt(n1);
        }
    }
}