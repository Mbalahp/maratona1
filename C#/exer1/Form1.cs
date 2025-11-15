using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int totalSeg = int.Parse(Txtbox.Text);
            int horas = totalSeg/3600;
            int min = (totalSeg % 3600) / 60;
            int sec = totalSeg % 60;
            string strHora = Convert.ToString(horas);
            string strMin = Convert.ToString(min);
            string strsec = Convert.ToString(sec);
            lbl2.Text = (strHora+" hora(s) " + strMin+" minuto(s) " + strsec+" segundo(s)");
        }
    }
}
