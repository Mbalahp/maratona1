namespace exer24
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
            
            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    soma += i;
                }
            }
            
            MessageBox.Show($"A soma dos números ímpares múltiplos de três é: {soma}",
                            "Resultado da Soma",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
