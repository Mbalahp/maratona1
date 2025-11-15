namespace exer27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }

            MessageBox.Show($"A soma dos números de 1 a 100 é: {soma}", "Resultado");
        }
    }
}
