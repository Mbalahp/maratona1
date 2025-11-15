namespace exer37
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e)
        {
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                string input = PromptValor($"Digite o número {i + 1}:");
                int.TryParse(input, out numeros[i]);
            }
            double media = numeros.Sum() / 10.0;
            int maior = numeros.Max();
            int menor = numeros.Min();
            MessageBox.Show($"Média: {media:F2}\nMaior: {maior}\nMenor: {menor}");
        }
        private string PromptValor(string msg) { var form = new Form { Text = "Input", Width = 300, Height = 150, StartPosition = FormStartPosition.CenterParent }; var label = new Label { Left = 20, Top = 20, Text = msg, Width = 260 }; var textBox = new TextBox { Left = 20, Top = 50, Width = 260 }; var okButton = new Button { Text = "OK", Left = 120, Width = 100, Top = 80, DialogResult = DialogResult.OK }; form.Controls.Add(label); form.Controls.Add(textBox); form.Controls.Add(okButton); form.AcceptButton = okButton; return form.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty; }
    }
}
