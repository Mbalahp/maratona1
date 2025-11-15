namespace exer29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string multiplos = "Múltiplos positivos de 7 inferiores a 1000:\n\n";

            for (int i = 7; i < 1000; i += 7)
            {
                multiplos += $"{i}\n";
            }

            MessageBox.Show(multiplos, "Múltiplos de 7");
        }
    }
}
