namespace exer28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int somaPositivos = 0;
            int qtdNegativos = 0;

            Random random = new Random();

            for (int i = 0; i < 50; i++)
            {
                int valor = random.Next(-100, 101);

                if (valor > 0)
                    somaPositivos += valor;
                else if (valor < 0)
                    qtdNegativos++;
            }

            string resultado = $"Soma dos números positivos: {somaPositivos}\n" +
                             $"Quantidade de valores negativos: {qtdNegativos}";

            MessageBox.Show(resultado, "Resultado");
        }
    }
}
