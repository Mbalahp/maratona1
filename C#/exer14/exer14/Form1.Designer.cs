namespace exer14
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
            SuspendLayout();

            Label label1 = new Label();
            label1.Text = "Palavra 1:";
            label1.Location = new Point(20, 20);
            label1.Size = new Size(100, 20);
            Controls.Add(label1);

            TextBox textBox1 = new TextBox();
            textBox1.Name = "textBox1";
            textBox1.Location = new Point(120, 20);
            textBox1.Size = new Size(200, 20);
            Controls.Add(textBox1);

            Label label2 = new Label();
            label2.Text = "Palavra 2:";
            label2.Location = new Point(20, 60);
            label2.Size = new Size(100, 20);
            Controls.Add(label2);

            TextBox textBox2 = new TextBox();
            textBox2.Name = "textBox2";
            textBox2.Location = new Point(120, 60);
            textBox2.Size = new Size(200, 20);
            Controls.Add(textBox2);

            Button button1 = new Button();
            button1.Text = "Comparar";
            button1.Location = new Point(120, 100);
            button1.Size = new Size(100, 30);
            button1.Click += Button1_Click;
            Controls.Add(button1);

            TextBox resultBox = new TextBox();
            resultBox.Name = "resultBox";
            resultBox.Location = new Point(20, 150);
            resultBox.Size = new Size(500, 250);
            resultBox.Multiline = true;
            resultBox.ReadOnly = true;
            Controls.Add(resultBox);

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Form1";
            Text = "Comparador de Palavras";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}
