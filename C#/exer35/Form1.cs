namespace exer35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string numeroStr = PromptValor("Digite um número para ver a tabela de multiplicação:");

            if (int.TryParse(numeroStr, out int numero))
            {
                string tabela = $"Tabela de multiplicação de {numero}:\n\n";

                for (int i = 1; i <= 13; i++)
                {
                    tabela += $"{numero} x {i} = {numero * i}\n";
                }

                MessageBox.Show(tabela, "Tabela de Multiplicação");
            }
            else
            {
                MessageBox.Show("Número inválido!");
            }
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
