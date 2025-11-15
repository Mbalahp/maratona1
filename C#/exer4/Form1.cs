using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(box1.Text);
            double n2 = double.Parse(box2.Text);
            double n3 = double.Parse(box3.Text);
            double mai = Math.Max(n1, Math.Max(n2, n3));
            double men = Math.Min(n1, Math.Min(n2, n3));
            double inter = (n1 + n2 + n3) - (mai + men);
            lbl2.Text = ($"Maior {mai}\nMenor {men}\nIntermediário {inter}");
        }
    }
}
