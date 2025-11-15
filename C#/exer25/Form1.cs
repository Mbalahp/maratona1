namespace exer25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<double> valores = new List<double>();
            double valor;
            int positivos = 0;
            int negativos = 0;
            double soma = 0;

            while (true)
            {
                string entrada = PromptValor("Digite um valor (ou deixe em branco para encerrar):");
                
                if (string.IsNullOrWhiteSpace(entrada))
                    break;

                if (double.TryParse(entrada, out valor))
                {
                    valores.Add(valor);
                    soma += valor;

                    if (valor > 0)
                        positivos++;
                    else if (valor < 0)
                        negativos++;
                }
                else
                {
                    MessageBox.Show("Valor inválido. Tente novamente.");
                }
            }

            if (valores.Count == 0)
            {
                MessageBox.Show("Nenhum valor foi lido.");
                return;
            }

            double media = soma / valores.Count;
            double percentualPositivos = (positivos * 100.0) / valores.Count;
            double percentualNegativos = (negativos * 100.0) / valores.Count;

            string resultado = $"Média aritmética: {media:F2}\n" +
                             $"Quantidade de valores positivos: {positivos}\n" +
                             $"Quantidade de valores negativos: {negativos}\n" +
                             $"Percentual de valores positivos: {percentualPositivos:F2}%\n" +
                             $"Percentual de valores negativos: {percentualNegativos:F2}%";

            MessageBox.Show(resultado, "Resultado");
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
}
