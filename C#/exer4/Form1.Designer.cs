namespace exercicio4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.TextBox();
            this.box3 = new System.Windows.Forms.TextBox();
            this.box2 = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maior,Menor e o Intermediário";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(164, 263);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Click += new System.EventHandler(this.label2_Click);
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(137, 80);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(100, 20);
            this.box1.TabIndex = 2;
            // 
            // box3
            // 
            this.box3.Location = new System.Drawing.Point(137, 165);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(100, 20);
            this.box3.TabIndex = 3;
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(137, 129);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(100, 20);
            this.box2.TabIndex = 4;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(151, 205);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 5;
            this.btn.Text = "Mostrar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.TextBox box3;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.Button btn;
    }
}

