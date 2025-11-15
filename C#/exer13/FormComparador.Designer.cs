using System.Windows.Forms;

namespace tarefa
{
    partial class FormComparador
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Label label2;
        private TextBox txtPalavra1;
        private TextBox txtPalavra2;
        private Button btnComparar;
        private TextBox txtResultado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtPalavra1 = new TextBox();
            txtPalavra2 = new TextBox();
            btnComparar = new Button();
            txtResultado = new TextBox();

            SuspendLayout();

            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.Text = "Palavra 1:";

            txtPalavra1.Location = new Point(12, 38);
            txtPalavra1.Name = "txtPalavra1";
            txtPalavra1.Size = new Size(450, 27);
            txtPalavra1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.Text = "Palavra 2:";

            txtPalavra2.Location = new Point(12, 98);
            txtPalavra2.Name = "txtPalavra2";
            txtPalavra2.Size = new Size(450, 27);
            txtPalavra2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            btnComparar.Location = new Point(470, 38);
            btnComparar.Name = "btnComparar";
            btnComparar.Size = new Size(100, 87);
            btnComparar.Text = "Comparar";
            btnComparar.UseVisualStyleBackColor = true;
            btnComparar.Click += btnComparar_Click;

            txtResultado.Location = new Point(12, 140);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(558, 300);
            txtResultado.Multiline = true;
            txtResultado.ReadOnly = true;
            txtResultado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 460);
            Controls.Add(txtResultado);
            Controls.Add(btnComparar);
            Controls.Add(txtPalavra2);
            Controls.Add(label2);
            Controls.Add(txtPalavra1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormComparador";
            Text = "Comparador de Palavras";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
