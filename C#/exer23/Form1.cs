namespace exer23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void ButtonGerar_Click(object sender, EventArgs e)
        {
            TextBox textBoxBase = Controls["textBoxBase"] as TextBox;
            TextBox textBoxTriangle = Controls["textBoxTriangle"] as TextBox;
            
            if (!int.TryParse(textBoxBase.Text, out int tamanhoBase))
            {
                MessageBox.Show("Digite um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (tamanhoBase < 5 || tamanhoBase > 15)
            {
                MessageBox.Show("O tamanho da base deve estar entre 5 e 15!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            textBoxTriangle.Text = GerarTriangulo(tamanhoBase);
        }
        
        private string GerarTriangulo(int tamanhoBase)
        {
            string resultado = "";
            
            for (int i = 1; i <= tamanhoBase; i++)
            {
                int quantidadeHashes = 2 * i - 1;
                int espacos = (tamanhoBase - i);
                
                resultado += new string(' ', espacos) + new string('#', quantidadeHashes) + "\n";
            }
            
            return resultado;
        }
    }
}
