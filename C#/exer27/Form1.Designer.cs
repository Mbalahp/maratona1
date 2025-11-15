namespace exer27
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
            this.Text = "Exercício 27 - Soma de 1 a 100";
            this.Load += new System.EventHandler(this.Form1_Load);
        }
    }
}
