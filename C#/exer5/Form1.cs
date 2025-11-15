using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void soma_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(box1.Text);
            double n2 = double.Parse(box2.Text);
            lbl2.Text = ($"A soma dos números é {n1+n2}");
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(box1.Text);
            double n2 = double.Parse(box2.Text);
            lbl2.Text = ($"A soma dos números é {n1 * n2}");
        }

        private void sub_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(box1.Text);
            double n2 = double.Parse(box2.Text);
            lbl2.Text = ($"A soma dos números é {n1 - n2}");
        }

        private void div_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(box1.Text);
            double n2 = double.Parse(box2.Text);
            if (n2 > 0)
                lbl2.Text = ($"A soma dos números é {n1 / n2}");
            else
                lbl2.Text = ("O segundo número é menor ou igual a zero\n(ERRO)");
        }
    }
}
