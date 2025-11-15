namespace exer33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string resultado = "EXERCÍCIO 33\n\n";

            resultado += "a) Executar 10 vezes:\n";
            for (int i = 1; i <= 10; i++)
            {
                int a = 10, b = 3;
                int modulo = a % b;
            }
            resultado += "Executado 10 vezes\n\n";

            resultado += "b) Não executar nenhuma vez:\n";
            for (int i = 0; i < 0; i++)
            {
                int a = 10, b = 3;
                int modulo = a % b;
            }
            resultado += "Não foi executado\n\n";

            resultado += "c) Executar 100 vezes com duas estruturas:\n";
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int a = 10, b = 3;
                    int modulo = a % b;
                }
            }
            resultado += "Executado 100 vezes (10x10)\n\n";

            resultado += "d) Executar N vezes (N = 5):\n";
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                int a = 10, b = 3;
                int modulo = a % b;
            }
            resultado += $"Executado {n} vezes";

            MessageBox.Show(resultado, "Exercício 33 - Variações de Repetição");
        }
    }
}
