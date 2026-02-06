
namespace CalculatorAppTestFV2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtNumero2 = new Label();
            txtNumero1 = new TextBox();
            btnSuma = new Button();
            btnResta = new Button();
            btnDivision = new Button();
            btnMultiplicar = new Button();
            btnPotencia = new Button();
            btnRaiz = new Button();
            label2 = new Label();
            lblResultado = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowFrame;
            label1.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(117, 83);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 0;
            label1.Text = "Número 1";
            label1.Click += label1_Click;
            // 
            // txtNumero2
            // 
            txtNumero2.AutoSize = true;
            txtNumero2.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumero2.ForeColor = SystemColors.Control;
            txtNumero2.Location = new Point(274, 83);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(73, 21);
            txtNumero2.TabIndex = 1;
            txtNumero2.Text = "Número 2";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(101, 107);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 2;
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuma.Location = new Point(101, 147);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(75, 34);
            btnSuma.TabIndex = 3;
            btnSuma.Text = "Sumar";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Font = new Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResta.Location = new Point(194, 147);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(75, 34);
            btnResta.TabIndex = 4;
            btnResta.Text = "Restar";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivision.Location = new Point(285, 147);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(75, 34);
            btnDivision.TabIndex = 5;
            btnDivision.Text = "Dividir";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDividir_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiplicar.Location = new Point(192, 188);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(87, 33);
            btnMultiplicar.TabIndex = 6;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnPotencia
            // 
            btnPotencia.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPotencia.Location = new Point(101, 187);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(75, 33);
            btnPotencia.TabIndex = 7;
            btnPotencia.Text = "Potencia";
            btnPotencia.UseVisualStyleBackColor = true;
            btnPotencia.Click += btnPotencia_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.Font = new Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRaiz.Location = new Point(285, 187);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(75, 33);
            btnRaiz.TabIndex = 8;
            btnRaiz.Text = "Raíz Cuadrada";
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(173, 41);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 11;
            label2.Text = "Calculator App";
            // 
            // lblResultado
            // 
            lblResultado.Font = new Font("Sitka Subheading", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(138, 253);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(189, 30);
            lblResultado.TabIndex = 13;
            lblResultado.Text = "Resultado";
            lblResultado.UseVisualStyleBackColor = true;
            lblResultado.Click += btnResultado_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(260, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(473, 329);
            Controls.Add(textBox1);
            Controls.Add(lblResultado);
            Controls.Add(label2);
            Controls.Add(btnRaiz);
            Controls.Add(btnPotencia);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDivision);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(txtNumero1);
            Controls.Add(txtNumero2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculadora Básica";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label txtNumero2;
        private TextBox txtNumero1;
        private Button btnSuma;
        private Button btnResta;
        private Button btnDivision;
        private Button btnMultiplicar;
        private Button btnPotencia;
        private Button btnRaiz;
        private Label label2;
        private Button lblResultado;
        private TextBox textBox1;
    }
}
