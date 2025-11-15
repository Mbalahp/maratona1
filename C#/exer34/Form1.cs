namespace exer34
{
    public partial class Form1 : Form
    {
        private List<Aluno> alunos = new List<Aluno>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LerDadosAlunos();
            CalcularMedias();
        }

        private void LerDadosAlunos()
        {
            Random random = new Random();

            for (int i = 0; i < 45; i++)
            {
                int idade = random.Next(15, 25);
                double altura = 1.50 + (random.NextDouble() * 0.50);

                alunos.Add(new Aluno
                {
                    Idade = idade,
                    Altura = altura
                });
            }
        }

        private void CalcularMedias()
        {
            double somaIdadeBaixos = 0;
            int qtdBaixos = 0;
            double somaAlturasAltos = 0;
            int qtdAltos = 0;

            foreach (var aluno in alunos)
            {
                if (aluno.Altura < 1.70)
                {
                    somaIdadeBaixos += aluno.Idade;
                    qtdBaixos++;
                }

                if (aluno.Idade > 20)
                {
                    somaAlturasAltos += aluno.Altura;
                    qtdAltos++;
                }
            }

            string resultado = "";

            if (qtdBaixos > 0)
                resultado += $"a) Idade média (altura < 1,70m): {somaIdadeBaixos / qtdBaixos:F2} anos\n\n";
            else
                resultado += "a) Nenhum aluno com altura < 1,70m\n\n";

            if (qtdAltos > 0)
                resultado += $"b) Altura média (idade > 20 anos): {somaAlturasAltos / qtdAltos:F2}m";
            else
                resultado += "b) Nenhum aluno com idade > 20 anos";

            MessageBox.Show(resultado, "Resultado");
        }
    }

    public class Aluno
    {
        public int Idade { get; set; }
        public double Altura { get; set; }
    }
}
