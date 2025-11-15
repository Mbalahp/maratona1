namespace exer32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            decimal totalGraos = 0;

            for (int i = 1; i <= 64; i++)
            {
                decimal graos = (decimal)Math.Pow(2, i - 1);
                totalGraos += graos;
            }

            MessageBox.Show($"Total de grãos que o monge recebeu:\n\n{totalGraos}", "Problema do Tabuleiro de Xadrez");
        }
    }
}
