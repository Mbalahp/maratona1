namespace exer19
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
            TextBox textBoxInput = new TextBox();
            Button buttonAnalyze = new Button();
            TextBox textBoxResults = new TextBox();
            Label labelResults = new Label();
            
            SuspendLayout();
            
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite uma string:";
            
            textBoxInput.Location = new Point(20, 40);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(740, 23);
            textBoxInput.TabIndex = 1;
            
            buttonAnalyze.Location = new Point(20, 70);
            buttonAnalyze.Name = "buttonAnalyze";
            buttonAnalyze.Size = new Size(100, 30);
            buttonAnalyze.TabIndex = 2;
            buttonAnalyze.Text = "Analisar";
            buttonAnalyze.UseVisualStyleBackColor = true;
            buttonAnalyze.Click += ButtonAnalyze_Click;
            
            labelResults.AutoSize = true;
            labelResults.Location = new Point(20, 110);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(66, 15);
            labelResults.TabIndex = 3;
            labelResults.Text = "Resultados:";
            
            textBoxResults.Location = new Point(20, 130);
            textBoxResults.Name = "textBoxResults";
            textBoxResults.Multiline = true;
            textBoxResults.ReadOnly = true;
            textBoxResults.ScrollBars = ScrollBars.Vertical;
            textBoxResults.Size = new Size(740, 290);
            textBoxResults.TabIndex = 4;
            
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBoxInput);
            Controls.Add(buttonAnalyze);
            Controls.Add(labelResults);
            Controls.Add(textBoxResults);
            Name = "Form1";
            Text = "Análise de String";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        
        private TextBox textBoxInput;
        private TextBox textBoxResults;
        private Button buttonAnalyze;
    }
}
