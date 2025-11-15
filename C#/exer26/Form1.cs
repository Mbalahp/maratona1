namespace exer26
{
    public partial class Form1 : Form
    {
        private List<Professor> professores = new List<Professor>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LerDadosProfessores();
            ExibirListagem();
            CalcularMedias();
        }

        private void LerDadosProfessores()
        {
            while (true)
            {
                string codigoStr = PromptValor("Digite o código do professor (99999 para encerrar):");
                
                if (!int.TryParse(codigoStr, out int codigo))
                {
                    MessageBox.Show("Código inválido.");
                    continue;
                }

                if (codigo == 99999)
                    break;

                string sexoStr = PromptValor("Digite o sexo (M/F):");
                char sexo = char.ToUpper(sexoStr.Length > 0 ? sexoStr[0] : ' ');

                if (sexo != 'M' && sexo != 'F')
                {
                    MessageBox.Show("Sexo inválido. Use M ou F.");
                    continue;
                }

                string horasStr = PromptValor("Digite o número de horas/aula mensais:");
                
                if (!double.TryParse(horasStr, out double horas))
                {
                    MessageBox.Show("Valor inválido.");
                    continue;
                }

                professores.Add(new Professor
                {
                    Codigo = codigo,
                    Sexo = sexo,
                    HorasAula = horas
                });
            }
        }

        private void ExibirListagem()
        {
            string listagem = "CÓDIGO\t\tSALÁRIO BRUTO\tSALÁRIO LÍQUIDO\n";
            listagem += "===============================================\n";

            foreach (var prof in professores)
            {
                double salarioBruto = prof.HorasAula * 30.0;
                double desconto = prof.Sexo == 'M' ? salarioBruto * 0.10 : salarioBruto * 0.05;
                double salarioLiquido = salarioBruto - desconto;

                listagem += $"{prof.Codigo}\t\tR$ {salarioBruto:F2}\t\tR$ {salarioLiquido:F2}\n";
            }

            MessageBox.Show(listagem, "Listagem de Professores");
        }

        private void CalcularMedias()
        {
            double somaHomens = 0;
            int qtdHomens = 0;
            double somaMultheres = 0;
            int qtdMulheres = 0;

            foreach (var prof in professores)
            {
                double salarioBruto = prof.HorasAula * 30.0;
                double desconto = prof.Sexo == 'M' ? salarioBruto * 0.10 : salarioBruto * 0.05;
                double salarioLiquido = salarioBruto - desconto;

                if (prof.Sexo == 'M')
                {
                    somaHomens += salarioLiquido;
                    qtdHomens++;
                }
                else
                {
                    somaMultheres += salarioLiquido;
                    qtdMulheres++;
                }
            }

            string resultado = "";
            
            if (qtdHomens > 0)
                resultado += $"Média salarial (Homens): R$ {somaHomens / qtdHomens:F2}\n";
            else
                resultado += "Média salarial (Homens): N/A\n";

            if (qtdMulheres > 0)
                resultado += $"Média salarial (Mulheres): R$ {somaMultheres / qtdMulheres:F2}";
            else
                resultado += "Média salarial (Mulheres): N/A";

            MessageBox.Show(resultado, "Médias Salariais");
        }

        private string PromptValor(string mensagem)
        {
            var form = new Form();
            form.Text = "Entrada de Dados";
            form.Width = 300;
            form.Height = 150;
            form.StartPosition = FormStartPosition.CenterParent;

            var label = new Label { Left = 20, Top = 20, Text = mensagem, Width = 260 };
            var textBox = new TextBox { Left = 20, Top = 50, Width = 260 };
            var okButton = new Button { Text = "OK", Left = 120, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            var cancelButton = new Button { Text = "Cancelar", Left = 220, Width = 80, Top = 80, DialogResult = DialogResult.Cancel };

            form.Controls.Add(label);
            form.Controls.Add(textBox);
            form.Controls.Add(okButton);
            form.Controls.Add(cancelButton);
            form.AcceptButton = okButton;
            form.CancelButton = cancelButton;

            return form.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty;
        }
    }

    public class Professor
    {
        public int Codigo { get; set; }
        public char Sexo { get; set; }
        public double HorasAula { get; set; }
    }
}
