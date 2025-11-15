using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int termos = int.Parse(textBox1.Text);
            int fib1 = 0, fib2=1;
            lbl2.Text += ($"Os primeiros {termos} da sequencia de fibonacci são: ");
            for(int i =0; i < termos; i++)
            {
                lbl2.Text += ($"\n{fib1}");
                int auxiliar = fib1 + fib2;
                fib1 = fib2;
                fib2 = auxiliar;
            }
        }
    }
}
