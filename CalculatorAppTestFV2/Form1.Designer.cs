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
            label3 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            btnSuma = new Button();
            btnResta = new Button();
            btnDivision = new Button();
            btnMultiplicar = new Button();
            btnPotencia = new Button();
            btnRaiz = new Button();
            label2 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuText;
            label1.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(117, 83);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 0;
            label1.Text = "Número 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(274, 83);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 1;
            label3.Text = "Número 2";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(101, 107);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(260, 107);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 14;
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
            btnDivision.Click += btnDivision_Click;
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
            btnPotencia.Location = new Point(101, 188);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(75, 33);
            btnPotencia.TabIndex = 7;
            btnPotencia.Text = "Potencia";
            btnPotencia.UseVisualStyleBackColor = true;
            // 
            // btnRaiz
            // 
            btnRaiz.Font = new Font("Sitka Heading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRaiz.Location = new Point(285, 188);
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
            lblResultado.ForeColor = SystemColors.Control;
            lblResultado.Location = new Point(101, 240);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(259, 43);
            lblResultado.TabIndex = 13;
            lblResultado.Text = "Resultado: ";
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            ClientSize = new Size(473, 329);
            Controls.Add(lblResultado);
            Controls.Add(label2);
            Controls.Add(btnRaiz);
            Controls.Add(btnPotencia);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDivision);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(label3);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculadora Básica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Button btnSuma;
        private Button btnResta;
        private Button btnDivision;
        private Button btnMultiplicar;
        private Button btnPotencia;
        private Button btnRaiz;
        private Label label2;
        private Label lblResultado;
    }
}