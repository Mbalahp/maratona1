namespace exer36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string qtdStr = PromptValor("Digite a quantidade de funcionários:");
            
            if (!int.TryParse(qtdStr, out int qtd) || qtd <= 0)
            {
                MessageBox.Show("Valor inválido!");
                return;
            }

            List<(string nome, double salario)> funcionarios = new List<(string, double)>();
            double somaSalarios = 0;
            double maiorSalario = double.MinValue;
            double menorSalario = double.MaxValue;

            for (int i = 0; i < qtd; i++)
            {
                string nome = PromptValor($"Digite o nome do funcionário {i + 1}:");
                string salarioStr = PromptValor($"Digite o salário de {nome}:");

                if (double.TryParse(salarioStr, out double salario))
                {
                    funcionarios.Add((nome, salario));
                    somaSalarios += salario;
                    maiorSalario = Math.Max(maiorSalario, salario);
                    menorSalario = Math.Min(menorSalario, salario);
                }
            }

            double media = somaSalarios / qtd;
            string resultado = $"Média de salários: R$ {media:F2}\n" +
                             $"Maior salário: R$ {maiorSalario:F2}\n" +
                             $"Menor salário: R$ {menorSalario:F2}";

            MessageBox.Show(resultado, "Resultado");
        }

        private string PromptValor(string mensagem)
        {
            var form = new Form { Text = "Entrada", Width = 300, Height = 150, StartPosition = FormStartPosition.CenterParent };
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
}
