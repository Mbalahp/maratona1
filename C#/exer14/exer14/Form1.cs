namespace exer14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TextBox textBox1 = Controls["textBox1"] as TextBox;
            TextBox textBox2 = Controls["textBox2"] as TextBox;
            TextBox resultBox = Controls["resultBox"] as TextBox;

            string palavra1 = textBox1.Text.Trim();
            string palavra2 = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(palavra1) || string.IsNullOrEmpty(palavra2))
            {
                resultBox.Text = "Por favor, digite ambas as palavras.";
                return;
            }

            resultBox.Text = "";

            if (palavra1 == palavra2)
            {
                resultBox.AppendText("As palavras são IGUAIS.\r\n");
            }
            else
            {
                resultBox.AppendText("As palavras são DIFERENTES.\r\n\r\n");

                int comp1 = palavra1.Length;
                int comp2 = palavra2.Length;

                resultBox.AppendText($"Comprimento da Palavra 1: {comp1}\r\n");
                resultBox.AppendText($"Comprimento da Palavra 2: {comp2}\r\n\r\n");

                if (comp1 > comp2)
                {
                    resultBox.AppendText($"A Palavra 1 ({palavra1}) tem maior comprimento.\r\n");
                }
                else if (comp2 > comp1)
                {
                    resultBox.AppendText($"A Palavra 2 ({palavra2}) tem maior comprimento.\r\n");
                }
                else
                {
                    resultBox.AppendText("Ambas as palavras têm o MESMO tamanho.\r\n");
                }
            }

            resultBox.AppendText("\r\n");

            if (palavra1.Contains(palavra2))
            {
                resultBox.AppendText($"A Palavra 2 ({palavra2}) é uma SUBSTRING da Palavra 1 ({palavra1}).\r\n");
            }
            else
            {
                resultBox.AppendText($"A Palavra 2 ({palavra2}) NÃO é uma substring da Palavra 1 ({palavra1}).\r\n");
            }
        }
    }
}
