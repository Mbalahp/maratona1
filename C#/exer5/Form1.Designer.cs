namespace exercicio5
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.TextBox();
            this.soma = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.Multiplicar = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.box2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(169, 182);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calculadora Simples";
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(64, 62);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(100, 20);
            this.box1.TabIndex = 2;
            // 
            // soma
            // 
            this.soma.Location = new System.Drawing.Point(21, 102);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(75, 23);
            this.soma.TabIndex = 3;
            this.soma.Text = "Somar";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(274, 102);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 23);
            this.div.TabIndex = 4;
            this.div.Text = "Dividir";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // Multiplicar
            // 
            this.Multiplicar.Location = new System.Drawing.Point(183, 102);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(75, 23);
            this.Multiplicar.TabIndex = 5;
            this.Multiplicar.Text = "Multiplicar";
            this.Multiplicar.UseVisualStyleBackColor = true;
            this.Multiplicar.Click += new System.EventHandler(this.Multiplicar_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(102, 102);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 23);
            this.sub.TabIndex = 8;
            this.sub.Text = "Subtracção";
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(193, 62);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(100, 20);
            this.box2.TabIndex = 7;
            this.box2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.Multiplicar);
            this.Controls.Add(this.div);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button Multiplicar;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.TextBox box2;
    }
}

