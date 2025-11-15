namespace exer18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonGerar_Click(object sender, EventArgs e)
        {
            TextBox textBoxNumero = (TextBox)Controls["textBoxNumero"];
            TextBox textBoxInicio = (TextBox)Controls["textBoxInicio"];
            TextBox textBoxFim = (TextBox)Controls["textBoxFim"];
            TextBox textBoxResultado = (TextBox)Controls["textBoxResultado"];

            textBoxResultado.Clear();

            if (!int.TryParse(textBoxNumero.Text, out int numero))
            {
                MessageBox.Show("Número inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxInicio.Text, out int inicio))
            {
                MessageBox.Show("Valor inicial inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxFim.Text, out int fim))
            {
                MessageBox.Show("Valor final inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fim < inicio)
            {
                MessageBox.Show("O valor final não pode ser menor que o valor inicial!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBoxResultado.AppendText($"Vou montar a tabuada de {numero} começando em {inicio} e terminando em {fim}:\r\n\r\n");

            for (int i = inicio; i <= fim; i++)
            {
                int resultado = numero * i;
                textBoxResultado.AppendText($"{numero} X {i} = {resultado}\r\n");
            }
        }
    }
}
