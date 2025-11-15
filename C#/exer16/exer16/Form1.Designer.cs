namespace exer16
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
            components = new System.ComponentModel.Container();
            
            Label label1 = new Label();
            label1.Text = "População País A:";
            label1.Location = new Point(20, 20);
            label1.Size = new Size(150, 20);
            Controls.Add(label1);

            TextBox textBoxPopulacaoA = new TextBox();
            textBoxPopulacaoA.Name = "textBoxPopulacaoA";
            textBoxPopulacaoA.Text = "80000";
            textBoxPopulacaoA.Location = new Point(180, 20);
            textBoxPopulacaoA.Size = new Size(150, 20);
            Controls.Add(textBoxPopulacaoA);

            Label label2 = new Label();
            label2.Text = "Taxa Crescimento A (%):";
            label2.Location = new Point(20, 60);
            label2.Size = new Size(150, 20);
            Controls.Add(label2);

            TextBox textBoxTaxaA = new TextBox();
            textBoxTaxaA.Name = "textBoxTaxaA";
            textBoxTaxaA.Text = "3";
            textBoxTaxaA.Location = new Point(180, 60);
            textBoxTaxaA.Size = new Size(150, 20);
            Controls.Add(textBoxTaxaA);

            Label label3 = new Label();
            label3.Text = "População País B:";
            label3.Location = new Point(20, 100);
            label3.Size = new Size(150, 20);
            Controls.Add(label3);

            TextBox textBoxPopulacaoB = new TextBox();
            textBoxPopulacaoB.Name = "textBoxPopulacaoB";
            textBoxPopulacaoB.Text = "200000";
            textBoxPopulacaoB.Location = new Point(180, 100);
            textBoxPopulacaoB.Size = new Size(150, 20);
            Controls.Add(textBoxPopulacaoB);

            Label label4 = new Label();
            label4.Text = "Taxa Crescimento B (%):";
            label4.Location = new Point(20, 140);
            label4.Size = new Size(150, 20);
            Controls.Add(label4);

            TextBox textBoxTaxaB = new TextBox();
            textBoxTaxaB.Name = "textBoxTaxaB";
            textBoxTaxaB.Text = "1.5";
            textBoxTaxaB.Location = new Point(180, 140);
            textBoxTaxaB.Size = new Size(150, 20);
            Controls.Add(textBoxTaxaB);

            Button buttonCalcular = new Button();
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Text = "Calcular";
            buttonCalcular.Location = new Point(180, 180);
            buttonCalcular.Size = new Size(80, 30);
            buttonCalcular.Click += ButtonCalcular_Click;
            Controls.Add(buttonCalcular);

            Label label5 = new Label();
            label5.Text = "Anos necessários:";
            label5.Location = new Point(20, 230);
            label5.Size = new Size(150, 20);
            Controls.Add(label5);

            Label labelResultado = new Label();
            labelResultado.Name = "labelResultado";
            labelResultado.Text = "";
            labelResultado.Location = new Point(180, 230);
            labelResultado.Size = new Size(150, 20);
            labelResultado.Font = new Font("Arial", 12, FontStyle.Bold);
            labelResultado.ForeColor = Color.Blue;
            Controls.Add(labelResultado);

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 300);
            Text = "Cálculo de População";
        }

        #endregion
    }
}
