using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int soma = 0;
            foreach(char c in box1.Text)
            {
                if (char.IsDigit(c))
                {
                    soma += int.Parse(c.ToString());
                }
            }
            lbl2.Text = ($"A soma será {soma}");
        }
    }
}
