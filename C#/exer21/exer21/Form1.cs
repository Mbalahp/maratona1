namespace exer21
{
    public partial class Form1 : Form
    {
        private string[] names = new string[10];
        private int nameCount = 0;

        public Form1()
        {
            InitializeComponent();
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            Button btnAddName = (Button)Controls["btnAddName"];
            Button btnSearch = (Button)Controls["btnSearch"];

            btnAddName.Click += BtnAddName_Click;
            btnSearch.Click += BtnSearch_Click;
        }

        private void BtnAddName_Click(object sender, EventArgs e)
        {
            TextBox txtName = (TextBox)Controls["txtName"];
            ListBox lstNames = (ListBox)Controls["lstNames"];

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Por favor, digite um nome.", "Validação");
                return;
            }

            if (nameCount >= 10)
            {
                MessageBox.Show("Você já digitou 10 nomes.", "Limite Atingido");
                return;
            }

            names[nameCount] = txtName.Text.Trim();
            lstNames.Items.Add(names[nameCount]);
            nameCount++;

            txtName.Clear();
            txtName.Focus();

            if (nameCount == 10)
            {
                MessageBox.Show("Todos os 10 nomes foram digitados.", "Completo");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            TextBox txtSearch = (TextBox)Controls["txtSearch"];
            Label lblResult = (Label)Controls["lblResult"];

            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Por favor, digite um nome para procurar.", "Validação");
                return;
            }

            if (nameCount < 10)
            {
                MessageBox.Show("Por favor, digite todos os 10 nomes primeiro.", "Incompleto");
                return;
            }

            string searchName = txtSearch.Text.Trim();
            bool found = false;

            for (int i = 0; i < 10; i++)
            {
                if (names[i].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                lblResult.Text = "ACHEI";
                lblResult.ForeColor = Color.Green;
            }
            else
            {
                lblResult.Text = "NÃO ACHEI";
                lblResult.ForeColor = Color.Red;
            }

            txtSearch.Clear();
            txtSearch.Focus();
        }
    }
}
