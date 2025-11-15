using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(box1.Text);
            int n2 = int.Parse(box2.Text);
            int n3 = int.Parse(box3.Text);
            double media =(n1 + n2 + n3) / 3.0;
            lbl2.Text = ("A sua média é "+media.ToString());
        }
    }
}
