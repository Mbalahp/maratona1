using System;
using System.Windows.Forms;

namespace exer14
{
    public partial class FormComparador : Form
    {
        public FormComparador()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            string palavra1 = txtPalavra1.Text.Trim();
            string palavra2 = txtPalavra2.Text.Trim();

            if (string.IsNullOrEmpty(palavra1) || string.IsNullOrEmpty(palavra2))
            {
                txtResultado.Text = "Digite ambas as palavras!";
                return;
            }

            string resultado = "";

            if (palavra1.Equals(palavra2, StringComparison.OrdinalIgnoreCase))
            {
                resultado += "a) As palavras são IGUAIS\r\n";
            }
            else
            {
                resultado += "a) As palavras são DIFERENTES\r\n";
                resultado += "\r\nb) Comprimento:\r\n";
                resultado += $"   Palavra 1: {palavra1.Length} caracteres\r\n";
                resultado += $"   Palavra 2: {palavra2.Length} caracteres\r\n";

                if (palavra1.Length > palavra2.Length)
                {
                    resultado += $"   ? A palavra 1 tem maior comprimento\r\n";
                }
                else if (palavra2.Length > palavra1.Length)
                {
                    resultado += $"   ? A palavra 2 tem maior comprimento\r\n";
                }
                else
                {
                    resultado += $"   ? As palavras têm o mesmo comprimento\r\n";
                }
            }

            resultado += "\r\nc) Substring:\r\n";
            if (palavra1.Contains(palavra2, StringComparison.OrdinalIgnoreCase))
            {
                resultado += $"   ? '{palavra2}' é substring de '{palavra1}'";
            }
            else
            {
                resultado += $"   ? '{palavra2}' NÃO é substring de '{palavra1}'";
            }

            txtResultado.Text = resultado;
        }
    }
}
