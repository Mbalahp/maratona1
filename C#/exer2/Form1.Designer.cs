namespace exercicio2
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
            this.box1 = new System.Windows.Forms.TextBox();
            this.box2 = new System.Windows.Forms.TextBox();
            this.box3 = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(103, 87);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(168, 20);
            this.box1.TabIndex = 1;
            this.box1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(103, 126);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(168, 20);
            this.box2.TabIndex = 2;
            // 
            // box3
            // 
            this.box3.Location = new System.Drawing.Point(103, 165);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(168, 20);
            this.box3.TabIndex = 3;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(157, 204);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 4;
            this.btn.Text = "Média";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(114, 49);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(144, 13);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Média de três valores inteiros";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(176, 253);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.TextBox box3;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}

