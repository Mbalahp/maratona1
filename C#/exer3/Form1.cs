using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio3
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

        private void btn_Click(object sender, EventArgs e)
        {
            int lado1 = int.Parse(box1.Text);
            int lado2 = int.Parse(box2.Text);
            int lado3 = int.Parse(box3.Text);
            if(lado1+lado2>lado3 && lado2+lado3>lado1 && lado1+lado3>lado2)
            {
                if(lado1==lado2 && lado2==lado3)
                {
                    lbl2.Text = "Triângulo Equilátero";
                }
                else if (lado1==lado2 || lado2==lado3 || lado1==lado3)
                {
                    lbl2.Text = "Triângulo Isósceles";
                }
                else
                {
                    lbl2.Text = "Triângulo Escaleno";
                }
            }
            else
            {
                lbl2.Text = "Os valores digitados não formam um triângulo";
            }
        }
    }
}
