namespace exer17
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
            rotulN = new Label();
            caixaTextoN = new TextBox();
            botaoCalcular = new Button();
            rotulPrimos = new Label();
            caixaTextoNumeros = new TextBox();
            rotulDivisoes = new Label();
            caixaTxtoDivisoes = new TextBox();
            SuspendLayout();
            // 
            // rotulN
            // 
            rotulN.AutoSize = true;
            rotulN.Location = new Point(20, 20);
            rotulN.Name = "rotulN";
            rotulN.Size = new Size(49, 15);
            rotulN.TabIndex = 0;
            rotulN.Text = "Digite N:";
            rotulN.Click += rotulN_Click;
            // 
            // caixaTextoN
            // 
            caixaTextoN.Location = new Point(120, 20);
            caixaTextoN.Name = "caixaTextoN";
            caixaTextoN.Size = new Size(200, 23);
            caixaTextoN.TabIndex = 1;
            // 
            // botaoCalcular
            // 
            botaoCalcular.Location = new Point(340, 20);
            botaoCalcular.Name = "botaoCalcular";
            botaoCalcular.Size = new Size(100, 27);
            botaoCalcular.TabIndex = 2;
            botaoCalcular.Text = "Calcular";
            botaoCalcular.UseVisualStyleBackColor = true;
            botaoCalcular.Click += BotaoCalcular_Click;
            // 
            // rotulPrimos
            // 
            rotulPrimos.AutoSize = true;
            rotulPrimos.Location = new Point(20, 70);
            rotulPrimos.Name = "rotulPrimos";
            rotulPrimos.Size = new Size(100, 15);
            rotulPrimos.TabIndex = 3;
            rotulPrimos.Text = "Números Primos:";
            // 
            // caixaTextoNumeros
            // 
            caixaTextoNumeros.Location = new Point(20, 100);
            caixaTextoNumeros.Multiline = true;
            caixaTextoNumeros.Name = "caixaTextoNumeros";
            caixaTextoNumeros.ReadOnly = true;
            caixaTextoNumeros.ScrollBars = ScrollBars.Both;
            caixaTextoNumeros.Size = new Size(750, 300);
            caixaTextoNumeros.TabIndex = 3;
            // 
            // rotulDivisoes
            // 
            rotulDivisoes.AutoSize = true;
            rotulDivisoes.Location = new Point(20, 410);
            rotulDivisoes.Name = "rotulDivisoes";
            rotulDivisoes.Size = new Size(150, 15);
            rotulDivisoes.TabIndex = 4;
            rotulDivisoes.Text = "Quantidade de Divisões:";
            // 
            // caixaTxtoDivisoes
            // 
            caixaTxtoDivisoes.Location = new Point(180, 410);
            caixaTxtoDivisoes.Name = "caixaTxtoDivisoes";
            caixaTxtoDivisoes.ReadOnly = true;
            caixaTxtoDivisoes.Size = new Size(200, 23);
            caixaTxtoDivisoes.TabIndex = 4;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 460);
            Controls.Add(rotulN);
            Controls.Add(caixaTextoN);
            Controls.Add(botaoCalcular);
            Controls.Add(rotulPrimos);
            Controls.Add(caixaTextoNumeros);
            Controls.Add(rotulDivisoes);
            Controls.Add(caixaTxtoDivisoes);
            Name = "Form1";
            Text = "Localizador de Números Primos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private void BotaoCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(caixaTextoN.Text, out int n) && n > 0)
            {
                CalcularPrimos(n);
            }
            else
            {
                MessageBox.Show("Por favor, digite um número inteiro positivo válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                caixaTextoNumeros.Clear();
                caixaTxtoDivisoes.Clear();
            }
        }

        private Label rotulN;
        private TextBox caixaTextoN;
        private Button botaoCalcular;
        private Label rotulPrimos;
        private TextBox caixaTextoNumeros;
        private Label rotulDivisoes;
        private TextBox caixaTxtoDivisoes;
    }
}
