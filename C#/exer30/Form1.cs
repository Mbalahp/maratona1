namespace exer30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pares = "Números pares entre 85 e 31:\n\n";
            int soma = 0;

            for (int i = 84; i >= 32; i--)
            {
                if (i % 2 == 0)
                {
                    pares += $"{i}\n";
                    soma += i;
                }
            }

            pares += $"\nSoma dos pares: {soma}";

            MessageBox.Show(pares, "Números Pares");
        }
    }
}
