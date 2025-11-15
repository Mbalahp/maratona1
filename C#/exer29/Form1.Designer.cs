namespace exer29
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Text = "Exercício 29 - Múltiplos de 7";
            this.Load += new System.EventHandler(this.Form1_Load);
        }
    }
}
