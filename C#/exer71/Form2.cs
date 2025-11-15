using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exer71
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Text = "Exercício 71 - Palíndromo";
        }

        private bool VerificarPalindromo(string texto)
        {
            string limpo = texto.ToUpper().Replace(" ", "").Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "");
            string invertido = "";
            for (int i = limpo.Length - 1; i >= 0; i--)
            {
                invertido += limpo[i];
            }
            return limpo == invertido;
        }
    }
}
