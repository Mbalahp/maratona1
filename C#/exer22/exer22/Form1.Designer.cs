namespace exer22
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
            labelEntrada = new Label();
            textBoxEntrada = new TextBox();
            buttonProcessar = new Button();
            labelSaida = new Label();
            textBoxSaida = new TextBox();
            SuspendLayout();
            // 
            // labelEntrada
            // 
            labelEntrada.AutoSize = true;
            labelEntrada.Location = new Point(20, 20);
            labelEntrada.Name = "labelEntrada";
            labelEntrada.Size = new Size(250, 15);
            labelEntrada.TabIndex = 0;
            labelEntrada.Text = "Introduza 20 números positivos (separados por espaço ou vírgula):";
            // 
            // textBoxEntrada
            // 
            textBoxEntrada.Location = new Point(20, 50);
            textBoxEntrada.Multiline = true;
            textBoxEntrada.Name = "textBoxEntrada";
            textBoxEntrada.Size = new Size(760, 100);
            textBoxEntrada.TabIndex = 1;
            // 
            // buttonProcessar
            // 
            buttonProcessar.Location = new Point(20, 170);
            buttonProcessar.Name = "buttonProcessar";
            buttonProcessar.Size = new Size(100, 30);
            buttonProcessar.TabIndex = 2;
            buttonProcessar.Text = "Processar";
            buttonProcessar.UseVisualStyleBackColor = true;
            buttonProcessar.Click += ButtonProcessar_Click;
            // 
            // labelSaida
            // 
            labelSaida.AutoSize = true;
            labelSaida.Location = new Point(20, 220);
            labelSaida.Name = "labelSaida";
            labelSaida.Size = new Size(50, 15);
            labelSaida.TabIndex = 3;
            labelSaida.Text = "Resultado:";
            // 
            // textBoxSaida
            // 
            textBoxSaida.Location = new Point(20, 250);
            textBoxSaida.Multiline = true;
            textBoxSaida.Name = "textBoxSaida";
            textBoxSaida.ReadOnly = true;
            textBoxSaida.Size = new Size(760, 150);
            textBoxSaida.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelEntrada);
            Controls.Add(textBoxEntrada);
            Controls.Add(buttonProcessar);
            Controls.Add(labelSaida);
            Controls.Add(textBoxSaida);
            Name = "Form1";
            Text = "Vetor Q - Maior Elemento";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEntrada;
        private TextBox textBoxEntrada;
        private Button buttonProcessar;
        private Label labelSaida;
        private TextBox textBoxSaida;
    }
}
