namespace exer20
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
            
            textBoxResultado = new TextBox();
            buttonExecutar = new Button();
            
            textBoxResultado.Multiline = true;
            textBoxResultado.ScrollBars = ScrollBars.Vertical;
            textBoxResultado.Dock = DockStyle.Fill;
            textBoxResultado.ReadOnly = true;
            
            buttonExecutar.Text = "Executar";
            buttonExecutar.Dock = DockStyle.Top;
            buttonExecutar.Height = 40;
            buttonExecutar.Click += ButtonExecutar_Click;
            
            Controls.Add(textBoxResultado);
            Controls.Add(buttonExecutar);
            
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Text = "Exercício 20";
        }

        #endregion

        private TextBox textBoxResultado;
        private Button buttonExecutar;
    }
}
