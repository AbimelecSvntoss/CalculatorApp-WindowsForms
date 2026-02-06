namespace CalculatorAppTestFV2
{
    public partial class Form1 : Form
    {
        private ComboBox cmbOperacion;
        Operacion operacionActual;
        public Form1()
        {
            InitializeComponent();
            cmbOperacion = new ComboBox();
            // Opcional: agrega las operaciones al ComboBox
            cmbOperacion.Items.AddRange(new string[] { "Suma", "Resta", "Multiplicación", "División", "Potencia", "Raíz Cuadrada" });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool ObtenerNumeros(out double n1, out double n2)
        {

            if (!double.TryParse(txtNumero1.Text, out n1))
            {
                MessageBox.Show("Número 1 no válido");
            }

            if (!double.TryParse(textBox1.Text, out n2))
            {
                MessageBox.Show("Número 2 no válido");
                return false;
            }

            return true;


            n1 = 0;
            n2 = 0;

            if (!double.TryParse(txtNumero1.Text, out n1))
            {
                MessageBox.Show("Número 1 no válido");
                return false;
            }

            if (!double.TryParse(textBox1.Text, out n2))
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
                Operacion op = new Suma();
                lblResultado.Text = "Resultado: " + op.Calcular(n1, n2);
            }
            operacionActual = new Suma();
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                Operacion op = new Resta();
                lblResultado.Text = "Resultado: " + op.Calcular(n1, n2);
            }

        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                Operacion op = new Multiplicacion();
                lblResultado.Text = "Resultado: " + op.Calcular(n1, n2);
            }
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                Operacion op = new Division();
                string error = op.Validar(n1, n2);

                if (error != "")
                {
                    MessageBox.Show(error);
                    return;
                }

                lblResultado.Text = "Resultado: " + op.Calcular(n1, n2);
            }
        }
        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                Operacion op = new Potencia();
                lblResultado.Text = "Resultado: " + op.Calcular(n1, n2);
            }
        }
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double n1))
            {
                Operacion op = new RaizCuadrada();
                string error = op.Validar(n1, 0);

                if (error != "")
                {
                    MessageBox.Show(error);
                    return;
                }

                lblResultado.Text = "Resultado: " + op.Calcular(n1, 0);
            }
            else
            {
                MessageBox.Show("Número no válido");
            }
        }

        /*
        private void btnResultado_Click(object sender, EventArgs e)
        {
            //lblResultado.Text = "Probando...";
            if (cmbOperacion.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una operación");
                return;
            }

            if (!double.TryParse(txtNumero1.Text, out double n1))
            {
                MessageBox.Show("Número 1 no válido");
                return;
            }

            double n2 = 0;

            if (cmbOperacion.Text != "Raíz Cuadrada")
            {
                if (!double.TryParse(textBox1.Text, out n2))
                {
                    MessageBox.Show("Número 2 no válido");
                    return;
                }
            }

            Operacion op;

            switch (cmbOperacion.Text)
            {
                case "Suma":
                    op = new Suma();
                    break;

                case "Resta":
                    op = new Resta();
                    break;

                case "Multiplicación":
                    op = new Multiplicacion();
                    break;

                case "División":
                    op = new Division();
                    break;

                case "Potencia":
                    op = new Potencia();
                    break;

                case "Raíz Cuadrada":
                    op = new RaizCuadrada();
                    break;

                default:
                    MessageBox.Show("Operación no válida");
                    return;
            }

            string error = op.Validar(n1, n2);
            if (error != "")
            {
                MessageBox.Show(error);
                return;
            }

            double resultado = op.Calcular(n1, n2);

            lblResultado.Text = "Resultado: " + resultado;
        }
        */
        private void btnDividir_Click(object sender, EventArgs e)
        {
            
        }
    }
}